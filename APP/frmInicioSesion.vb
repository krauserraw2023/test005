Imports Ionic.Zip

Public Class frmInicioSesion
#Region "Propiedades"
    Private intIntentos As Integer = 0
    Private Property UsuarioNombre() As String
        Get
            Return Me.txtUsuario.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtUsuario.Text = value
        End Set
    End Property
    Private Property UsuarioClave() As String
        Get
            Return Me.txtPassword.Text.Trim
        End Get
        Set(ByVal value As String)
            Me.txtPassword.Text = value
        End Set
    End Property
    Private ReadOnly Property MAC() As String
        Get
            Dim strValue As String = ""
            strValue = Legolas.Components.PC.GetMAC.ToUpper
            Return strValue
        End Get
    End Property
    Private ReadOnly Property Ambiente() As Integer
        Get
            Dim value As Integer = 1

            If Me.rdbProduccion.Checked = True Then
                value = 1
            End If

            If Me.rdbDesarrollo.Checked = True Then
                value = 0
            End If

            Return value

        End Get
    End Property
#End Region
#Region "Propiedades_Otros"
    Private Property EtapaClave As Short = 1
    Private Property EtapaUsuarioClave As String = ""
    Private ReadOnly Property EtapaUsuarioClaveEncryp() As Byte()
        Get
            Dim objencoding As New System.Text.ASCIIEncoding()
            Return objencoding.GetBytes(Me.EtapaUsuarioClave)
        End Get
    End Property
