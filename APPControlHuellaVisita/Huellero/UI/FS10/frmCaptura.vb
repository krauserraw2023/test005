Imports System.IO
Imports System.Windows.Forms
Imports APPControlHuellaVisita.Type
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Threading
Imports System.Runtime.InteropServices
Imports ScanAPIHelper

Namespace Huellero.FS10
    Public Class frmCaptura

        Private m_hDevice As Device
        Private m_ScanMode As Byte
        Private m_bScanning As Boolean = False
        Private m_bExit As Boolean
        Private imgRaw(512 * 512 - 1) As Byte
        Private FTR_MATCH_SCORE_VALUE() As Byte
        Private m_bIsLFDSupported As Boolean
        Private m_nImageHeight As Integer
        Private m_nImageWidth As Integer
        Private contadorMuestreo As Integer = 0
        Private m_bCancelOperation As Boolean = False
        Private m_Frame() As Byte
        Private intcalidad As Integer = 0
        Private m_verificar As Boolean
        Private miFont As Font = New Font("Arial", 30, FontStyle.Italic)
        Private blnOkHuella As Boolean = False

        Private Property enm_CalidadMinimaHuellaAceptable As Enumeracion.IndiceCalidadHuella = Enumeracion.IndiceCalidadHuella.Media        
        '/**************************************************/                

        Public Property _CalidadIndiceHuellaCapturada As Enumeracion.IndiceCalidadHuella = Enumeracion.IndiceCalidadHuella.NoEspecificado
        Public Property _TemplateANSI() As Byte() = Nothing
        Public Property _TemplateSUPREMA() As Byte() = Nothing
        Public Property _WSQ() As Byte() = Nothing
        Public Property _ImagenHuella As Byte() = Nothing

#Region "Constantes"
        Public Const FTR_ERROR_EMPTY_FRAME As Integer = 4306
        Public Const FTR_ERROR_MOVABLE_FINGER As Integer = &H20000001
        Public Const FTR_ERROR_NO_FRAME As Integer = &H20000002
        Public Const FTR_ERROR_USER_CANCELED As Integer = &H20000003
        Public Const FTR_ERROR_HARDWARE_INCOMPATIBLE As Integer = &H20000004
        Public Const FTR_ERROR_FIRMWARE_INCOMPATIBLE As Integer = &H20000005
        Public Const FTR_ERROR_INVALID_AUTHORIZATION_CODE As Integer = &H20000006
#End Region

#Region "Delegados"
        Private Delegate Sub SetTextCallback(text As String)
        Private Delegate Sub SetUpdateTextCalidadHuellaCallback(calidadHuella As Integer, xCoord As Integer, yCoord As Integer)        
#End Region

#Region "Clase_ComboBoxItem"
        Public Class ComboBoxItem
            Dim m_String As String
            Dim m_InterfaceNumber As Integer

            Public Sub New(ByVal value As String, ByVal interfaceNumber As Integer)
                m_String = value
                m_InterfaceNumber = interfaceNumber
            End Sub

            Public Overrides Function ToString() As String
                Return m_String
            End Function

            Public ReadOnly Property interfaceNumber() As Integer
                Get
                    Return m_InterfaceNumber
                End Get
            End Property
        End Class
#End Region

#Region "Funciones_Publicas"

        Public Function _IniciarDispositivo(tipoDedo As Enumeracion.TipoDedo, calidadMinimaHuellaAceptable As Enumeracion.IndiceCalidadHuella) As Boolean

            'limpia las variables 
            Me._CalidadIndiceHuellaCapturada = calidadMinimaHuellaAceptable

            Me._TemplateANSI = Nothing
            Me._TemplateSUPREMA = Nothing
            Me._WSQ = Nothing
            Me._ImagenHuella = Nothing

            Return True
        End Function

        Public Sub _FinalizarCaptura()

            'para este modelo no es necesario finalizar el dispositivo

        End Sub

#End Region

