Imports System.Windows.Forms
Imports System.ComponentModel

Namespace Visita.Movimiento
    Public Class frmVisitanteReniec
        Private frmLoad As Load.frmLoad02 = Nothing
        Private objResult As Bussines.Visita.VisitanteReniec.objDTOPersona = Nothing
        Private objColor As Color

#Region "Propiedades"
        Private Property IDVisitante As Integer = -1
        
        Private Property TipoDocumento() As String
            Get
                Return Me.txtTipoDoc.Text
            End Get
            Set(value As String)
                Me.txtTipoDoc.Text = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property DigitoVerificacion() As String
            Get
                Return Me.txtDigitoVeri.Text
            End Get
            Set(ByVal value As String)
                Me.txtDigitoVeri.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.txtPrimerApellido.Text()
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property
        Private Property ApellidoCasada() As String
            Get
                Return Me.txtApellidoCasada.Text
            End Get
            Set(ByVal value As String)
                Me.txtApellidoCasada.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private Property SexoID() As Integer = -1
        Private Property SexoNom() As String
            Get
                Return Me.txtSexo.Text
            End Get
            Set(ByVal value As String)
                Me.txtSexo.Text = value
            End Set
        End Property

        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNac.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNac.Text = value
            End Set
        End Property
        Private Property Nacionalidad() As String
            Get
                Return Me.txtNacionalidad.Text
            End Get
            Set(value As String)
                Me.txtNacionalidad.Text = value
            End Set
        End Property
        Private Property Restriccion() As String
            Get
                Return Me.txtRestriccion.Text
            End Get
            Set(ByVal value As String)
                Me.txtRestriccion.Text = value
            End Set
        End Property
        Public Property FotoByte() As Byte() = Nothing

#End Region

#Region "Propiedades_Buscar"
        Private ReadOnly Property IDRegion() As Integer
            Get

                Return Me.UsrRegionPenal1._RegionID
            End Get

        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.UsrRegionPenal1._RegionNombre
            End Get
        End Property
        Private ReadOnly Property IDPenal() As Integer
            Get

                Return Me.UsrRegionPenal1._PenalID
            End Get

        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.UsrRegionPenal1._PenalNombre
            End Get
        End Property
        Private Property BuscarIDTipoDocumento() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property BuscarDNI As String
            Get
                Return Me.txtBuscarNumDoc.Text
            End Get
            Set(value As String)
                Me.txtBuscarNumDoc.Text = value
            End Set
        End Property
#End Region

#Region "Propieades_Otros"
        Private ReadOnly Property FechaHoy As Long
            Get

                Dim lngFechaHoyLocal As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Dim lngfechaHoyBD As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

                Dim value As Long = lngFechaHoyLocal

                If lngFechaHoyLocal <> lngfechaHoyBD Then
                    value = lngfechaHoyBD
                End If

                Return value
            End Get
        End Property
#End Region
#Region "Combo"
        Private blnComboTipoDoc As Boolean = False
        Private Sub ComboDocumentoTipo()

            '/*tipo documento*/
            With Me.cbbTipoDoc
                .ComboTipo = Type.Combo.ComboTipo.TipoDoc
                .LoadUsc()
                .SelectedValue = 10 'dni
            End With
            blnComboTipoDoc = True
        End Sub
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.LicenciaTieneSistemaVisita
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._PenalTodos = False
                ._LoadUsc()
            End With

        End Sub
#End Region