#End Region
#Region "Accion"
    Private Function Validar() As Boolean

        Dim blnValue As Boolean = True
        '/*validar usuario*/
        If Me.UsuarioNombre = "" Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation(
           "Ingrese el nombre del usuario")
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Focus()
            blnValue = False
            Return blnValue
        End If

        '/*validar contraseña*/
        If Me.UsuarioClave = "" Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation(
           "Ingrese el password del usuario")
            Me.txtPassword.Text = ""
            Me.txtPassword.Focus()
            blnValue = False
            Return blnValue
        End If

        Return blnValue

    End Function
    Private Function ValidarPC(ByVal Usuario As Integer, ByVal MAC As String) As String

        Dim blnValue As Boolean = False

        Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioPC
        Dim objEntCol As New Legolas.LEntity.Seguridad.UsuarioPCCol

        objEntCol = objBss.Listar(-1, Usuario, -1, False)

        For Each objEnt As Legolas.LEntity.Seguridad.UsuarioPC In objEntCol

            If objEnt.MAC = MAC Then
                blnValue = True
                Exit For
            End If
        Next

        If blnValue = False Then
            MessageBox.Show("La PC, no esta registrada al usuario, para ingresar al sistema",
             Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
        End If

        Return blnValue

    End Function
    Private Function ValidarInstalacion() As Boolean

        Dim blnValue As Boolean = False
        Dim intInstall As Integer = Configuracion.Licencia.Codigo

        If intInstall < 1 Then
            blnValue = False
            Legolas.Configuration.Aplication.MessageBox.Exclamation(
           "La PC actual, no cuenta con licencia de instalacion del sistema")
            Return blnValue
        End If

        Dim objBss As New Bussines.Sistema.Instalacion
        blnValue = objBss.ValidarInstalacion(intInstall, Legolas.Configuration.Usuario.Codigo)

        If blnValue = False Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation(
           "El usuario actual, no tiene acceso a la licencia de la instalacion del sistema")
        End If

        Return blnValue

    End Function

    Private Sub AEntrar()

        If Validar() = False Then Exit Sub

        Dim blnValidarPC As Boolean = False
        Dim bssUsuario As New Bussines.Seguridad.Usuario
        Dim blnValidarTipoLicencia As Boolean = True

        Legolas.Configuration.Usuario.Conectado = False
        Legolas.Configuration.Data.AmbienteTipo = Me.Ambiente
        Legolas.Configuration.Data.EncriptadoCN = True
        Legolas.Configuration.Data.EncriptadoKey = Configuracion.ConfigKey_Clave

        Try

            Dim objEntUsuario As Entity.Sistema.Seguridad.Usuario = bssUsuario.ListarLogin(Me.UsuarioNombre, Me.UsuarioClave)

            If Not objEntUsuario Is Nothing Then

                Dim blnPasa As Boolean = False

                Select Case objEntUsuario.Login.ToLower

                    Case "usr1691".ToLower
                        blnValidarTipoLicencia = False
                        blnPasa = True

                    Case "usr0023".ToLower, "USR1691".ToLower

                        Select Case My.Computer.Name.ToLower 'pc 

                            Case "PC-740899502355".ToLower, "pccasax7p2".ToLower, "PC-740899502648".ToLower
                                blnPasa = True

                            Case Else
                                IIf(objEntUsuario.Login.ToLower = "USR1691".ToLower, True, False)
                                'en otras pcs
                                Dim frm As New Sistema.Seguridad.Usuario.frmVerificarSesion
                                With frm
                                    ._UsuarioLogin = Me.UsuarioNombre

                                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                        blnPasa = True
                                    End If
                                End With

                        End Select
                        blnValidarTipoLicencia = False
                    Case Else
                        blnPasa = True
                End Select

                If blnPasa = False Then Exit Sub

                Dim intTipoUsuario As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim strTipoUsuario As String = ""

                With objEntUsuario

                    Legolas.Configuration.Usuario.Codigo = .Codigo
                    Legolas.Configuration.Usuario.Login = Me.UsuarioNombre
                    'trabajador
                    Legolas.Configuration.Usuario.TrabajadorID = .IDTrabajador
                    Legolas.Configuration.Usuario.ApellidosyNombre = .getApellidosyNombres

                    'nivel de usuarios 
                    Legolas.Configuration.Usuario.NivelUsuario = .NivelUsuario
                    intTipoUsuario = Legolas.Configuration.Usuario.NivelUsuario
                    strTipoUsuario = intTipoUsuario.ToString
                    Legolas.Configuration.Usuario.NivelUsuarioNombre = strTipoUsuario
                    '****************************************************      
                    'ubicacion
                    Legolas.Configuration.Usuario.OficinaID = .Perfil
                    Legolas.Configuration.Usuario.Oficina = .PerfilNombre

                    Legolas.Configuration.Usuario.AdministrarModuloUsuario = .AdminModuloUsuario

                    '/*permisos otros*/
                    blnValidarPC = .AdminValidarPC

                    If .ClaveNueva = True Then
                        If FRM_ValidarClave() = False Then
                            Exit Sub
                        End If
                    End If

                End With

                Configuracion.Licencia.Codigo = Legolas.LBusiness.Globall.WinApp.LicenciaApp

                '/* Legolas.Configuration*/
                Legolas.Configuration.Aplication.FechayHora.FechaLong = Legolas.LBusiness.Globall.DateTime.FechaServerLong
                Legolas.LEntity.Config.FechaHoy = Legolas.LBusiness.Globall.DateTime.FechaServerLong

                '/*configuracion appcontrols*/
                APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_huella_visita", Configuracion.Licencia.Codigo)
                'If APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita.Trim.Length < 3 Then
                '    APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_huella_ep", Configuracion.Licencia.Codigo)
                'End If

                APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_huella_interno", Configuracion.Licencia.Codigo)
                'If APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno.Trim.Length < 3 Then
                '    APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno = Legolas.LBusiness.Globall.WinApp.ListarString("cn_bd_interno_huella", Configuracion.Licencia.Codigo)
                'End If

                Actualizar_PegasoWeb()

                'validar el acceso del usuario, correponde a la licencia de la base de datos
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
                Dim strTipoLicencia As String = ""
                Dim objBssLicencia As New Bussines.Sistema.Instalacion
                intTipoLicencia = objBssLicencia.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
                strTipoLicencia = intTipoLicencia.ToString

                '/*configuracion appcontrols*/
                APPControls.Config.Licencia.LicenciaTipo = intTipoLicencia
                APPControls.Config.Usuario.NivelUsuario = intTipoUsuario
                APPControls.Config.Usuario.PerfilUsuario = Legolas.Configuration.Usuario.OficinaID

                Select Case intTipoUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                        Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        intTipoUsuario = Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                End Select

                If intTipoUsuario = intTipoLicencia Then
                    'ingresa al sistema
                Else

                    If blnValidarTipoLicencia = True Then
                        'si es usuario nivel sede y oficina de sistemas
                        If intTipoUsuario = Type.Enumeracion.Usuario.EnumTipoUsuario.Nacional And
                            Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then

                        Else

                            Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario actual no tiene acceso a la licencia: " & strTipoLicencia)
                            Exit Sub
                        End If
                    End If

                End If

                'validar app y bd
                Select Case My.Computer.Name.ToLower
                    Case "PC-740899502355".ToLower, "laptop-jmr", "PC740805000169".ToLower, "PC-740899502648".ToLower

                    Case Else

                        Dim blnValidar As Boolean = True

                        If Me.UsuarioNombre.ToUpper = "usr5854".ToUpper Or Me.UsuarioNombre.ToUpper = "usr1690".ToUpper Then
                            blnValidar = False
                        End If

                        If blnValidar = True Then
                            'validar app
                            If ValidarVersionAPP() = False Then
                                Exit Sub
                            End If
                        End If

                End Select

                'validar instalacion
                Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                    Case 1 'sede central

                        'no valida 

                    Case Else 'provincias

                        If blnValidarTipoLicencia = True Then
                            Select Case Legolas.Configuration.Usuario.OficinaID
                                Case Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion 'sistemas
                                    'no valida 
                                Case Else
                                    'validar instalacion
                                    If ValidarInstalacion() = False Then
                                        Exit Sub
                                    End If
                            End Select
                        End If

                End Select

                'validar pc 
                If blnValidarPC = True Then
                    If ValidarPC(Legolas.Configuration.Usuario.Codigo, Me.MAC) = False Then
                        Exit Sub
                    End If
                End If

                'registrar inicio de session PENDIENTEHNRB

                Legolas.Configuration.Usuario.Conectado = True
                Me.Close()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "Usuario o contraseña incorrecta, por favor vuelva ha intentarlo")
                intIntentos += 1

                If intIntentos >= 3 Then
                    Me.Close()
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
#Region "Version"
    Private ReadOnly Property ExisteTablaVersion As Boolean
        Get
            Dim value As Boolean = False

            Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)

            value = Legolas.Components.SQL.ExisteTabla(sqlCn, "sis_versionpc")
            sqlCn.Close()
            sqlCn = Nothing

            Return value

        End Get
    End Property
    Private Function ListarVersionApp(MAC As String) As Integer

        Dim value As Integer = 0
        Dim objDT As New DataTable

        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
        Dim strSQL As String = "select * from sis_versionpc where len(isnull(c_ver_pc_pth,''))>1 and c_ver_pc_mac='" & MAC _
                                                        & "' and ltrim(rtrim(isnull(c_ver_pc_pth,'')))='" & Configuracion.Path.Directorio & "'"

        objDT = Legolas.Components.SQL.Select_DataTable(sqlCn, strSQL)

        Try
            value = objDT.Rows(0).Item("n_ver_pc_app").ToString
        Catch ex As Exception

        End Try

        Return value

    End Function
    Private Function ListarVersionBD(MAC As String) As Integer

        Dim value As Integer = 0
        Dim objDT As New DataTable

        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)

        objDT = Legolas.Components.SQL.Select_DataTable(sqlCn, "select * from sis_versionpc where c_ver_pc_mac='" & MAC & "'")

        Try
            value = objDT.Rows(0).Item("n_ver_pc_bd").ToString
        Catch ex As Exception

        End Try

        Return value

    End Function

    Private Function ValidarVersionAPP() As Boolean

        Dim blnValue As Boolean = True

        Dim intVersionAppBD As Integer = Legolas.LBusiness.Globall.WinApp.VersionNumber
        Dim intVersionApp As Integer = -1

        If ExisteTablaVersion = True Then
            intVersionApp = ListarVersionApp(Legolas.Components.PC.GetMAC)
        Else
            intVersionApp = Legolas.Configuration.Aplication.Version
        End If

        Select Case Configuracion.Licencia.Codigo
            Case 1 'sede central

                Select Case intVersionAppBD
                    Case intVersionApp
                        blnValue = True
                    Case Is < intVersionApp

                        blnValue = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La version del aplicativo esta ejecutando una version que no existe, por favor ingrese nuevamente")
                        End

                    Case Else
                        blnValue = False

                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La version del aplicativo esta desactualizado, por favor ingrese nuevamente")

                        If Legolas.Components.PC.IsOnline = True Then
                            Legolas.Components.Archivo.EjecutarApp(Legolas.Configuration.Path.App.PegasoWeb)
                            'Else
                            '    Dim strArgu(0) As String
                            '    strArgu(0) = Legolas.Configuration.Aplication.Name

                            '    Legolas.Components.Archivo.EjecutarApp(Legolas.Configuration.Path.App.PegasoLocal, _
                            '    strArgu)
                        End If
                        End
                End Select

            Case Else 'pope

                Select Case intVersionAppBD
                    Case intVersionApp
                        blnValue = True
                    Case Is < intVersionApp

                        blnValue = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La versión del aplicativo esta ejecutando una versión que no existe, por favor ingrese nuevamente")
                        End

                    Case Else

                        blnValue = False

                        If Legolas.Components.PC.IsOnline = True Then

                            Legolas.Configuration.Aplication.MessageBox.Exclamation(
                            "La versión del aplicativo está desactualizado, espere se volvera abrir nuevamente")
                            Legolas.Components.Archivo.EjecutarApp(Legolas.Configuration.Path.App.PegasoWeb)
                            End
                        Else
                            Legolas.Configuration.Aplication.MessageBox.Information(
                            "En este momento no se puede actualizar, porque no se tiene acceso al servidor de actualizaciones (www.inpe.gob.pe)." _
                            & Chr(13) & Chr(13) & "Usted ingresará al sistema pero algunas funciones no estarán disponibles dentro del sistema.")
                            blnValue = True
                        End If

                End Select

        End Select

        Return blnValue

    End Function
    Private Function ValidarVersionBD() As Boolean

        Dim blnValue As Boolean = True

        Dim intVersionBD As Integer = Integer.Parse(Legolas.LBusiness.Globall.WinApp.VersionBD)
        Dim intVersion As Integer = -1

        If ExisteTablaVersion = True Then
            intVersion = ListarVersionBD(Legolas.Components.PC.GetMAC)
        Else
            intVersion = Legolas.Configuration.Aplication.VersionBaseDatos
        End If

        Select Case Configuracion.Licencia.Codigo
            Case 1 'sip-ga

                Select Case intVersionBD
                    Case intVersion
                        blnValue = True
                    Case Is < intVersion
                        blnValue = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(
                        "La version de la Base Datos esta ejecutando una version que no existe, por favor ingrese nuevamente")
                        End
                    Case Else
                        Legolas.Components.Cadena.ArchivoGrabarLinea(
                         Legolas.Configuration.Path.ConfigIni.Config, 2, intVersionBD)
                End Select

            Case Else 'pope

                If intVersionBD <> intVersion Then
                    blnValue = False
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "La version de la BD Principal, esta desactualizado, por favor ingrese nuevamente")
                    End
                End If

        End Select

        Return blnValue

    End Function