#Region "Funciones_SDK"
        Private Sub IniciarSDK()

            m_hDevice = Nothing
            m_ScanMode = 0
            m_bScanning = False
            m_bExit = False

            Dim defaultInterface As Integer
            Dim status() As FTRSCAN_INTERFACE_STATUS

            Try
                defaultInterface = ScanAPIHelper.Device.BaseInterface
                status = ScanAPIHelper.Device.GetInterfaces()
                For i As Integer = 0 To status.Length - 1
                    If status(i) = FTRSCAN_INTERFACE_STATUS.FTRSCAN_INTERFACE_STATUS_CONNECTED Then
                        Dim index As Integer
                        index = CBDeviceIndex.Items.Add(New ComboBoxItem(i.ToString(), i))
                        If (defaultInterface = i) Then
                            CBDeviceIndex.SelectedIndex = index
                        End If
                    End If
                Next i
            Catch ex As ScanAPIException
                ShowError(ex)
            End Try

            m_ScanMode = 0

            For i As Integer = 0 To 512 * 512 - 1
                imgRaw(i) = 255
            Next

            FTR_MATCH_SCORE_VALUE = New Byte() {37, 65, 93, 121, 146, 189}
            '   37:  MATCH_SCORE_LOW
            '   65:  MATCH_SCORE_LOW_MEDIUM
            '   93:  MATCH_SCORE_MEDIUM
            '   121: MATCH_SCORE_HIGH_MEDIUM
            '   146: MATCH_SCORE_HIGH
            '   189: MATCH_SCORE_VERY_HIGH

        End Sub

        Private Sub Iniciar_Dispositivo()

            Try
                m_hDevice = New Device()
                m_hDevice.Open()
                ' Se obtiene parámetros del dispositivo
                Dim version As VersionInfo = m_hDevice.VersionInformation

                m_bIsLFDSupported = False
                Dim dinfo As DeviceInfo = m_hDevice.Information
                Dim sizeImage As Size = m_hDevice.ImageSize
                m_nImageHeight = sizeImage.Height
                m_nImageWidth = sizeImage.Width

                Select Case (dinfo.DeviceCompatibility)
                    Case 0
                        Me.lblEstado.Text = "FS80"
                        m_bIsLFDSupported = True
                    Case 1
                        Me.lblEstado.Text = "FS80"
                        m_bIsLFDSupported = True
                    Case 4
                        Me.lblEstado.Text = "FS80"
                        m_bIsLFDSupported = True
                    Case 11
                        Me.lblEstado.Text = "FS80"
                        m_bIsLFDSupported = True
                    Case 5
                        Me.lblEstado.Text = "FS88"
                        m_bIsLFDSupported = True
                    Case 7
                        Me.lblEstado.Text = "FS50"
                    Case 8
                        Me.lblEstado.Text = "FS60"
                    Case 9
                        Me.lblEstado.Text = "FS25"
                        m_bIsLFDSupported = True
                    Case 10
                        Me.lblEstado.Text = "FS10"
                    Case 13
                        Me.lblEstado.Text = "FS80H"
                        m_bIsLFDSupported = True
                    Case 14
                        Me.lblEstado.Text = "FS88H"
                        m_bIsLFDSupported = True
                    Case 15
                        Me.lblEstado.Text = "FS64"
                    Case 16
                        Me.lblEstado.Text = "FS26E"
                    Case 17
                        Me.lblEstado.Text = "FS80HS"
                    Case 18
                        Me.lblEstado.Text = "FS26"
                        m_bIsLFDSupported = True
                    Case 20
                        Me.lblEstado.Text = "FS26EU"
                        m_bIsLFDSupported = True
                    Case Else
                        Me.lblEstado.Text = "Dispositivo desconocido"
                End Select

                m_hDevice.InvertImage = True

            Catch ex As ScanAPIException
                If m_hDevice IsNot Nothing Then
                    m_hDevice.Dispose()
                    m_hDevice = Nothing
                    ShowError(ex)
                End If
            End Try

        End Sub

        Private Sub IniciarCaptura()

            If Not m_bScanning = True Then
                contadorMuestreo = 0
                Dim WorkerThread As Thread = New Thread(New ThreadStart(AddressOf CaptureThread))
                WorkerThread.Start()
            Else
                m_bCancelOperation = True
            End If

        End Sub

        Private Sub CaptureThread()

            m_bScanning = True

            m_hDevice.SetDiodesStatus(DiodesStatus.turn_off, DiodesStatus.turn_on_permanent)
            Thread.Sleep(1000)

            While (Not m_bCancelOperation)

                GetFrame()
                If m_Frame IsNot Nothing Then

                    Try

                        m_hDevice.SetDiodesStatus(DiodesStatus.turn_on_permanent, DiodesStatus.turn_off)

                        intcalidad = m_hDevice.getNfiq(m_Frame, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height)

                        Dim myFile As MyBitmapFile = New MyBitmapFile(m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, m_Frame)

                        Dim BmpStream As MemoryStream = New MemoryStream(myFile.BitmatFileData)

                        pbHuella.Image = New Bitmap(BmpStream)

                        If Not pbHuella.Image Is Nothing Then UpdateTextCalidadHuella(intcalidad, 1, 0)

                    Catch ex As Exception

                        pbHuella.Image = Nothing
                        Me.PictureBox1.Image = Nothing

                    End Try

                Else
                    pbHuella.Image = Nothing
                    Me.PictureBox1.Image = Nothing
                End If

                Thread.Sleep(10)

            End While

            m_bScanning = False

        End Sub

        Private Sub GetFrame()

            Try

                If m_ScanMode = 0 Then
                    If Not m_hDevice Is Nothing Then m_Frame = m_hDevice.GetFrame()
                Else
                    m_Frame = m_hDevice.GetImage(m_ScanMode)
                End If

                If Not m_hDevice Is Nothing Then

                    If m_hDevice.Information.DeviceCompatibility <> 7 Then

                        If contadorMuestreo = 5 Then

                            If intcalidad = 1 Or intcalidad = 2 Or intcalidad = 3 Then
                                blnOkHuella = True
                                SetMessageText("OK")
                                finishCapture()
                                m_Frame = Nothing
                            End If

                            contadorMuestreo = 0

                        Else
                            contadorMuestreo += 1
                        End If
                    Else
                        SetMessageText("OK")
                        finishCapture()
                        m_Frame = Nothing
                    End If

                End If

            Catch ex As ScanAPIException
                If m_Frame IsNot Nothing Then
                    m_Frame = Nothing
                    ShowError(ex)
                End If
            End Try

        End Sub

        Private Sub UpdateTextCalidadHuella(calidadHuella As Integer, xCoord As Integer, yCoord As Integer)
            If Me.InvokeRequired Then
                Dim d As New SetUpdateTextCalidadHuellaCallback(AddressOf Me.UpdateTextCalidadHuella)
                Me.Invoke(d, New Object() {calidadHuella, xCoord, yCoord})
            Else
                Me.UpdateStringCalidadHuella(calidadHuella, xCoord, yCoord)
            End If
        End Sub

        Private Sub UpdateStringCalidadHuella(ByVal calidadHuella As Integer, ByVal xCoord As Integer, ByVal yCoord As Integer)

            If Me.pbHuella.Image IsNot Nothing Then

                Dim fondoNfqBrush As New SolidBrush(Color.Blue)
                Dim b As New SolidBrush(Color.White)
                Dim Ptxt As New Point(xCoord + 2, yCoord + 2)

                Select Case calidadHuella
                    Case 1
                        fondoNfqBrush = New SolidBrush(Color.Green)
                    Case 2
                        fondoNfqBrush = New SolidBrush(Color.Blue)
                    Case 3
                        fondoNfqBrush = New SolidBrush(Color.Yellow)
                        b = New SolidBrush(Color.Black)
                    Case Else
                        fondoNfqBrush = New SolidBrush(Color.Red)
                End Select

                Dim bm As New Bitmap(50, 50)
                Dim g As Graphics = Graphics.FromImage(bm)   ' Graphics.FromImage(PBox_PreviewHuellas.Image)

                'g.DrawImage(PictureBox1.Image, 0, 0)

                g.FillEllipse(fondoNfqBrush, xCoord, yCoord, 40, 50)
                g.DrawEllipse(New Pen(Color.FromArgb(20, 20, 20), 1), xCoord, yCoord, 40, 50)
                g.DrawString(calidadHuella, miFont, b, Ptxt)
                fondoNfqBrush.Dispose()

                b.Dispose()
                g.Dispose()

                PictureBox1.Image = bm
                PictureBox1.Invalidate()

            Else
                Me.PictureBox1.Image = Nothing
            End If

        End Sub

        Private Sub ShowError(ByRef ex As ScanAPIException)
            Dim szMessage As String
            Select Case (ex.ErrorCode)
                Case FTR_ERROR_EMPTY_FRAME
                    szMessage = "No hay dedo en el sensor"
                Case FTR_ERROR_MOVABLE_FINGER
                    szMessage = "Dedo moviéndose"
                Case FTR_ERROR_NO_FRAME
                    szMessage = "Dedo falso"
                Case FTR_ERROR_HARDWARE_INCOMPATIBLE
                    szMessage = "Hardware Incompatible"
                Case FTR_ERROR_FIRMWARE_INCOMPATIBLE
                    szMessage = "Firmware Incompatible"
                Case FTR_ERROR_INVALID_AUTHORIZATION_CODE
                    szMessage = "Código de Autorización no válido"
                Case Else
                    szMessage = String.Format("Código de error: {0}", ex.ErrorCode)
            End Select
            SetMessageText(szMessage)
        End Sub

        Private Sub SetMessageText(ByVal text As String)
            If m_bExit Then
                Exit Sub
            End If
            If (lblEstado.InvokeRequired) Then
                Dim d As SetTextCallback = New SetTextCallback(AddressOf Me.SetMessageText)

                Try
                    Me.Invoke(d, New Object() {text})
                Catch ex As Exception

                End Try

            Else
                Me.lblEstado.Text = text
                Me.Update()
            End If
        End Sub

        Private Sub finishCapture()

            m_bCancelOperation = True

            If blnOkHuella = True Then CerrarVentana()

        End Sub

