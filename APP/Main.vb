Imports System.Drawing.Drawing2D
Imports System.IO

#Region "Configuracion"
Public Class Configuracion
    Public Shared ReadOnly Property ConfigKey_Clave() As String
        Get
            Dim strValue As String = ""
            strValue = Legolas.Components.Cadena.LeerLineaArchivo(
             Legolas.Configuration.Path.ConfigIni.Key, 1) 'clave one
            Return strValue
        End Get
    End Property
    Public Class Path
        Private Shared strPathDirectorio As String = Application.StartupPath & "\"
        Public Shared ReadOnly Property Directorio() As String
            Get
                Return strPathDirectorio
            End Get
        End Property
        Public Shared ReadOnly Property Desktop() As String
            Get
                Dim strValue As String = ""
                strValue = My.Computer.FileSystem.SpecialDirectories.Desktop & "\"
                Return strValue
            End Get
        End Property
    End Class
    Public Class Aplication
        Public Shared ReadOnly Property VersionApp() As String
            Get
                Dim str1 As String = ""
                Dim str2 As String = ""
                Dim str3 As String = ""
                Dim str4 As String = ""
                Dim strVersion As String = ""

                str1 = My.Application.Info.Version.Major
                str2 = My.Application.Info.Version.Minor
                str3 = My.Application.Info.Version.Build
                str4 = My.Application.Info.Version.Revision

                strVersion = str1 & "." & str2 & "." & str3 & "." & str4

                Return strVersion
            End Get
        End Property
        Public Shared ReadOnly Property PCMac() As String
            Get
                Dim strValue As String = ""
                strValue = Legolas.Components.PC.GetMAC
                Return strValue
            End Get
        End Property
        Public Shared Sub RunControls(ByVal objControl As Control, Optional ByVal NombreControl As String = "",
        Optional ByVal vfControl As Boolean = False)

            Dim strNameControl As String = ""

            For Each objControlHijo As Control In objControl.Controls
                strNameControl = objControlHijo.GetType.Name.Trim.ToUpper

                If (TypeOf (objControlHijo) Is Windows.Forms.UserControl) Then
                    strNameControl = "USERCONTROL"
                End If

                Select Case strNameControl
                    Case "TOOLSTRIP", "GROUPBOX", "PANEL", "BUTTON",
                        "ULTRAEXPANDABLEGROUPBOX", "ULTRAEXPANDABLEGROUPBOXPANEL",
                        "TABCONTROL", "TABPAGE", "USERCONTROL"

                        'si el tipo de control es ToolStrip, recorre sus hijos de tipo ToolStripItem
                        If (TypeOf (objControlHijo) Is System.Windows.Forms.ToolStrip) Then
                            Dim objToolStrip As ToolStrip
                            objToolStrip = CType(objControlHijo, ToolStrip)

                            For Each objToolStripItem As ToolStripItem In objToolStrip.Items
                                If objToolStripItem.Name = NombreControl Then
                                    objToolStripItem.Visible = vfControl
                                    Exit For
                                End If
                            Next
                        End If
                        '/*verfica si el control tienes controles hijos**/
                        If objControlHijo.HasChildren Then
                            RunControls(objControlHijo, NombreControl, vfControl)
                        End If

                        If objControlHijo.Name = NombreControl Then
                            objControlHijo.Visible = vfControl
                            Exit For
                        End If

                End Select

            Next

        End Sub
        Public Shared ReadOnly Property GrillaSelectionBackColor() As Color
            Get
                Return Color.LemonChiffon
            End Get
        End Property
        Public Shared ReadOnly Property GrillaSelectionForeColor() As Color
            Get
                Return Color.Black
            End Get
        End Property
        Public Shared ReadOnly Property GrillaSelectionBackColor_Visita() As Color
            Get
                Return Color.PaleGreen
            End Get
        End Property
    End Class
    Public Class Licencia
        Private Shared intCodigo As Integer = -1
        Public Shared Property Codigo() As Integer
            Get
                'eliminar a futuro
                Return intCodigo
            End Get
            Set(ByVal value As Integer)
                intCodigo = value
            End Set
        End Property
    End Class
End Class
#End Region

Module Main
    Public FORZAR_CIERRE_SESSION_SISTEMA As Boolean = False
    Public HORA_CIERRE_SESSION As TimeSpan
    Private Sub AEliminarArchivos()

        Dim strDirectorio As String = Legolas.Configuration.Path.Directorio

        If Legolas.Components.Archivo.FileExiste(strDirectorio & "setupsqlscript.exe") = True Then
            Legolas.Components.Archivo.FileDelete(strDirectorio & "setupsqlscript.exe")
        End If

        If Legolas.Components.Archivo.FileExiste(strDirectorio & "setupadjuntarbd.exe") = True Then
            Legolas.Components.Archivo.FileDelete(strDirectorio & "setupadjuntarbd.exe")
        End If

        If Legolas.Components.Archivo.FileExiste(Legolas.Configuration.Path.App.SetupConfig) = True Then
            Legolas.Components.Archivo.FileDelete(Legolas.Configuration.Path.App.SetupConfig)
            Exit Sub
        End If

    End Sub


    Public Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        AEliminarArchivos()

        '/*configurar bd*/
        If Legolas.Components.Archivo.FileExiste(Legolas.Configuration.Path.ConfigIni.CN) = False Then
            Legolas.Components.Archivo.EjecutarApp(Legolas.Configuration.Path.App.SetupBDCN)
            Exit Sub
        End If

        '/*validar la instancia*/
        Dim MisProcesos() As Process
        MisProcesos = Process.GetProcessesByName(Application.ProductName.ToString)

        If MisProcesos.Length < 2 Then

            '/*configuracion sistema*/
            Legolas.Configuration.Aplication.Name = My.Application.Info.AssemblyName.ToString
            Legolas.Configuration.Aplication.MessageBox.Empresa = "Instituto Nacional Penitenciario"
            Legolas.Configuration.Aplication.MessageBox.EmpresaNombreCorto = "INPE"
            Legolas.Configuration.Aplication.MessageBox.Modulo = "SIP"

            Legolas.Configuration.Path.App.AppName = Legolas.Configuration.Aplication.Name
            '/*configuracion del servidor de correo*/
            Legolas.Configuration.Correo.Servidor = "mail.inpe.gob.pe"
            Legolas.Configuration.Correo.Usuario = "sip_pope@inpe.gob.pe"
            Legolas.Configuration.Correo.Clave = "098123"

Linea:


            Application.Run(frmInicioSesion_v2)

        Else
            'Hay más de un proceso ejecutandose
            Legolas.Configuration.Aplication.MessageBox.Exclamation("Ya se está ejecutando una instancia del aplicativo")
            Application.Exit()
        End If

        If Legolas.Configuration.Usuario.Conectado = True Then
            Application.Run(MDIParent1)

            'debe cargar el login por tiempo de inactividad
            If FORZAR_CIERRE_SESSION_SISTEMA Then GoTo Linea

        End If

    End Sub
End Module