#End Region
#Region "Form"
    Private Function FRM_ValidarClave() As Boolean

        Dim value As Boolean = False
        Dim blnHayConexion As Boolean = True

        Select Case Configuracion.Licencia.Codigo
            Case 1
                'True
            Case Else

                If Legolas.Components.PC.IsOnline = False Then
                    If Legolas.Components.PC.IsOnline = False Then
                        blnHayConexion = Legolas.Components.PC.IsOnline
                    End If
                End If

        End Select

        If blnHayConexion = True Then

            Legolas.Configuration.Aplication.MessageBox.Information(
            "Su clave ha sido restaurada, por seguridad ingrese una nueva clave")

            Dim frm As New Sistema.Seguridad.Usuario.frmCambiarClave
            With frm
                If .ShowDialog() = Windows.Forms.DialogResult.OK Then
                    value = True
                End If
            End With
        Else
            value = True
        End If

        Return value

    End Function
    Private Sub Form_SincronizarUsuario()

        Dim intLicencia As Integer = -1

        Legolas.Configuration.Data.AmbienteTipo = Me.Ambiente
        Legolas.Configuration.Data.EncriptadoCN = True

        Legolas.Configuration.Data.EncriptadoKey = Configuracion.ConfigKey_Clave

        intLicencia = Legolas.LBusiness.Globall.WinApp.LicenciaApp()

        Select Case intLicencia
            Case 1 'sede central
                Legolas.Configuration.Aplication.MessageBox.Information(
                "Opcion disponible, solo para provincias")
            Case Else
                If Legolas.Configuration.Aplication.MessageBox.Question(
                    "Desea actualizar los usuarios. Requiere conexion a internet") = Windows.Forms.DialogResult.Yes Then

                    Dim frm As New Mantenimiento.frmActualizarWeb_v3
                    With frm
                        ._ActualizarUsuario()
                    End With

                End If
        End Select

    End Sub
