
Public NotInheritable Class LogSIP
    'En futura version mover a un nuevo proyecto de utilidad transversal a una arquitectura de solucion.
    Enum enmTipoLog
        Debug = 1
        Warning = 2
        ErrorCritico = 3
    End Enum

    Private Shared activarDebug As Boolean = False

    Private Shared _Instance As LogSIP = Nothing
    Private Shared ReadOnly _Sync As New Object

    Sub New(_activarDebug As Boolean)
        activarDebug = _activarDebug
    End Sub

    Public Shared ReadOnly Property getLog() As LogSIP
        Get
            If _Instance Is Nothing Then
                SyncLock _Sync
                    If _Instance Is Nothing Then
                        _Instance = New LogSIP(activarDebug)
                    End If
                End SyncLock
            End If
            Return _Instance
        End Get
    End Property


    Public Sub Debug(Seccion As String, mensaje As String)
        If activarDebug Then
            EscribirLog(Seccion, mensaje, enmTipoLog.Debug)
        End If
    End Sub
    Public Sub Warning(Seccion As String, mensaje As String)
        EscribirLog(Seccion, mensaje, enmTipoLog.Warning)
    End Sub
    Public Sub ErrorCritico(Seccion As String, mensaje As String)
        EscribirLog(Seccion, mensaje, enmTipoLog.ErrorCritico)
    End Sub

    Private Shared Sub EscribirLog(Seccion As String, mensaje As String, tipoLog As LogSIP.enmTipoLog)

        Dim strNombreArchivo As String = "SIP_" & Now.Year & Now.Month & ".log" 'log por mes

        Dim strRuta As String = My.Application.Info.DirectoryPath & "/Log"

        If Not My.Computer.FileSystem.DirectoryExists(strRuta) Then
            My.Computer.FileSystem.CreateDirectory(strRuta)
        End If

        strRuta = strRuta & "/" & strNombreArchivo

        If IO.File.Exists(strRuta) = False Then
            Dim objFile As System.IO.StreamWriter = System.IO.File.CreateText(strRuta)
            objFile.Close()
        End If

        Dim strMensaje As String = Seccion & ": " & mensaje
        Dim fichero As New System.IO.StreamWriter(strRuta, True)
        Dim tip As String = ""
        Select Case tipoLog
            Case enmTipoLog.Debug
                tip = "[DEBUG] "
            Case enmTipoLog.ErrorCritico
                tip = "[ERROR] "
            Case enmTipoLog.Warning
                tip = "[WARNING]"
        End Select

        fichero.WriteLine(tip & "-" & Now & Chr(9) & strMensaje)
        fichero.Close()

    End Sub
End Class