#Region "Accion"
        Private Sub BuscarVisitante()

            ListarVisitante()

            If Me.IDVisitante < 1 Then
                If Me.BuscarIDTipoDocumento = 10 Then 'dni
                    ListarVisitanteReniec()
                Else
                    MessageBox.Show("Datos no encontrados", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            Me.pnlBusqueda.Enabled = False

        End Sub
        Private Sub ListarVisitanteReniec()

            Dim objPersona As New APPWebService.ws_reniec_sede.NumeroDocumento
            Dim blnHayReniec As Boolean = True
            Dim blnCancelarVerificacion As Boolean = False
            Dim strErrorReniec As String = ""
            Dim strMensajeReniec As String = ""

            Dim strMensaje As String = ""

            objPersona = ConsultarReniec(Me.BuscarDNI, blnHayReniec, blnCancelarVerificacion, strErrorReniec, strMensajeReniec)

            If blnCancelarVerificacion = True Then
                strMensaje = "Se canceló el proceso de verificacion con Reniec"
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
            Else

                If blnHayReniec = True Then

                    If strErrorReniec <> 0 Then ' si presenta algun tipo de error en la reniec 

                        strMensaje = "La verificacion con Reniec ha encontrado el siguiente problema;" & Chr(13) _
                        & "Codigo Error: " & strErrorReniec & "-" & strMensajeReniec
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)

                        Me.txtBuscarNumDoc.SelectAll()
                        Me.txtBuscarNumDoc.Focus()
                        Exit Sub

                    Else

                        If Not objPersona Is Nothing Then

                            'preguntamos si el dni devulto x reniec es el mismo
                            If objPersona.NumeroDNI = Me.BuscarDNI Then

                                Dim lngFecNac As Long = 0
                                With objPersona
                                    Me.NumeroDocumento = .NumeroDNI.Trim
                                    Me.TipoDocumento = "D.N.I."
                                    Me.DigitoVerificacion = .DigitoVerificacion.Trim
                                    Me.ApellidoPaterno = .ApellidoPaterno.Trim
                                    Me.ApellidoMaterno = .ApellidoMaterno.Trim
                                    Me.Nombres = .Nombres.Trim
                                    Me.SexoID = .Sexo

                                    If Me.SexoID = 1 Then
                                        Me.SexoNom = "Masculino"
                                    Else
                                        Me.SexoNom = "Femenino"
                                    End If

                                    'Me.Nacionalidad = 141 'peru
                                    Me.picFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(.FotoByte)
                                    Me.Restriccion = .RestriccionMensaje.Trim()

                                    Me.FechaNacimiento = .FechaNacimiento.Trim
                                    Me.Nacionalidad = "PERUANA"

                                    '/*calcular edad*/
                                    If .FechaNacimiento.Length > 8 Then

                                        Dim FechaNacimientoLong As Long = Legolas.Components.FechaHora.FechaLong(Me.FechaNacimiento)
                                        Dim lngFechaHoy As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

                                        Dim intEdad As Integer = Legolas.Components.FechaHora.FechaCalcularAnio(FechaNacimientoLong, lngFechaHoy, True)
                                        Me.FechaNacimiento = Me.FechaNacimiento & " - " & intEdad & " Años"
                                    End If

                                    Me.picFoto.Visible = True
                                    Me.UscFotografia1.Visible = False

                                End With

                            End If

                        End If

                    End If

                Else

                    strMensaje = "En este momento no se encuentra disponible el Servicio de Reniec;"
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                End If

            End If

            Me.btnNuevo.Focus()


        End Sub

        Private Sub ListarVisitante()

            Me.Cursor = Cursors.WaitCursor

            Dim objEntCol As New Entity.Visita.VisitanteCol
            Dim objBssVis As New Bussines.Visita.Visitante
            objEntCol = objBssVis.ListarxNumeroDocumento(Me.BuscarIDTipoDocumento, Me.BuscarDNI, Me.IDRegion, Me.IDPenal)

            If objEntCol.Count > 0 Then

                For Each obj As Entity.Visita.Visitante In objEntCol
                    'queda
                    If obj.PenalID = Me.IDPenal And obj.TipoDocumentoID = Me.BuscarIDTipoDocumento Then

                        If obj.Codigo < 1 Then
                            Exit Sub
                        End If

                        objBssVis = New Bussines.Visita.Visitante
                        Dim objEnt As Entity.Visita.Visitante

                        objEnt = objBssVis.Listar(obj.Codigo)

                        With objEnt
                            Me.IDVisitante = .Codigo
                            Me.BuscarIDTipoDocumento = .TipoDocumentoID
                            Me.NumeroDocumento = .NumeroDocumento
                            Me.TipoDocumento = .TipoDocumentoNombre
                            Me.DigitoVerificacion = ""
                            Me.ApellidoPaterno = .ApellidoPaterno
                            Me.ApellidoMaterno = .ApellidoMaterno
                            Me.Nombres = .Nombres
                            Me.Nacionalidad = .NacionalidadNombre

                            'sexo
                            Dim strSexo As String = ""
                            strSexo = .SexoNombre

                            If strSexo = "M" Then
                                Me.SexoNom = "MASCULINO"
                            End If

                            If strSexo = "F" Then
                                Me.SexoNom = "FEMENINO"
                            End If

                            Me.Restriccion = ""

                            '/*calcular edad*/
                            Dim lngFechaNac As Long = 0
                            lngFechaNac = .FechaNacimiento

                            If lngFechaNac > 1 Then

                                Me.FechaNacimiento = Legolas.Components.FechaHora.FechaString(lngFechaNac)
                                Dim lngFechaHoy As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

                                Dim intEdad As Integer = Legolas.Components.FechaHora.FechaCalcularAnio(lngFechaNac, lngFechaHoy, True)
                                Me.FechaNacimiento = Me.FechaNacimiento & " - " & intEdad & " Años"
                            End If

                            'foto del visitante
                            ImagenFotoVisitante(.FotoName)

                        End With

                        Exit For
                    End If
                Next
            End If

            Me.Cursor = Cursors.Default

        End Sub

        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            Me.picFoto.Visible = False
            Me.UscFotografia1.Visible = True
            With Me.UscFotografia1
                '._TipoImagen = Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub

        Private Sub ListarSancion()

            'Dim intIDVisitante As Integer = -1
            'Dim objEntCol As New Entity.Visita.VisitanteCol
            'Dim objBss As New Bussines.Visita.Visitante

            'objEntCol = objBss.ListarxNumeroDocumento(Me.BuscarDNI, Me.IDRegion, IDPenal)

            'If objEntCol.Count > 0 Then
            '    For Each ent As Entity.Visita.Visitante In objEntCol
            '        'queda
            '        If ent.PenalID = Me.IDPenal Then
            '            intIDVisitante = ent.Codigo
            '            Exit For
            '        End If
            '    Next
            'End If

            If Me.IDVisitante < 1 Then
                Exit Sub
            End If

            Dim objBssVisSan As New Bussines.Visita.VisitanteSancion

            Dim intIDSancionVisita As Integer = objBssVisSan.IDUltimaSancionVigente(Me.IDVisitante, _
                                                                     Legolas.Configuration.Aplication.FechayHora.FechaLong)

            If intIDSancionVisita > 0 Then

                objBssVisSan = New Bussines.Visita.VisitanteSancion

                With Me.dgwGrilla
                    .RowsDefaultCellStyle.SelectionBackColor = Color.LightCoral
                    .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                    .AllowUserToResizeRows = False
                    .AutoGenerateColumns = False

                    .DataSource = objBssVisSan.Listar(intIDSancionVisita, Me.IDVisitante, "", "", "", "", 0, 0, 0, -1, -1, -1)
                End With

            End If

        End Sub