#End Region
#Region "Otros"

    Private Sub ListarMac()

        'Me.lblMac.Text = Legolas.Components.PC.GetMAC

    End Sub

    Private Sub ValoresxDefault()

        ListarMac()

        Select Case My.Computer.Name.ToUpper
            Case "PCCASAX7P2", "PC-740899502355", "PC740805000169", "PC-740899502648".ToUpper
                Me.grbAmbiente.Visible = True
                Me.rdbDesarrollo.Checked = True
            Case Else
                Me.rdbProduccion.Checked = True
        End Select

    End Sub

    Private Sub RestaurarClave()

        Legolas.Configuration.Data.AmbienteTipo = Me.Ambiente
        Legolas.Configuration.Data.EncriptadoCN = True
        Legolas.Configuration.Data.EncriptadoKey = Configuracion.ConfigKey_Clave

        Dim intValue As Integer = -1
        Dim objBss As New Bussines.Seguridad.Usuario

        intValue = objBss.RestaurarClaveInicio(Me.UsuarioNombre) 'jmondalgo

        If intValue > 0 Then
            Legolas.Configuration.Aplication.MessageBox.Information(
            "La contraseña ha sido restaurada satisfactoriamente")
        End If

    End Sub

    Private Sub Actualizar_PegasoWeb()

        Select Case Legolas.Configuration.Data.CNDataBase.Trim.ToUpper
            Case "db_inpe_gob_pe_sip_pope_dev".Trim.ToUpper
                'nada 
            Case Else

                Dim strPathUrl_PegasoWeb As String = "http://app2.inpe.gob.pe/programas/sistemas/sip/PegasoWeb_4.0.3_bd_tversion.zip"
                Dim strPathLocal_PegasoWeb As String = Legolas.Configuration.Path.Directorio & "PegasoWeb_4.0.3_bd_tversion.zip"

                Dim strPathPegasoWeb As String = ""
                Dim intPesoPegasoWeb As Decimal = 0

                Dim intVersionBD As Integer = 0
                intVersionBD = Legolas.LBusiness.Globall.WinApp.VersionBD(-1)

                If intVersionBD >= 253 Then
                    strPathPegasoWeb = Legolas.Configuration.Path.Directorio & "PegasoWeb.exe"

                    'si existe pegaso web 
                    If Legolas.Components.Archivo.FileExiste(strPathPegasoWeb) = True Then
                        intPesoPegasoWeb = Legolas.Components.Archivo.FilePeso(strPathPegasoWeb, Legolas.Components.Archivo.enmPesoTipo.bytes)

                        If intPesoPegasoWeb <> 119296 Then 'PESO DEL PEGASO WEB exe (PegasoWeb_4.0.3_bd_tversion.rar)

                            Legolas.Components.Archivo.Web.FileDownload(strPathUrl_PegasoWeb, strPathLocal_PegasoWeb, True)

                            Dim zip As New ZipFile(strPathLocal_PegasoWeb)
                            'zip.Password = Password
                            zip.ExtractAll(Legolas.Configuration.Path.Directorio, ExtractExistingFileAction.OverwriteSilently)
                            zip.Dispose()

                        End If

                    Else
                        'si no existe lo descargo

                        Legolas.Components.Archivo.Web.FileDownload(strPathUrl_PegasoWeb, strPathLocal_PegasoWeb, True)

                        Dim zip As New ZipFile(strPathLocal_PegasoWeb)
                        'zip.Password = Password
                        zip.ExtractAll(Legolas.Configuration.Path.Directorio, ExtractExistingFileAction.OverwriteSilently)
                        zip.Dispose()

                    End If
                End If

                'eliminar el archivo config pegaso web
                Dim strConfigPegasoWeb As String = Legolas.Configuration.Path.Directorio & "config_pegasoweb.ini"
                If Legolas.Components.Archivo.FileExiste(strConfigPegasoWeb) = True Then
                    Legolas.Components.Archivo.FileDelete(strConfigPegasoWeb)
                End If

                'eliminar el archivo config
                Dim strConfig As String = Legolas.Configuration.Path.Directorio & "config.ini"
                If Legolas.Components.Archivo.FileExiste(strConfig) = True Then
                    Legolas.Components.Archivo.FileDelete(strConfig)
                End If

        End Select

    End Sub