#End Region

#Region "Accion"

        Private Sub CerrarVentana()

            Dim pAnsiTemplate() As Byte
            'Dim pIsoTemplate() As Byte
            Dim wsqImage() As Byte
            Dim fBitRate As Single = 0.75  ' en el rango de 0.75 - 2.25, a menor valor mayor ratio de compresion 

            llenarBufferRaw()

            If Not m_hDevice Is Nothing Then

                wsqImage = m_hDevice.WSQ_FromRawImage(imgRaw, 512, 512, fBitRate)
                pAnsiTemplate = m_hDevice.CreateAnsiTemplate(m_Frame, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height)
                'pIsoTemplate = m_hDevice.ConvertAnsiTemplateToIso(pAnsiTemplate)

                Dim objImagen As System.Drawing.Image = Me.pbHuella.Image
                If Not objImagen Is Nothing Then
                    Dim Codi As New IO.MemoryStream
                    objImagen.Save(Codi, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Me._ImagenHuella = Codi.GetBuffer
                Else
                    Me._ImagenHuella = Nothing
                End If

                Me._CalidadIndiceHuellaCapturada = Me.intcalidad
                Me._WSQ = wsqImage
                Me._TemplateANSI = pAnsiTemplate
                Me._TemplateSUPREMA = Nothing

                Me.DialogResult = Windows.Forms.DialogResult.OK

            End If

        End Sub

        Private Sub llenarBufferRaw()

            If Not m_hDevice Is Nothing Then

                If ((m_hDevice.ImageSize.Width > 512) Or (m_hDevice.ImageSize.Height > 512)) Then
                    Dim flagError As Boolean
                    flagError = False
                    Dim subfPointCoord(1) As SubfPointCoord
                    'subfPointCoord = New SubfPointCoord(1)
                    Dim segmParameters As SegmParameters
                    segmParameters = New SegmParameters()
                    segmParameters.nParamNfiq = SegmAdjustment.nonfiq
                    segmParameters.nParamFixedSize = SegmAdjustment.fixedsize
                    segmParameters.nHeightSubf = 512
                    segmParameters.nWidthSubf = 512
                    segmParameters.nParamAngle = SegmAdjustment.noangle
                    segmParameters.nParamFing = SegmAdjustment.nfing1
                    m_hDevice.MathImageSegment(m_Frame, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height, Nothing, imgRaw, segmParameters, subfPointCoord, flagError)
                Else
                    Dim indiceRaw As Integer = 0
                    Dim dx As Integer = (512 - m_hDevice.ImageSize.Width) / 2
                    Dim dy As Integer = 512 - m_hDevice.ImageSize.Height
                    For i As Integer = dy To (m_hDevice.ImageSize.Height + dy) - 1
                        For j As Integer = dx To (m_hDevice.ImageSize.Width + dx) - 1
                            imgRaw(j + 512 * i) = m_Frame(indiceRaw)
                            indiceRaw += 1
                        Next
                    Next
                End If

            End If

        End Sub

#End Region

#Region "Otros"
       
#End Region

        Private Sub frmCaptura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            IniciarSDK()

            If Me.CBDeviceIndex.Items.Count < 1 Then
                MessageBox.Show("Dispositivo no encontrado.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

        End Sub

        Private Sub frmCaptura_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            Me.SuspendLayout()

            Iniciar_Dispositivo()
            IniciarCaptura()

            Me.ResumeLayout()

        End Sub

        Private Sub frmCaptura_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

            If Not m_hDevice Is Nothing Then m_hDevice.SetDiodesStatus(DiodesStatus.turn_off, DiodesStatus.turn_off)

            m_bExit = True
            m_bCancelOperation = True
            If m_hDevice IsNot Nothing Then
                m_hDevice.Dispose()
                m_hDevice = Nothing                                                
            End If

        End Sub

    End Class
End Namespace