#End Region

#Region "Reniec"
        Private Function ConsultarReniec(strNumeroDNI As String, ByRef blnHayReniec As Boolean,
                             ByRef blnCancelarVerificacion As Boolean, ByRef strCodigoErrorReniec As String, ByRef strMensajeReniec As String) As APPWebService.ws_reniec_sede.NumeroDocumento

            Dim value As New APPWebService.ws_reniec_sede.NumeroDocumento
            Me.SuspendLayout()

            If Me.BackgroundWorker1.IsBusy Then
                Return value
            End If

            Me.BackgroundWorker1.RunWorkerAsync(strNumeroDNI)

            blnCancelarVerificacion = False

            frmLoad = New Load.frmLoad02
            If frmLoad.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Me.BackgroundWorker1.CancelAsync()
                'Me.BackgroundWorker1.Dispose()
                blnCancelarVerificacion = True
            End If
            Me.ResumeLayout(True)
            frmLoad.Refresh()

            If blnCancelarVerificacion = False Then
                value = objResult.objPersona
                blnHayReniec = objResult.HayServicioReniec
                strCodigoErrorReniec = objResult.ErrorCodigo
                strMensajeReniec = objResult.ErrorMensaje
            End If

            Return value

        End Function
        Private Function ConsultarReniecHilo(ByVal worker As BackgroundWorker, ByVal e As DoWorkEventArgs) As Bussines.Visita.VisitanteReniec.objDTOPersona

            Dim value As New Bussines.Visita.VisitanteReniec.objDTOPersona

            If worker.CancellationPending = True Then

                e.Cancel = True

            Else

                Dim objBssMQReniec As New Bussines.Globall.Reniec
                Dim objPersonaCabecera As New APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
                Dim intErrorCodigo As String = -1
                Dim strErrorMensaje As String = ""


                Try
                    objPersonaCabecera = objBssMQReniec.WS_ReniecxDNI_Resultado(e.Argument, intErrorCodigo, strErrorMensaje)

                    value.objPersona = objPersonaCabecera.Resultado
                    value.ErrorCodigo = intErrorCodigo
                    value.ErrorMensaje = strErrorMensaje

                    If intErrorCodigo = 0 Then
                        value.HayServicioReniec = True
                    End If

                Catch ex As Exception
                    value.HayServicioReniec = False
                End Try

            End If

            Return value

        End Function