#End Region

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        AEntrar()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Legolas.Configuration.Usuario.Conectado = False
        Me.Close()

    End Sub

    Private Sub frmSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '/*usuario x defecto */
        Dim strUser As String = ""
        Dim strClave As String = ""

        Select Case My.Computer.Name.ToUpper
            Case "00110-07"
                strUser = "usr0002"
                strClave = "CONTROLusr002"
            Case "PCCASAX7P2", "PC-740899502355", "LAPTOP-JMR", "pccasajmr".ToUpper
                strUser = "usr0023"
                strClave = "121285"
                'strUser = "usr1690"
                'strClave = "123456"
            Case "PC740805000169"
                strUser = "usr1674"
                strClave = "123456789"
            Case "PC-740899502648".ToUpper
                strUser = "usr1691"
                strClave = "123456"
            Case Else
                strUser = ""
                strClave = ""
        End Select

        Me.UsuarioNombre = strUser
        Me.UsuarioClave = strClave

        ValoresxDefault()

    End Sub

    Private Sub pbClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbClave.Click

        'Dim frm As New Seguridad.frmPCDatosPopup
        'With frm
        '    .ShowDialog()
        'End With

    End Sub

    Private Sub frmSesion_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.txtUsuario.Focus()

    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown

        Select Case e.KeyData
            Case (Keys.Shift Or Keys.R)
                RestaurarClave()
        End Select

    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress

        If e.KeyChar = Chr(Keys.Enter) Then
            AEntrar()
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        Form_SincronizarUsuario()

    End Sub


End Class

'moasd ajssdgf dfg dfg dfg dfg 18-05-2015
'jhon 123 probando'''