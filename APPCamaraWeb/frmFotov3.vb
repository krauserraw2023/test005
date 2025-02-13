Imports System.Drawing
Imports System.Management
Imports System.IO
'Accedemos al control de la webcam usando las .dll AForge.net
Imports AForge.Video.DirectShow
Imports AForge.Video

Public Class frmFotov3

#Region "Propiedades"
    Private Property NombreImagen As String = ""
    Private Property PathFotoTemporal As String = Legolas.Configuration.Path.PathTemp
#End Region
#Region "Propiedades_Return"
    Public Property _PathImagenTemporal As String = ""
#End Region
#Region "Propiedades_Otros"
    Private ReadOnly Property AnchoPrede() As Integer
        Get
            Return 401
        End Get
    End Property
    Private ReadOnly Property AltoPrede() As Integer
        Get
            Return 475
        End Get
    End Property
    Private ReadOnly Property PosX() As Integer
        Get
            Return 107
        End Get
    End Property
    Private ReadOnly Property PosY() As Integer
        Get
            Return 5
        End Get
    End Property
#End Region
#Region "Obtenemos y manipulamos el dispositivo: Webcam"
    'Para el dispositivo
    Private blnExistenDispositivos As Boolean = False
    Private objDispositivosDeVideo As FilterInfoCollection
    Private WithEvents objFuenteDeVideo As VideoCaptureDevice = Nothing

    'Buscamos dispositivos instalados
    Public Sub Buscar_WebCam()
        Try
            objDispositivosDeVideo = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            If objDispositivosDeVideo.Count = 0 Then
                blnExistenDispositivos = False
            Else
                blnExistenDispositivos = True
                ComboWebCam()
                btnIniciar.Enabled = True
            End If
        Catch ex As Exception
            ex.Message.ToUpper()
        End Try
    End Sub
    'cargamos los dispositivos encontrados
    Public Sub ComboWebCam()
        Try
            For i As Integer = 0 To objDispositivosDeVideo.Count - 1
                cbbWebcam.Items.Add(objDispositivosDeVideo(i).Name.ToString())
            Next
            cbbWebcam.Text = cbbWebcam.Items(0).ToString()
        Catch ex As Exception
            ex.Message.ToUpper()
        End Try
    End Sub
    'Accedemos
    Private Sub MostrarVideo(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        Try
            Dim Imagen As Bitmap = DirectCast(eventArgs.Frame.Clone(), Bitmap)
            pbCamaraWeb.Image = Imagen
        Catch ex As Exception
            ex.Message.ToUpper()
        End Try
    End Sub
    'Finalizamos 
    Public Sub Terminar()
        Try
            If Not (objFuenteDeVideo Is Nothing) Then
                If objFuenteDeVideo.IsRunning Then
                    objFuenteDeVideo.SignalToStop()
                    objFuenteDeVideo = Nothing
                End If
            End If
        Catch ex As Exception
            ex.Message.ToUpper()
        End Try
    End Sub

    Private Sub ActivarCamara()

        Try
            If btnIniciar.Text = "Iniciar" Then
                If blnExistenDispositivos Then
                    objFuenteDeVideo = New VideoCaptureDevice(objDispositivosDeVideo(cbbWebcam.SelectedIndex).MonikerString)
                    AddHandler objFuenteDeVideo.NewFrame, New NewFrameEventHandler(AddressOf MostrarVideo)
                    objFuenteDeVideo.Start()
                    btnIniciar.Text = "Detener"
                    cbbWebcam.Enabled = False
                    btnCapturar.Enabled = True
                End If
            Else
                If objFuenteDeVideo.IsRunning Then
                    Terminar()
                    btnIniciar.Text = "Iniciar"
                    cbbWebcam.Enabled = True
                    btnCapturar.Enabled = False
                End If
            End If

        Catch ex As Exception
            ex.Message.ToUpper()
        End Try

    End Sub

#End Region
#Region "Accion"

    Private Sub ACapturarFoto()

        Me.NombreImagen = Now.ToFileTime

        If Me.NombreImagen = "" Or Me.NombreImagen.Length < 4 Then
            Exit Sub
        End If

        Dim strPath As String = Me.PathFotoTemporal & Me.NombreImagen & ".jpg"

        'la imagen va a tener un tamaño de 640 X 480 pixeles
        'Una resolución Horizantal y vertical de 96 ppp
        'Y una profundidad de bits de 24
        PicResultado.Image = pbCamaraWeb.Image

        If Me.PicResultado.Image Is Nothing Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Espere que cargue la WebCam")
            Exit Sub
        Else
            Dim objImagen As New Bitmap(Me.AnchoPrede, Me.AltoPrede)
            Dim objLienzo As Graphics = Graphics.FromImage(objImagen)
            Dim objRecorte As Rectangle = New Rectangle(Me.PosX, Me.PosY, Me.AnchoPrede, Me.AltoPrede)

            objLienzo.DrawImage(Me.PicResultado.Image, 0, 0, objRecorte, GraphicsUnit.Pixel)
            objImagen.Save(strPath, Imaging.ImageFormat.Jpeg)
        End If

        Dim blnOK As Boolean = False
        blnOK = Legolas.Components.Archivo.FileExiste(strPath)

        'Me.PicResultado.ImageLocation = strPath

        If blnOK = True Then
            Me._PathImagenTemporal = strPath
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            "La fotografia no fue grabada, cierre la ventana y vuelve ha intentarlo")
            Me.Close()
        End If

    End Sub
    Public Function _EliminarArchivo(PathFotoName As String) As Boolean

        Dim value As Boolean = False

        If Legolas.Components.Archivo.FileExiste(PathFotoName) = True Then

            value = Legolas.Components.Archivo.FileDelete(PathFotoName)

        End If

        Return value

    End Function
#End Region

    Private Sub frmFotov3_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Try
            If (btnIniciar.Text = "Detener") Then
                Terminar()
            End If          
        Catch ex As Exception
            ex.Message.ToUpper()
        End Try

    End Sub

    Private Sub frmFotov3_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try
            Buscar_WebCam()
            'pbCamaraWeb.BackColor = Color.White

        Catch ex As Exception
            ex.Message.ToUpper()
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnIniciar_Click(sender As System.Object, e As System.EventArgs) Handles btnIniciar.Click

        ActivarCamara()

    End Sub

    Private Sub btnCapturar_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturar.Click

        ACapturarFoto()

    End Sub

    Private Sub btnExportar_Click(sender As System.Object, e As System.EventArgs) Handles btnExportar.Click

        'Me.PicResultado.Image.Save("c:\123.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

    End Sub

    Private Sub frmFotov3_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        Me.Refresh()
        btnIniciar_Click(Nothing, Nothing)

    End Sub

End Class
