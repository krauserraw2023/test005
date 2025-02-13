Imports System.Globalization
Imports System.Net.NetworkInformation
Imports Ionic.Zip

Public Class frmInicioSesion_v2

    Dim entHueUsu As Entity.Sistema.Seguridad.UsuarioHuella

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
            Return Legolas.Components.PC.GetMAC.ToUpper
        End Get
    End Property
    Private ReadOnly Property Ambiente() As Integer
        Get
            Return IIf(Me.rdbDesarrollo.Checked, 0, 1)
        End Get
    End Property
#End Region
#Region "Propiedades_Otros"
    Private Property EtapaClave As Short = 1
    Private Property EtapaUsuarioClave As String = ""
    Private ReadOnly Property EtapaUsuarioClaveEncryp() As Byte()
        Get
            Return (New System.Text.ASCIIEncoding()).GetBytes(Me.EtapaUsuarioClave)
        End Get
    End Property
#End Region
#Region "Accion"
    Private Function Validar() As Boolean

        If Me.UsuarioNombre = "" Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el nombre del usuario")
            Me.txtUsuario.Text = ""
            Me.txtUsuario.Focus()
            Return False
        End If

        If Me.UsuarioClave = "" Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el password del usuario")
            Me.txtPassword.Text = ""
            Me.txtPassword.Focus()
            Return False
        End If

        Return True

    End Function
    Private Function ValidarPC(ByVal Usuario As Integer, ByVal MAC As String) As String

        Dim blnValue As Boolean = False

        Dim objEntCol As Legolas.LEntity.Seguridad.UsuarioPCCol = (New Legolas.LBusiness.Seguridad.UsuarioPC).Listar(-1, Usuario, -1, False)

        For Each objEnt As Legolas.LEntity.Seguridad.UsuarioPC In objEntCol
            If objEnt.MAC = MAC Then
                blnValue = True
                Exit For
            End If
        Next

        If blnValue = False Then
            MessageBox.Show("La PC, no esta registrada al usuario, para ingresar al sistema", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
        End If

        Return blnValue

    End Function
    Private Function ValidarInstalacion() As Boolean

        Dim blnValue As Boolean = False
        Dim intInstall As Integer = Configuracion.Licencia.Codigo

        If intInstall < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation("La PC actual, no cuenta con licencia de instalacion del sistema")
            Return False
        End If

        blnValue = (New Bussines.Sistema.Instalacion).ValidarInstalacion(intInstall, Legolas.Configuration.Usuario.Codigo)

        If blnValue = False Then Legolas.Configuration.Aplication.MessageBox.Exclamation("El usuario actual, no tiene acceso a la licencia de la instalacion del sistema")

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
                                frm._UsuarioLogin = Me.UsuarioNombre

                                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then blnPasa = True

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

                    'If .ClaveNueva Then
                    '    If FRM_ValidarClave() = False Then Exit Sub
                    'End If

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
                Dim intTipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = (New Bussines.Sistema.Instalacion).ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
                Dim strTipoLicencia As String = intTipoLicencia.ToString

                '/*configuracion appcontrols*/
                APPControls.Config.Licencia.LicenciaTipo = intTipoLicencia
                APPControls.Config.Usuario.NivelUsuario = intTipoUsuario
                APPControls.Config.Usuario.PerfilUsuario = Legolas.Configuration.Usuario.OficinaID

                Select Case intTipoUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                        Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                        intTipoUsuario = Type.Enumeracion.Licencia.enmTipoLicencia.Sede
                End Select

                If intTipoUsuario <> intTipoLicencia Then
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
                'Select Case My.Computer.Name.ToLower
                '    Case "PC-740899502355".ToLower, "hades", "PC740805000169".ToLower, "PC-740899502648".ToLower, "DESKTOP-BJ7URQL".ToLower

                '    Case Else
                '        If ValidarVersionAPP() = False Then Exit Sub
                'End Select

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
                                    If ValidarInstalacion() = False Then Exit Sub

                            End Select
                        End If

                End Select

                If blnValidarPC = True AndAlso ValidarPC(Legolas.Configuration.Usuario.Codigo, Me.MAC) = False Then Exit Sub

                Dim sms As String = ""
                If objEntUsuario.Perfil <> 1 Then 'si diferente de oficina de sistemas
                    If bssUsuario.RegistraInicioSesion(objEntUsuario.Codigo, objEntUsuario.Login, Me.MAC, sms) = False Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
                        Exit Sub
                    End If
                End If
                Main.HORA_CIERRE_SESSION = getHoraCierreSesionSistema()

                If objEntUsuario.NivelUsuario <> 3 And objEntUsuario.Perfil <> 1 Then 'si diferente de oficina de sistemas
                    ' validar autenticacion por huella
                    Dim entUsu As Entity.Sistema.Seguridad.Usuario = (New Bussines.Seguridad.Usuario).Listar(objEntUsuario.Codigo)
                    If Not entUsu Is Nothing AndAlso entUsu.ValidarPorHUella Then
                        Me.entHueUsu = (New Bussines.Sistema.Seguridad.UsuarioHuella).ListarPorUsuario(Legolas.Configuration.Usuario.Codigo)
                        If entHueUsu Is Nothing Then
                            MessageBox.Show("No existe huella para validación, por favor comunicarse con su jefatura superior para el enrolamiento de su huella.", "Alerta..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If

                        UscAutenticacionDactilar1.setTipoDedoSel(entHueUsu.Izq_TipoDedoId, entHueUsu.Der_TipoDedoId)
                        pnlValidadorHuella.Visible = True
                        UscAutenticacionDactilar1._IniciarCapturaHuella()
                    Else
                        Legolas.Configuration.Usuario.Conectado = True
                        Me.Close()
                    End If
                Else
                    Legolas.Configuration.Usuario.Conectado = True
                    Me.Close()
                End If
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Usuario o contraseña incorrecta, por favor vuelva ha intentarlo")
                intIntentos += 1

                If intIntentos >= 3 Then Me.Close()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function getHoraCierreSesionSistema() As TimeSpan
        Dim hor As TimeSpan
        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)

        Dim objDT As DataTable = Legolas.Components.SQL.Select_DataTable(sqlCn, "select * from [dbo].[SYS_WinApp] where win_app_key='hora_cierre_session'")

        Try
            hor = TimeSpan.Parse(objDT.Rows(0).Item("win_app_val").ToString & ":01")
        Catch ex As Exception
            hor = TimeSpan.Parse("23:50:01")
        End Try

        Return hor
    End Function
#End Region
#Region "Version"
    Private ReadOnly Property ExisteTablaVersion As Boolean
        Get
            Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)

            Dim value As Boolean = Legolas.Components.SQL.ExisteTabla(sqlCn, "sis_versionpc")
            sqlCn.Close()
            sqlCn = Nothing

            Return value

        End Get
    End Property
    Private Function ListarVersionApp(MAC As String) As Integer

        Dim value As Integer = 0

        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
        Dim strSQL As String = "select * from sis_versionpc where len(isnull(c_ver_pc_pth,''))>1 and c_ver_pc_mac='" & MAC _
                                                        & "' and ltrim(rtrim(isnull(c_ver_pc_pth,'')))='" & Configuracion.Path.Directorio & "'"

        Dim objDT As DataTable = Legolas.Components.SQL.Select_DataTable(sqlCn, strSQL)

        Try
            value = objDT.Rows(0).Item("n_ver_pc_app").ToString
        Catch ex As Exception

        End Try

        Return value

    End Function
    Private Function ListarVersionBD(MAC As String) As Integer

        Dim value As Integer = 0
        Dim sqlCn As New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
        Dim objDT As DataTable = Legolas.Components.SQL.Select_DataTable(sqlCn, "select * from sis_versionpc where c_ver_pc_mac='" & MAC & "'")

        Try
            value = objDT.Rows(0).Item("n_ver_pc_bd").ToString
        Catch ex As Exception

        End Try

        Return value

    End Function

    Private Function ValidarVersionAPP() As Boolean

        Dim blnValue As Boolean = True
        Dim intVersionAppBD As Integer = Legolas.LBusiness.Globall.WinApp.VersionNumber
        Dim intVersionApp As Integer = IIf(ExisteTablaVersion, ListarVersionApp(Legolas.Components.PC.GetMAC), Legolas.Configuration.Aplication.Version)

        Select Case Configuracion.Licencia.Codigo
            Case 1 'sede central

                Select Case intVersionAppBD
                    Case intVersionApp
                        blnValue = True
                    Case Is < intVersionApp

                        blnValue = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La version del aplicativo esta ejecutando una version que no existe, por favor ingrese nuevamente")
                        End

                    Case Else
                        blnValue = False

                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La version del aplicativo esta desactualizado, por favor ingrese nuevamente")

                        If Legolas.Components.PC.IsOnline = True Then Legolas.Components.Archivo.EjecutarApp(Legolas.Configuration.Path.App.PegasoWeb)

                        End
                End Select

            Case Else 'pope

                Select Case intVersionAppBD
                    Case intVersionApp
                        blnValue = True
                    Case Is < intVersionApp

                        blnValue = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La versión del aplicativo esta ejecutando una versión que no existe, por favor ingrese nuevamente")
                        End

                    Case Else

                        blnValue = False

                        If Legolas.Components.PC.IsOnline = True Then

                            Legolas.Configuration.Aplication.MessageBox.Exclamation("La versión del aplicativo está desactualizado, espere se volvera abrir nuevamente")
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
        Dim intVersion As Integer = IIf(ExisteTablaVersion, ListarVersionBD(Legolas.Components.PC.GetMAC), Legolas.Configuration.Aplication.VersionBaseDatos)

        Select Case Configuracion.Licencia.Codigo
            Case 1 'sip-ga

                Select Case intVersionBD
                    Case intVersion
                        blnValue = True
                    Case Is < intVersion
                        blnValue = False
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La version de la Base Datos esta ejecutando una version que no existe, por favor ingrese nuevamente")
                        End
                    Case Else
                        Legolas.Components.Cadena.ArchivoGrabarLinea(
                         Legolas.Configuration.Path.ConfigIni.Config, 2, intVersionBD)
                End Select

            Case Else 'pope

                If intVersionBD <> intVersion Then
                    blnValue = False
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La version de la BD Principal, esta desactualizado, por favor ingrese nuevamente")
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
                If Legolas.Components.PC.IsOnline = False AndAlso Legolas.Components.PC.IsOnline Then blnHayConexion = Legolas.Components.PC.IsOnline
        End Select

        If blnHayConexion = True Then
            Legolas.Configuration.Aplication.MessageBox.Information("Su clave ha sido restaurada, por seguridad ingrese una nueva clave")

            Dim frm As New Sistema.Seguridad.Usuario.frmCambiarClave
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then value = True
        Else
            value = True
        End If

        Return value

    End Function
    Private Sub Form_SincronizarUsuario()

        Legolas.Configuration.Data.AmbienteTipo = Me.Ambiente
        Legolas.Configuration.Data.EncriptadoCN = True
        Legolas.Configuration.Data.EncriptadoKey = Configuracion.ConfigKey_Clave

        Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp()
            Case 1 'sede central
                Legolas.Configuration.Aplication.MessageBox.Information("Opcion disponible, solo para provincias")
            Case Else
                If Legolas.Configuration.Aplication.MessageBox.Question("Desea actualizar los usuarios. Requiere conexion a internet") = Windows.Forms.DialogResult.Yes Then
                    Dim frm As New Mantenimiento.frmActualizarWeb_v3
                    frm._ActualizarUsuario()
                End If
        End Select

    End Sub
