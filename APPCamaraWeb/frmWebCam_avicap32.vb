Option Explicit On
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class frmWebCam_avicap32

#Region "Clase Avicap32"
    'constantes usadas na DLL
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

    Dim iDevice As Integer = 0 ' ID do dispositivo atual
    Dim hHwnd As Integer ' manipulador da janela do visualizador

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer,
         <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer,
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer,
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    'A função DestroyWindow destroi a janela especificada.
    'Envia as mensagens WM_DESTROY e WM_NCDESTROY para a 
    'janela para destivá-la e remove o foco do teclado da mesma
    'Library - User32
    'Parametros -  hWnd - (identica a janela a ser destruida)
    'Retorna um valor diferente de zero se for executada com sucesso,
    'caso contrario retorna zero
    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean


    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer,
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer,
        ByVal nHeight As Short, ByVal hWndParent As Integer,
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short,
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String,
        ByVal cbVer As Integer) As Boolean
#End Region

#Region "Propiedades"
    Public Property _PathImagenTemporal As String = ""
#End Region

#Region "Otros"
    Private Sub CargarCamaraWeb()

        Dim strNome As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bRetorna As Boolean
        Dim x As Integer = 0

        ' 
        ' Carrega os dispositivos em lstDevices
        Do
            '
            '   Obtem o nome e a versão Driver
            bRetorna = capGetDriverDescriptionA(x, strNome, 100, strVer, 100)

            '
            ' se existir um dispositivo inclui o nome da lista
            If bRetorna Then lstDispositivos.Items.Add(strNome.Trim)
            x += 1
        Loop Until bRetorna = False
    End Sub
    Private Sub VerCamaraWeb()
        Dim iHeight As Integer = picCaptura.Height
        Dim iWidth As Integer = picCaptura.Width

        '
        ' Abre a janela de visualização no picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640,
            480, picCaptura.Handle.ToInt32, 0)

        '
        ' Conecta com o drive
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            '
            'Define a escala de previsão
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)

            '
            'Define a taxa de visualização em milisegundos
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)

            '
            'Iniciar a visualização da imagem a partir da camara
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)

            '
            ' Redimensiona a janela para se ajustar no picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, picCaptura.Width, picCaptura.Height,
                    SWP_NOMOVE Or SWP_NOZORDER)

            'btnSalvar.Enabled = True
            'btnParar.Enabled = True
            'btnIniciar.Enabled = False
        Else
            '
            ' Erro de conexão fecha a janela de dispostivos
            DestroyWindow(hHwnd)

            'btnSalvar.Enabled = False
        End If
    End Sub
    Private Sub CerrarCamaraWeb()
        ' Desconecta do dispositivo
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)

        ' fecha a chama a janela
        DestroyWindow(hHwnd)
    End Sub
    Public Function _EliminarArchivo(PathFotoName As String) As Boolean

        Dim value As Boolean = False

        If Legolas.Components.Archivo.FileExiste(PathFotoName) = True Then

            value = Legolas.Components.Archivo.FileDelete(PathFotoName)

        End If

        Return value

    End Function
#End Region

    Private Sub frmWebCam_avicap32_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'verifica e carrega os dispositivos
        CargarCamaraWeb()

        If lstDispositivos.Items.Count > 0 Then
            'btnIniciar.Enabled = True
            lstDispositivos.SelectedIndex = 0
            'btnIniciar.Enabled = True
        Else
            lstDispositivos.Items.Add("Não dispositivo de captura instalado.")
            'btnIniciar.Enabled = False
        End If

        'btnParar.Enabled = False
        'btnSalvar.Enabled = False
        picCaptura.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs)
        'iDevice = lstDispositivos.SelectedIndex
        'If iDevice <> -1 Then
        '    abreJanelaVisualizacao()
        'Else
        '    MsgBox("Selecione um dispositivo de video...")
        'End If
    End Sub

    Private Sub btnParar_Click(sender As Object, e As EventArgs)

        'fechaJanelaVisualizacao()
        'btnSalvar.Enabled = False
        'btnIniciar.Enabled = True
        'btnParar.Enabled = False

    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub frmWebCam_avicap32_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        'If btnParar.Enabled Then
        CerrarCamaraWeb()
        'End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()

    End Sub

    Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click


        Dim dados As IDataObject
        Dim bmap As Image

        ' Copia a imagem para o clipboard
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

        ' Obtem a imagem do clipboard e converte para bitmap
        dados = Clipboard.GetDataObject()

        If dados.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(dados.GetData(GetType(System.Drawing.Bitmap)), Image)
            picCaptura.Image = bmap
            CerrarCamaraWeb()

            'capturar foto
            Dim intAnchoPred As Integer = 401
            Dim intAltoPred As Integer = 475
            Dim intPosX As Integer = 107
            Dim intPosY As Integer = 5

            Dim strNombreImagen As String = Now.ToFileTime
            Dim strPathFotoTemporal As String = Legolas.Configuration.Path.PathTemp
            Dim strPath As String = strPathFotoTemporal & strNombreImagen & ".jpg"

            If Me.picCaptura.Image Is Nothing Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                    "Espere que cargue la WebCam")
                Exit Sub
            Else
                Dim objImagen As New Bitmap(intAnchoPred, intAltoPred)
                Dim objLienzo As Graphics = Graphics.FromImage(objImagen)
                Dim objRecorte As Rectangle = New Rectangle(intPosX, intPosY, intAnchoPred, intAltoPred)

                objLienzo.DrawImage(Me.picCaptura.Image, 0, 0, objRecorte, GraphicsUnit.Pixel)
                objImagen.Save(strPath, Imaging.ImageFormat.Jpeg)
            End If

            Dim blnOK As Boolean = False
            blnOK = Legolas.Components.Archivo.FileExiste(strPath)

            If blnOK = True Then
                Me._PathImagenTemporal = strPath
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "La fotografia no fue grabada, cierre la ventana y vuelve ha intentarlo")
                Me.Close()
            End If

            'btnParar.Enabled = False
            'btnIniciar.Enabled = True

            'If sfdImage.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            '    bmap.Save(sfdImage.FileName, Imaging.ImageFormat.Bmp)
            'End If

        End If

    End Sub

    Private Sub frmWebCam_avicap32_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        iDevice = lstDispositivos.SelectedIndex
        If iDevice <> -1 Then
            VerCamaraWeb()
        Else
            MsgBox("Selecione um dispositivo de video...")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class