#End Region

#Region "Otros"
        Private Sub ValidarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.BuscarIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.LE
                    Me.txtBuscarNumDoc.MaxLength = 8
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtBuscarNumDoc.MaxLength = 8
                Case Else
                    Me.txtBuscarNumDoc.MaxLength = 20
            End Select

            Select Case Me.BuscarIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.CE, _
                    Type.Enumeracion.enmTipoDocumento.PAS, _
                    Type.Enumeracion.enmTipoDocumento.PN, _
                    Type.Enumeracion.enmTipoDocumento.CC

                    Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal

                Case Else

                    Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros

            End Select

            Me.txtBuscarNumDoc.Text = ""
            Me.txtBuscarNumDoc.Focus()

        End Sub
        Private Sub mostrarRestriccion()

            If Me.Restriccion.Length > 2 Then
                Me.txtRestriccion.BackColor = Color.Tomato
            Else
                Me.txtRestriccion.BackColor = objColor
            End If

        End Sub
        Private Sub ValoresIniciales()

            Me.lblFechaHoy.Text = Legolas.Components.FechaHora.FechaText(Me.FechaHoy, Legolas.Components.FechaHora.enmFechaLong.enmAll).ToUpper

            objColor = Me.txtRestriccion.BackColor

        End Sub
        Private Sub ALimpiar()

            Me.BuscarDNI = ""
            Me.NumeroDocumento = ""
            Me.DigitoVerificacion = ""
            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Nombres = ""
            Me.SexoNom = ""
            Me.picFoto.Image = Nothing
            Me.Restriccion = ""
            Me.FechaNacimiento = ""
            Me.TipoDocumento = ""
            Me.Nacionalidad = ""

            Me.IDVisitante = -1

            mostrarRestriccion()
            Me.dgwGrilla.DataSource = Nothing

            Me.picFoto.Visible = True
            Me.UscFotografia1.Visible = False

            Me.BuscarIDTipoDocumento = 10 'dni

            Me.pnlBusqueda.Enabled = True
            Me.txtBuscarNumDoc.Focus()

        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub frmReniecLinea_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Me.WindowState = FormWindowState.Maximized
            ComboRegionPenal()
            ComboDocumentoTipo()
            ValoresIniciales()

        End Sub

        Private Sub frmReniecLinea_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.txtBuscarNumDoc.Focus()

        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevo.Click

            ALimpiar()

        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

            BuscarVisitante()
            mostrarRestriccion()
            ListarSancion()

        End Sub

        Private Sub BackgroundWorker1_Disposed(sender As Object, e As System.EventArgs) Handles BackgroundWorker1.Disposed

            If Me.BackgroundWorker1.CancellationPending = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario cancelo el proceso de busqueda")
                Me.BackgroundWorker1 = Nothing
            End If

        End Sub

        Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

            Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

            If Me.BackgroundWorker1.CancellationPending = True Then
                e.Cancel = True
            Else

                Dim blnHayReniec As Boolean = False
                Dim strErrorReniec As String = ""
                Dim strMensajeReniec As String = ""

                e.Result = ConsultarReniecHilo(worker, e)

            End If

        End Sub

        Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

            'frmLoad.Dispose()            
            If e.Cancelled = False AndAlso e.Error Is Nothing Then
                frmLoad.Close()

                objResult = New Bussines.Visita.VisitanteReniec.objDTOPersona
                objResult = e.Result

            End If

        End Sub

        Private Sub txtNumDoc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                btnBuscar.PerformClick()
            End If

        End Sub

        Private Sub txtNumDoc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtBuscarNumDoc.TextChanged

        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged

            If Me.BuscarIDTipoDocumento > 0 And blnComboTipoDoc = True Then
                ValidarNumeroDocumento()
            End If

        End Sub

       
        Private Sub cbbTipoDoc_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipoDoc.Load

        End Sub
    End Class
End Namespace