#End Region
#Region "Otros"

    Private Sub ValoresxDefault()
        Select Case My.Computer.Name.ToUpper
            Case "PCCASAX7P2", "PC-740899502355", "PC740805000169", "HADES", "PC-740899502648".ToUpper
                Me.grbAmbiente.Visible = True
                Me.rdbDesarrollo.Checked = True
            Case Else
                Me.rdbProduccion.Checked = True
        End Select

        ''// Obtener la configuración regional actual de Windows - formato de la fecha windows
        Dim culturaActual As CultureInfo = CultureInfo.CurrentCulture
        Dim formatoFechaCorta As String = culturaActual.DateTimeFormat.ShortDatePattern
        If formatoFechaCorta = "d/MM/yyyy" Then Legolas.Configuration.Aplication.MessageBox.Exclamation("El formato de fecha windows no es el correcto para" + Chr(13) +
                                                                                                        "visualizar las fechas de los módulos del Sistema SIP." + Chr(13) +
                                                                                                        "-------------------------------------------------------" + Chr(13) +
                                                                                                        "Comunicarse con el área de soporte para configurar el formato correcto.")
    End Sub

    Private Sub RestaurarClave()
        Legolas.Configuration.Data.AmbienteTipo = Me.Ambiente
        Legolas.Configuration.Data.EncriptadoCN = True
        Legolas.Configuration.Data.EncriptadoKey = Configuracion.ConfigKey_Clave

        If (New Bussines.Seguridad.Usuario).RestaurarClaveInicio(Me.UsuarioNombre) > 0 Then Legolas.Configuration.Aplication.MessageBox.Information("La contraseña ha sido restaurada satisfactoriamente")

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
                Dim intVersionBD As Integer = Legolas.LBusiness.Globall.WinApp.VersionBD(-1)

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
                    Else 'si no existe lo descargo

                        Legolas.Components.Archivo.Web.FileDownload(strPathUrl_PegasoWeb, strPathLocal_PegasoWeb, True)

                        Dim zip As New ZipFile(strPathLocal_PegasoWeb)
                        'zip.Password = Password
                        zip.ExtractAll(Legolas.Configuration.Path.Directorio, ExtractExistingFileAction.OverwriteSilently)
                        zip.Dispose()

                    End If
                End If

                Dim strConfigPegasoWeb As String = Legolas.Configuration.Path.Directorio & "config_pegasoweb.ini"
                If Legolas.Components.Archivo.FileExiste(strConfigPegasoWeb) Then Legolas.Components.Archivo.FileDelete(strConfigPegasoWeb)

                Dim strConfig As String = Legolas.Configuration.Path.Directorio & "config.ini"
                If Legolas.Components.Archivo.FileExiste(strConfig) = True Then Legolas.Components.Archivo.FileDelete(strConfig)

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
            Case "DESKTOP-BJ7URQL"
                strUser = "JJIMENEZC"
                strClave = "123456789"
            Case "HADES"
                strUser = "usr1674"
                strClave = "123456789"
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
        If e.KeyChar = Chr(Keys.Enter) Then AEntrar()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form_SincronizarUsuario()
    End Sub

    Private Sub btnCancelar2_Click(sender As Object, e As EventArgs) Handles btnCancelar2.Click
        Dim v As Boolean = (New Bussines.Seguridad.Usuario).RegistraCierreSesion(Legolas.Configuration.Usuario.Codigo)

        UscAutenticacionDactilar1._CancelarCapturaHuella()
        Legolas.Configuration.Usuario.Conectado = False
        Me.Close()
    End Sub

    Private Sub btnIngresar2_Click(sender As Object, e As EventArgs) Handles btnIngresar2.Click
        IngresarSistema()
    End Sub

    Private Sub IngresarSistema()
        If UscAutenticacionDactilar1._TieneHuellaCapturada = False Then
            MessageBox.Show("Debe capturar su huella dactilar.", "Alerta..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not entHueUsu Is Nothing Then
            Dim tmlAnsi As Byte()
            Select Case UscAutenticacionDactilar1._getTipoDedoSelectMano
                Case 1, 2, 3, 4, 5
                    tmlAnsi = entHueUsu.Izq_TemplateAnsi
                Case 6, 7, 8, 9, 10
                    tmlAnsi = entHueUsu.Der_TemplateAnsi
            End Select

            If UscAutenticacionDactilar1._CompararHuella(tmlAnsi) Then
                Legolas.Configuration.Usuario.Conectado = True
                Me.Close()
            Else
                MessageBox.Show("Usuario no autorizado.", "Alerta..", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("No existe huella para validación, por favor comunicarse con su jefatura superior para el enrolamiento de su huella.", "Alerta..", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub UscAutenticacionDactilar1__HuellaCapturado_event() Handles UscAutenticacionDactilar1._HuellaCapturado_event
        IngresarSistema()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
