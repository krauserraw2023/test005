Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports System.Drawing


Public Class frmFotov2
#Region "Variables"

    Dim lista As New ListBox
    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0
    Dim hHwnd As Integer

    Public Const WM_USER As Long = &H400
    Public Const WM_CAP_START As Long = WM_USER
    Public si As Integer
    Public Const WM_CAP_DLG_VIDEOFORMAT As Long = WM_CAP_START + 41
    Public Const WM_CAP_DLG_VIDEOSOURCE As Long = WM_CAP_START + 42
    Public Const WM_CAP_DLG_VIDEODISPLAY As Long = WM_CAP_START + 43
    Public Const WM_CAP_GET_VIDEOFORMAT As Long = WM_CAP_START + 44
    Public Const WM_CAP_SET_VIDEOFORMAT As Long = WM_CAP_START + 45
    Public Const WM_CAP_DLG_VIDEOCOMPRESSION As Long = WM_CAP_START + 46

    'Formato
    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
     (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
     <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
     ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
     ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
     (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
     ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
     ByVal nHeight As Short, ByVal hWndParent As Integer, _
     ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
     ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
     ByVal cbVer As Integer) As Boolean
#End Region
#Region "CamaraWeb"
    Private Sub CargarWebcam()
        Try
            Dim strName As String = Space(100)
            Dim strVer As String = Space(100)
            Dim bReturn As Boolean
            Dim x As Integer = 0
            Do
                'obtenemos la webcam conectada
                bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
                If bReturn Then lista.Items.Add(strName.Trim)
                x += 1
            Loop Until bReturn = False
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub IniciarWebcam()
        Try
            Dim iHeight As Integer = pbFoto.Height
            Dim iWidth As Integer = pbFoto.Width

            'iniciamos video
            hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 352, _
            288, pbFoto.Handle.ToInt32, 0)
            '532; 452
            'pbFoto.SizeMode = PictureBoxSizeMode.AutoSize

            If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then

                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, 532, 452, SWP_NOMOVE Or SWP_NOZORDER)

            Else
                ' Error de conexion
                DestroyWindow(hHwnd)
            End If

        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub
    Private Sub CerrarWebcam()
        'desconectamos
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        ' cerramos window
        DestroyWindow(hHwnd)
    End Sub

    Private Sub IniciarWC()

        'If a = 1 Then
        iDevice = lista.SelectedIndex
        IniciarWebcam()
        'ElseIf a = 0 Then
        '    cerrar_webcam()
        '    guardar.Enabled = False
        '    Forma.Enabled = False
        '    Iniciar.Text = "Iniciar"
        '    Label3.Text = "miFoto de: "
        '    imagen.Image = Nothing
        '    imagen.Width = 352
        '    imagen.Height = 288
        '    If imagen.Width = 640 And imagen.Height = 480 Then Panel1.Refresh()
        '    si = False
        'End If

        'a = a + 1
        'If a = 2 Then
        '    a = 0
        'End If

    End Sub
    Private Sub CapturarWebCam()

        Try
            Dim data As IDataObject
            ' Copiamos al clipboard
            SendMessage(hHwnd, WM_CAP_EDIT_COPY, 532, 452)
            ' del clipboard - convertir en bitmap
            data = Clipboard.GetDataObject()
            'Panel1.Refresh()
            If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
                PicResultado.Image = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
                'PicResultado.SizeMode = PictureBoxSizeMode.AutoSize
            End If

            Dim strNombreTemp As String = Now.ToFileTime.ToString
            PicResultado.Image.Save("D:\" & strNombreTemp & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

        Catch ex As Exception
            MsgBox("Se ha producido un error inesperado")
        End Try

    End Sub
#End Region
#Region "Otros"
    Private Sub ValoresxDefault()

        CargarWebcam()
        If lista.Items.Count > 0 Then
            lista.SelectedIndex = 0
        Else
            lista.Items.Add("No Capture Device")
        End If

    End Sub
#End Region

    Private Sub frmFotov2_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        CerrarWebcam()

    End Sub

    Private Sub frmFotov2_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        ValoresxDefault()

    End Sub

    Private Sub frmFotov2_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

        Me.Refresh()
        Threading.Thread.Sleep(500)
        IniciarWC()

    End Sub

    Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click

        CapturarWebCam()

    End Sub
End Class

