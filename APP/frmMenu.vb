Imports System.IO 'tmp
Imports System.Data.SqlClient 'tmp
Imports System.Reflection
Public Class frmMenu
    Private frmLoad As Load.frmLoad = Nothing
    Public Enum enmTranfenrenciaTipo
        Ninguno = 0
        Subir = 1
        Bajar = 2
    End Enum
#Region "Propiedades"
    Private strNumDoc As String = ""
    Private Property Login() As String
        Get
            Return Me.txtLogin.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtLogin.Text = value
        End Set
    End Property
    Private Property ApellidosyNombres() As String
        Get
            Return Me.txtApeNom.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtApeNom.Text = value
        End Set
    End Property
    Private Property Dependencia() As String
        Get
            Return Me.txtDepen.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtDepen.Text = value
        End Set
    End Property
    Private Property Establecimiento() As String
        Get
            Return Me.txtEsta.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtEsta.Text = value
        End Set
    End Property
    Private Property Perfil() As String
        Get
            Return Me.txtPerfil.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtPerfil.Text = value
        End Set
    End Property
    Private Property FechaIngreso() As String
        Get
            Return Me.txtFecIng.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtFecIng.Text = value
        End Set
    End Property
    Private Property PCIP() As String
        Get
            Return Me.txtIP.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtIP.Text = value
        End Set
    End Property
    Private Property NumDoc() As String
        Get
            Return strNumDoc.Trim
        End Get
        Set(ByVal value As String)
            strNumDoc = value
        End Set
    End Property
#End Region
#Region "Propiedades_Otros"
    Private intTransferenciaTipo As enmTranfenrenciaTipo = enmTranfenrenciaTipo.Ninguno
    Private Property TransferenciaTipo() As enmTranfenrenciaTipo
        Get
            Return intTransferenciaTipo
        End Get
        Set(ByVal value As enmTranfenrenciaTipo)
            intTransferenciaTipo = value
        End Set
    End Property
#End Region
#Region "Listar"
    Private Sub ListarData()

        Me.Login = Legolas.Configuration.Usuario.Login
        Me.ApellidosyNombres = Legolas.Configuration.Usuario.ApellidosyNombre
        Me.Dependencia = Legolas.Configuration.Usuario.Oficina
        Me.Establecimiento = ""
        Me.Perfil = ""
        Me.FechaIngreso = Legolas.Configuration.Aplication.FechayHora.FechaString
        Me.PCIP = Legolas.Components.PC.GetIP
        'Me.NumDoc = Configuracion.Usuario.NumeroDocumento

        ListarFoto()

    End Sub
    Private Sub ListarFoto()

        '/**********************************/
        Dim objImagen As Image = My.Resources.sin_foto
        Dim strDNIJpg As String = Me.NumDoc & ".jpg"

        Dim strFotoLocal As String = Legolas.Configuration.Path.FotoPersonal & strDNIJpg

        If Legolas.Components.PC.IsOnline = True Then

            'si hay foto
            Dim objWS As New APPWebService.ws_foto.PopeLocal
            'objWS.Url = APPWebService.PathURL.FotoPersonal

            Dim objImagenByte As Byte()
            Dim objImagenStream As New MemoryStream

            objImagenByte = objWS.LeerImageJpg(strDNIJpg, 2) 'personal

            If objImagenByte Is Nothing Then
                objImagen = My.Resources.sin_foto
            Else

                objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)

                Try
                    objImagen = Image.FromStream(objImagenStream)
                Catch ex As Exception
                    objImagen = My.Resources.sin_foto
                End Try
            End If

            Me.PictureBox1.Image = objImagen
            Me.PictureBox1.Image.Save(strFotoLocal)

        Else

            If Legolas.Components.Archivo.FileExiste(strFotoLocal) = True Then
                Me.PictureBox1.Image = Image.FromFile(strFotoLocal)
            Else
                Me.PictureBox1.Image = objImagen
            End If

        End If

    End Sub
#End Region
#Region "Menu"
    Private _objBotonesReversa() As ToolStripItem
    Private Sub AbrirFormulario(ByVal ModuloID As Integer, ByVal ModuloNombre As String, ByVal ModuloObjeto As String)

        Select Case ModuloID
            Case 3 'registro                
                Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                    'Case 1 'sede central

                    'Case Else
                    '    ModuloObjeto = "Registro.frmNombresAsociados"
                End Select
        End Select

        Dim strBaseNamespace As String = "SIPPOPE" '"Legolas.Calipso.Win"
        strBaseNamespace &= "." & ModuloObjeto

        If ModuloObjeto <> String.Empty Then

            Dim Frm As System.Windows.Forms.Form
            'Dim Frm As Legolas.APPUIComponents.Form

            If ModuloID > 0 Then

                Dim objEntUsuarioModulo As New Legolas.LEntity.Seguridad.UsuarioModuloCol
                Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

                objEntUsuarioModulo = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, ModuloID)

                If objEntUsuarioModulo IsNot Nothing Then
                    If objEntUsuarioModulo.Count = 1 Then

                        Dim frmPrin As New MDIParent1

                        With MDIParent1
                            '.NameForm = strBaseNamespace
                            '._ModuloID = objEntUsuarioModulo.Item(0).ModuloCodigo
                            '.ModuloNombre = ModuloNombre
                            '.Show()
                        End With

                        'Frm = Activator.CreateInstance(System.Type.GetType(strBaseNamespace))
                        ''Frm.ModuloID = ModuloID
                        'Frm.Text = ModuloNombre
                        ''Frm.MdiParent = Me
                        ''oFrm.Lectura = entUsuariosModulos.Item(0).Lectura
                        ''oFrm.Escritura = entUsuariosModulos.Item(0).Escritura
                        ''Frm.AplicarSeguridad = False
                        ''Frm.WindowState = FormWindowState.Maximized
                        'Frm.Show()

                        ''mdiFormularios.TabFromForm(oFrm).Settings.AllowClose = Infragistics.Win.DefaultableBoolean.False

                    End If
                End If
            Else
                Frm = Activator.CreateInstance(System.Type.GetType(strBaseNamespace))
                'Frm.ModuloID = 0
                Frm.Text = "Inicio"
                Frm.MdiParent = Me
                'Frm.AplicarSeguridad = False
                Frm.WindowState = FormWindowState.Maximized
                Frm.Show()
                'mdiFormularios.TabFromForm(oFrm).Settings.AllowClose = Infragistics.Win.DefaultableBoolean.False
            End If
        End If
        'End If
    End Sub
    Private Sub CerrarFormularios()
        If Not Me.MdiChildren Is Nothing Then
            For Each frmControl As Form In Me.MdiChildren
                frmControl.Close()
            Next
        End If
    End Sub
    Private Sub ConfigurarBotonInicio()

        Dim tsbModulo As New APPControls.MyToolStripButton

        tsbModulo = New APPControls.MyToolStripButton
        tsbModulo.Modulo = New Legolas.LEntity.Seguridad.Modulo

        tsbModulo.Modulo.HasSeccion = True
        tsbModulo.Modulo.Codigo = 0
        tsbModulo.Modulo.CodigoPadre = 0
        tsbModulo.Modulo.Objecto = "frmInicio"
        tsbModulo.Text = "Ir a Inicio"
        tsbModulo.Alignment = ToolStripItemAlignment.Right
        tsbModulo.TextImageRelation = TextImageRelation.ImageAboveText
        AddHandler tsbModulo.Click, AddressOf tsbModulo_ItemClick
        'tsbModulo.Image = SeleccionarIcono(0)

        ReDim Preserve _objBotonesReversa(0)
        tsbModulo.Index = _objBotonesReversa.Length - 1
        _objBotonesReversa(0) = tsbModulo
    End Sub
    Private Sub PermisoEspecial()

        'Dim intCodigo As Integer = -1
        'Dim objBss As New Business.Seguridad.Usuario
        'Dim objEnt As New Entity.Seguridad.Usuario

        'intCodigo = Legolas.Configuration.Usuario.Codigo 

        'objEnt = objBss.Listar(intCodigo, "", -1).Item(0)
        'With objEnt
        '    Configuracion.Usuario.AdmReunion = .AdmReunion
        '    Configuracion.Usuario.admRRHH = .RRHH
        '    Configuracion.Usuario.ADMOGA = .ADM_OGA
        '    Configuracion.Usuario.ADMOGPP = .ADM_OPP
        'End With

    End Sub
    Private Sub tsbModulo_ItemClick(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim objBoton As APPControls.MyToolStripButton = CType(sender, APPControls.MyToolStripButton)

        If Not objBoton Is Nothing Then
            CerrarFormularios()
            AbrirFormulario(objBoton.Modulo.Codigo, objBoton.Modulo.Nombre, objBoton.Modulo.Objecto)

            If objBoton.Modulo.HasSeccion Then

                'If objBoton.Modulo.Codigo > 0 And objBoton.Modulo.CodigoPadre = 0 Then
                '    'ConfigurarBotonInicio()
                'End If

                'If objBoton.Modulo.Objecto <> String.Empty Or objBoton.Modulo.Codigo >= 0 Then

                '    Dim i As Integer
                '    If objBoton.Alignment = ToolStripItemAlignment.Left Then
                '        i = _objBotonesReversa.Length
                '    Else
                '        i = objBoton.Index
                '    End If

                '    ReDim Preserve _objBotonesReversa(i)
                '    objBoton.Index = i
                '    _objBotonesReversa(i) = objBoton
                'End If

                PoblarMenu(objBoton.Modulo.Codigo)
            End If
        End If
        PermisoEspecial()
    End Sub
    Private Sub AgregarBotonAlMenu(ByVal Modulo As Legolas.LEntity.Seguridad.Modulo)
        AgregarBotonAlMenu(Modulo, ToolStripItemAlignment.Left)
    End Sub
    Private Sub AgregarBotonAlMenu(ByVal Modulo As Legolas.LEntity.Seguridad.Modulo, ByVal Alineacion As ToolStripItemAlignment)

        Dim tsbModulo As New APPControls.MyToolStripButton

        tsbModulo.Modulo = Modulo
        'tsbModulo.Text = Modulo.Nombre '.Replace(" ", Chr(13))        
        tsbModulo.Alignment = Alineacion

        If tsbModulo.Modulo.CodigoPadre = 0 Then
            tsbModulo.Text = Modulo.Nombre
            tsbModulo.ImageAlign = ContentAlignment.MiddleLeft
            tsbModulo.TextAlign = ContentAlignment.MiddleCenter
            tsbModulo.TextImageRelation = TextImageRelation.ImageBeforeText
            'tsbModulo.ImageTransparentColor = Color.White
        Else
            tsbModulo.Text = Modulo.NombreBoton
            tsbModulo.ImageAlign = ContentAlignment.TopCenter
            tsbModulo.TextAlign = ContentAlignment.BottomCenter
            tsbModulo.TextImageRelation = TextImageRelation.ImageAboveText

            'If tsbModulo.Modulo.CodigoPadre = 8 Then 'administracion
            tsbModulo.Visible = Modulo.Enabled   'visible
            'Else
            '    tsbModulo.Enabled = Modulo.Enabled 'enabled
            'End If

        End If

        AddHandler tsbModulo.Click, AddressOf tsbModulo_ItemClick

        If Not Modulo.Icono Is Nothing Then
            If Modulo.Icono.Length > 0 Then
                Dim ms As New System.IO.MemoryStream(Modulo.Icono)
                tsbModulo.Image = Image.FromStream(ms)
            Else
                tsbModulo.Image = My.Resources.windows
            End If
        Else
            tsbModulo.Image = My.Resources.windows
        End If

        If tsbModulo.Modulo.CodigoPadre = 0 Then
            Me.ToolStrip1.Items.Add(tsbModulo)

            Dim tsbSeparador As New ToolStripSeparator
            tsbSeparador.Alignment = Alineacion
            ToolStrip1.Items.Add(tsbSeparador)
        Else
            Me.ToolStrip2.Items.Add(tsbModulo)
        End If

    End Sub
    Private Sub PoblarMenu(ByVal CodigoPadre As Integer)

        Dim objBss As New Legolas.LBusiness.Seguridad.Modulo

        Dim entModulos As Legolas.LEntity.Seguridad.ModuloCol = objBss.Listar( _
        Legolas.Configuration.Usuario.Codigo, -1, CodigoPadre, "")

        If Not entModulos Is Nothing Then
            'Me.ToolStrip1.Items.Clear()
            Me.ToolStrip2.Items.Clear()

            For Each entModulo As Legolas.LEntity.Seguridad.Modulo In entModulos
                AgregarBotonAlMenu(entModulo)
            Next

            If Not _objBotonesReversa Is Nothing And CodigoPadre > 0 Then
                If _objBotonesReversa.Length > 0 Then
                    Dim i As Integer = 0
                    For Each objCtrl As APPControls.MyToolStripButton In _objBotonesReversa
                        If TypeOf objCtrl Is APPControls.MyToolStripButton Then
                            Dim objBoton As APPControls.MyToolStripButton = CType(objCtrl, APPControls.MyToolStripButton)

                            objBoton.Alignment = ToolStripItemAlignment.Right
                            Me.ToolStrip1.Items.Add(objBoton)

                            Dim tsbSeparador As New ToolStripSeparator
                            tsbSeparador.Alignment = ToolStripItemAlignment.Right
                            Me.ToolStrip1.Items.Add(tsbSeparador)

                            If i < _objBotonesReversa.Length - 1 Then
                                objBoton.Visible = True
                                tsbSeparador.Visible = True
                            Else
                                objBoton.Visible = False
                                tsbSeparador.Visible = False
                            End If

                            i += 1
                        End If
                    Next
                End If
            End If
        Else
            Dim _boolen As Boolean = True
            For Each tsp As Object In Me.ToolStrip1.Items
                If TypeOf tsp Is APPControls.MyToolStripButton Then
                    If tsp.Text = "Ir a Inicio" Then
                        _boolen = False
                    End If
                End If

            Next
            If _boolen Then
                If Not _objBotonesReversa Is Nothing And CodigoPadre > 0 Then
                    If _objBotonesReversa.Length > 0 Then
                        Dim i As Integer = 0

                        Dim objCtrl As APPControls.MyToolStripButton = _objBotonesReversa(0)
                        If TypeOf objCtrl Is APPControls.MyToolStripButton Then
                            Dim objBoton As APPControls.MyToolStripButton = CType(objCtrl, APPControls.MyToolStripButton)

                            objBoton.Alignment = ToolStripItemAlignment.Right
                            Me.ToolStrip1.Items.Add(objBoton)

                            Dim tsbSeparador As New ToolStripSeparator
                            tsbSeparador.Alignment = ToolStripItemAlignment.Right
                            Me.ToolStrip1.Items.Add(tsbSeparador)

                            If i < _objBotonesReversa.Length - 1 Then
                                objBoton.Visible = True
                                tsbSeparador.Visible = True
                            Else
                                objBoton.Visible = False
                                tsbSeparador.Visible = False
                            End If

                            i += 1
                        End If

                    End If
                End If

            End If
        End If
    End Sub
#End Region
#Region "Otros"
    Private Sub FRMActualizarRegistros()

        'Dim frm As New Transferencia.frmTransferenciaRegistrosPopup
        'With frm
        '    .ShowDialog()
        'End With

    End Sub
    Private Sub FRMActualizarWeb()

        'Dim frm As New Mantenimiento.frmActualizarWeb
        'With frm
        '    .ShowDialog()
        'End With
    End Sub
    Private Sub ACambiarClave()

        'Dim frm As New Seguridad.frmCambiarClave

        'With frm
        '    .ShowDialog()
        'End With

    End Sub
    Private Sub ValoresxDefault()

        Me.lblTituloMenu.Text = Me.lblTituloMenu.Text & " " & Legolas.Configuration.Aplication.VersionString

    End Sub
#End Region
    '#Region "Transferencia"
    '    Private Function ATransferencia() As Boolean

    '        Dim blnValue As Boolean = False

    '        Select Case Me.TransferenciaTipo

    '            'subir archivos
    '            Case enmTranfenrenciaTipo.Subir

    '                Select Case Legolas.Configuration.Usuario.NivelUsuario
    '                    Case 1, 2 'usuario penal y region

    '                        Dim intLicencia As Integer = -1
    '                        intLicencia = Configuracion.Licencia.Codigo

    '                        If intLicencia > 1 Then
    '                            Dim objBss As New Bussines.Sistema.InstalacionDetalle
    '                            Dim objEntCol As New Entity.Sistema.InstalacionDetalleCol

    '                            objEntCol = objBss.Listar(-1, intLicencia, -1, -1, _
    '                            False, False)

    '                            Dim objSubir As New APPTransferencia.TransferenciaExportarArchivo()

    '                            For Each objEnt As Entity.Sistema.InstalacionDetalle In objEntCol

    '                                'ACTUALIZAMOS()
    '                                With objEnt
    '                                    If .Escritura = True Then
    '                                        'objSubir._pLicenciaID = Configuracion.Licencia.Codigo
    '                                        objSubir._RegionId = .RegionID
    '                                        objSubir._PenalId = .PenalID
    '                                        objSubir._UltimaFecha = 0
    '                                        objSubir.GenerarArchivo()

    '                                    End If
    '                                End With
    '                            Next
    '                        End If

    '                End Select


    '            Case enmTranfenrenciaTipo.Bajar
    '                'bajar archivos

    '                If Legolas.Configuration.Usuario.NivelUsuario = 2 Then 'usuario region 

    '                    Dim intLicencia As Integer = -1
    '                    intLicencia = Configuracion.Licencia.Codigo

    '                    If intLicencia > 1 Then
    '                        Dim objTrans As New APPTransferencia.TransferenciaImportarArchivo

    '                        objTrans._SubirArchivoWEB(intLicencia, Application.StartupPath)
    '                    End If

    '                End If

    '        End Select

    '        blnValue = True
    '        Return blnValue

    '    End Function

    '    Private Sub ATransferencia(ByVal Tipo As Integer)

    '        Me.TransferenciaTipo = Tipo
    '        Dim blnHizoPing As Boolean = False

    '        If Legolas.Components.PC.IsOnline = False Then
    '            For i As Integer = 0 To 3
    '                If Legolas.Components.PC.IsOnline = True Then
    '                    blnHizoPing = True
    '                    Exit For
    '                End If
    '            Next
    '        Else
    '            blnHizoPing = True
    '        End If

    '        If blnHizoPing = False Then
    '            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
    '           "No se ha podido transferir la información, porque se ha dectectado una baja o nula conexión a internet con la Sede Central")
    '            Exit Sub
    '        End If

    '        Me.SuspendLayout()
    '        Me.Timer1.Start()
    '        frmLoad = New Load.frmLoad
    '        frmLoad.ShowDialog()
    '        Me.ResumeLayout(True)
    '        frmLoad.Refresh()

    '    End Sub
    '#End Region

    Private Sub frmMenu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyData
            Case (Keys.Shift Or Keys.F12)
                FRMActualizarWeb()
        End Select

    End Sub
    Private Sub frmMenu_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

        Me.Refresh()
        PoblarMenu(0)
        ListarData()
        Me.Refresh()

        FRMActualizarRegistros()

        Select Case Configuracion.Licencia.Codigo
            Case 1 'sd

            Case Else

                'Me.Enabled = False
                'Me.Cursor = Cursors.WaitCursor
                'ATransferencia(2) 'descarga archivos de la sede central
                ''Threading.Thread.Sleep(500)
                'ATransferencia(1) 'subir a la sede central

                'Me.Enabled = True
                'Me.Cursor = Cursors.Default

                'If Legolas.Components.PC.IsOnline = True Then
                '    Dim strPath As String = ""
                '    strPath = Legolas.Configuration.Path.Directorio
                '    Legolas.Components.Archivo.EjecutarApp(strPath & "APPTransferirMultimedia.exe")
                'Else
                '    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                '   "No se ha podido transferir la información, porque se ha dectectado una baja o nula conexión a internet con la Sede Central")
                '    Exit Sub
                'End If

        End Select

    End Sub

    Private Sub frmMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ValoresxDefault()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If Me.BackgroundWorker1.IsBusy Then Exit Sub
        ' inicializa la validacion del ping
        Me.BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        'e.Result = ProcesarFoto()
        'e.Result = ATransferencia()

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted


        'frmLoad.Dispose()
        Dim result As Boolean = False
        If e.Cancelled = False AndAlso e.Error Is Nothing Then
            Me.Timer1.Stop()
            frmLoad.Close()
            result = e.Result
            ' procesa el resultado del metodo ping        
        End If

        ''frmLoad.Dispose()
        'Dim result As Boolean = False
        'If e.Cancelled = False AndAlso e.Error Is Nothing Then
        '    Me.Timer1.Stop()
        '    'frmLoad.Close()
        '    result = e.Result
        '    ' procesa el resultado del metodo ping        
        'End If

    End Sub

    Private Sub pbClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClave.Click
        ACambiarClave()
    End Sub
End Class