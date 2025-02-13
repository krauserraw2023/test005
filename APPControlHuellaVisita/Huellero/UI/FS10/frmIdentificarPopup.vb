Imports System.IO
Imports System.Windows.Forms
Imports APPControlHuellaVisita.Type
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Threading
Imports System.Runtime.InteropServices
Imports ScanAPIHelper

Namespace Huellero.FS10
    Public Class frmIdentificarPopup

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

        Private WorkerThread As Thread = Nothing

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
                WorkerThread = New Thread(New ThreadStart(AddressOf CaptureThread))
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
                        Dim Bmp As Bitmap = New Bitmap(BmpStream)
                        pbHuella.Image = Bmp

                        If Not pbHuella.Image Is Nothing Then UpdateTextCalidadHuella(intcalidad, 1, 0)

                    Catch ex As Exception

                    End Try

                End If

                Thread.Sleep(10)

            End While

            m_bScanning = False

            If blnOkHuella = True Then CargarDatosHuella()

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
                            End If
                            contadorMuestreo = 0
                        Else
                            contadorMuestreo += 1
                        End If
                    Else
                        SetMessageText("OK")
                        finishCapture()
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

                pbLeyendaColor.Image = bm
                pbLeyendaColor.Invalidate()

            Else
                Me.pbLeyendaColor.Image = Nothing
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
            If m_bExit Then Exit Sub

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

        End Sub
#End Region

#Region "Accion"

        Private Sub CargarDatosHuella()

            Dim pAnsiTemplate() As Byte
            Dim wsqImage() As Byte
            Dim fBitRate As Single = 0.75  ' en el rango de 0.75 - 2.25, a menor valor mayor ratio de compresion 

            llenarBufferRaw()

            If Not m_hDevice Is Nothing Then

                wsqImage = m_hDevice.WSQ_FromRawImage(imgRaw, 512, 512, fBitRate)
                pAnsiTemplate = m_hDevice.CreateAnsiTemplate(m_Frame, m_hDevice.ImageSize.Width, m_hDevice.ImageSize.Height)

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

                'llenar el objeto huella
                objDTOHuellaIndice = New Entity.Huella
                With objDTOHuellaIndice

                    .TipoDedo = Me.TipoDedo
                    .HuellaByte = Me._ImagenHuella
                    .CalidadHuella = Me._CalidadIndiceHuellaCapturada
                    .TemplateAnsi = Me._TemplateANSI
                    .TemplateSuprema = Me._TemplateSUPREMA
                    .TemplateWsq = Me._WSQ
                    .HayDatos = True
                End With

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

#Region "Verificacion"
        Private objDTOHuellaIndice As Entity.Huella = Nothing
        Private blnCargaForm As Boolean = False
        Private intContaDer As Short = 0
        Private intContaIzq As Short = 0
        Private blnCargaDatosHuellaVeri As Boolean = False
        '***variables de la huella de verificacion***
        Private intTipoCapturaIzquierda As Short = -1
        Private intIDIndiceIzq As Integer = -1
        Private intIDPulgarIzq As Integer = -1
        Private intCalidadIndiceIzq As Short = -1
        Private intCalidadPulgarIzq As Short = -1
        Private intTipoCapturaDerecho As Short = -1
        Private intIDIndiceDer As Integer = -1
        Private intIDPulgarDer As Integer = -1
        Private intCalidadIndiceDer As Short = -1
        Private intCalidadPulgarDer As Short = -1
        Private blnCambiarMano As Boolean = False

#Region "Enum"
        Public Enum enmTipoBusqueda As Short
            Ninguno = 0
            Verificacion = 1
            Identificacion = 2
            IdentificacionPendxSalir = 3
        End Enum
        Public Enum enmTipoMano As Short
            Ninguno = 0
            Izquierda = 1
            Derecha = 2
        End Enum
#End Region

#Region "Propiedades_Publicas"
        Public Property _TipoBusqueda As enmTipoBusqueda = enmTipoBusqueda.Ninguno
        Public Property _IDTipoDocumento As Short = -1
        Public Property _NumeroDocumento As String = ""
        Public Property _HabilitarRecaptura As Boolean = True
        Public Property _IDTemplateColSinSalida As List(Of Integer)
        Public Property _CNBDHuella As String = ""
#End Region

#Region "Propiedades"
        Private Property ManoSeleccionada As enmTipoMano = enmTipoMano.Ninguno

        Private ReadOnly Property TipoDedo As Integer
            Get

                Dim value As Short = -1

                Select Case Me.ManoSeleccionada
                    Case enmTipoMano.Izquierda
                        value = IIf(Me.chkHueIzq.Checked, Type.Enumeracion.TipoDedo.IndiceIzquierdo, Type.Enumeracion.TipoDedo.PulgarIzquierdo)

                    Case enmTipoMano.Derecha
                        value = IIf(Me.chkHueDer.Checked, Type.Enumeracion.TipoDedo.IndiceDerecho, Type.Enumeracion.TipoDedo.PulgarDerecho)

                End Select

                Return value
            End Get

        End Property

#End Region

#Region "Propiedades_Retorno"
        Public Property _RecapturarReturn As Boolean = False
        Public Property _ReturnIDTemplateColRpta As List(Of Integer)
#End Region

#Region "Otros"
        Private Sub SeleccionarMano(blnCambiarMano As Boolean, objTipoMano As enmTipoMano)

            '/*limpiar*/
            Me.pbManoIzq.BorderStyle = BorderStyle.None
            Me.pbManoIzq.BackColor = Color.White
            Me.pbManoDer.BorderStyle = BorderStyle.None
            Me.pbManoDer.BackColor = Color.White

            'si es por verificacion, el enabled esta deshabilitado
            If Me.chkHueIzq.Enabled = True Then Me.chkHueIzq.Checked = False
            If Me.chkHueDer.Enabled = True Then Me.chkHueDer.Checked = False

            Me.pnlManoIzqDetalle.Visible = False
            Me.pnlManoDerDetalle.Visible = False

            Me.ManoSeleccionada = objTipoMano

            Select Case objTipoMano

                Case enmTipoMano.Izquierda
                    Me.pbManoIzq.BorderStyle = BorderStyle.Fixed3D
                    Me.pbManoIzq.BackColor = Color.SteelBlue

                    'si es por verificacion, el enabled esta deshabilitado
                    If Me.chkHueIzq.Enabled = True Then Me.chkHueIzq.Checked = True

                    Me.pnlManoIzqDetalle.Visible = True

                Case enmTipoMano.Derecha

                    Me.pbManoDer.BorderStyle = BorderStyle.Fixed3D
                    Me.pbManoDer.BackColor = Color.SteelBlue

                    'si es por verificacion, el enabled esta deshabilitado
                    If Me.chkHueDer.Enabled = True Then Me.chkHueDer.Checked = True

                    Me.pnlManoDerDetalle.Visible = True

            End Select

            If blnCambiarMano = False Then
                Me.pbHuella.Image = My.Resources.huella_x
                Me.pbLeyendaColor.Image = Nothing
            End If

            If Not m_hDevice Is Nothing Then m_hDevice.SetDiodesStatus(DiodesStatus.turn_off, DiodesStatus.turn_off)
            If Not WorkerThread Is Nothing Then WorkerThread.Abort()

            Me.btnAceptar.Enabled = False
            Me.btnCapturarHuella.Enabled = True

        End Sub
        Private Function ValidarParametrosEntrada() As Boolean

            Dim value As Boolean = False

            If _CNBDHuella.Trim.Length < 33 Then
                MessageBox.Show("La cadena de conexion de la base de datos huella no esta configurada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return value
            End If

            If Me._TipoBusqueda < 1 Then
                MessageBox.Show("El tipo de busqueda no esta configurado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return value
            End If

            Select Case Me._TipoBusqueda

                Case enmTipoBusqueda.Verificacion

                    If Me._IDTipoDocumento < 1 Then
                        MessageBox.Show("El tipo de documento no sido enviado como parametro de entrada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return value
                    End If

                    If Me._NumeroDocumento.Trim.Length < 5 Then
                        MessageBox.Show("El numero de documento no sido enviado como parametro de entrada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return value
                    End If

                    If blnCargaDatosHuellaVeri = False Then
                        MessageBox.Show("La verificacion de huella no esta configurada, debe invocar al metodo [_mostrarHuellaVerificacion]", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return value
                    End If

                Case enmTipoBusqueda.IdentificacionPendxSalir

                    If Me._IDTemplateColSinSalida Is Nothing Then
                        MessageBox.Show("El parametro [_IDTemplateColSinSalida], no esta configurado para el tipo de busqueda asignado", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return value
                    End If

            End Select

            value = True
            Return value

        End Function
        Private Sub HabilitarRecaptura()

            Select Case Me.ManoSeleccionada
                Case enmTipoMano.Izquierda
                    intContaIzq = intContaIzq + 1
                Case enmTipoMano.Derecha
                    intContaDer = intContaDer + 1
            End Select

            If intContaIzq >= 3 Or intContaDer >= 3 Then Me.btnRecapturar.Enabled = True

            Me.btnCapturarHuella.Focus()

        End Sub
        Public Sub _DatosHuellaVerificacion(intTipoCapturaIzquierda As Short, intIDIndiceIzq As Integer, intIDPulgarIzq As Integer, intCalidadIndiceIzq As Short,
                                                  intCalidadPulgarIzq As Short,
                                      intTipoCapturaDerecho As Short, intIDIndiceDer As Integer, intIDPulgarDer As Integer, intCalidadIndiceDer As Short,
                                      intCalidadPulgarDer As Short)

            Me.intTipoCapturaIzquierda = intTipoCapturaIzquierda
            Me.intIDIndiceIzq = intIDIndiceIzq
            Me.intIDPulgarIzq = intIDPulgarIzq
            Me.intCalidadIndiceIzq = intCalidadIndiceIzq
            Me.intCalidadPulgarIzq = intCalidadPulgarIzq
            Me.intTipoCapturaDerecho = intTipoCapturaDerecho
            Me.intIDIndiceDer = intIDIndiceDer
            Me.intIDPulgarDer = intIDPulgarDer
            Me.intCalidadIndiceDer = intCalidadIndiceDer
            Me.intCalidadPulgarDer = intCalidadPulgarDer

            blnCargaDatosHuellaVeri = True

        End Sub

        Private Sub mostrarHuellasDisponibles()

            Dim blnTieneManoIzq As Boolean = False
            Dim blnMostrarCalidadIzq As Boolean = False
            Dim blnHabilitarIndiceIzq As Boolean = False
            Dim intCalidadIzq As Short = 0
            Dim strObsIzq As String = ""

            Dim blnTieneManoDer As Boolean = False
            Dim blnMostrarCalidadDer As Boolean = False
            Dim blnHabilitarIndiceDer As Boolean = False
            Dim intCalidadDer As Short = 0
            Dim strObsDer As String = ""

            Select Case Me.intTipoCapturaIzquierda

                Case Type.Enumeracion.TipoCapturaHuella.Normal

                    blnTieneManoIzq = True
                    blnMostrarCalidadIzq = True

                    'si tiene huella del dedo indice 
                    If Me.intIDIndiceIzq > 0 Then
                        blnHabilitarIndiceIzq = True
                        intCalidadIzq = Me.intCalidadIndiceIzq
                    End If

                    If Me.intIDPulgarIzq > 0 Then
                        blnHabilitarIndiceIzq = False
                        intCalidadIzq = Me.intCalidadPulgarIzq
                    End If

                Case Type.Enumeracion.TipoCapturaHuella.Amputado

                    With Me.pbManoIzq
                        .Image = My.Resources.huella_x
                        .Enabled = False
                    End With

                    Me.pnlManoIzqDetalle.Visible = False
                    strObsIzq = "Amputado"

                Case Type.Enumeracion.TipoCapturaHuella.Observado

                    With Me.pbManoIzq
                        .Image = My.Resources.huella_x
                        .Enabled = False
                    End With

                    Me.pnlManoIzqDetalle.Visible = False
                    strObsIzq = "Observado"
            End Select

            'mano derecha
            Select Case Me.intTipoCapturaDerecho

                Case Type.Enumeracion.TipoCapturaHuella.Normal

                    blnTieneManoDer = True
                    blnMostrarCalidadDer = True

                    ' si tiene huella del dedo indice 
                    If Me.intIDIndiceDer > 0 Then
                        blnHabilitarIndiceDer = True
                        intCalidadDer = Me.intCalidadIndiceDer
                    End If

                    If Me.intIDPulgarDer > 0 Then
                        blnHabilitarIndiceDer = False
                        intCalidadDer = Me.intCalidadPulgarDer
                    End If

                Case Type.Enumeracion.TipoCapturaHuella.Amputado
                    With pbManoDer
                        .Image = My.Resources.huella_x
                        .Enabled = False
                    End With
                    Me.pnlManoDerDetalle.Visible = False
                    blnCambiarMano = True
                    strObsDer = "Amputado"

                Case Type.Enumeracion.TipoCapturaHuella.Observado

                    With pbManoDer
                        .Image = My.Resources.huella_x
                        .Enabled = False
                    End With
                    Me.pnlManoDerDetalle.Visible = False

                    blnCambiarMano = True
                    strObsDer = "Observado"
            End Select

            Me.lblObsManIzq.Text = strObsIzq
            Me.lblObsManDer.Text = strObsDer

            Me.lblObsManIzq.Visible = True
            Me.lblObsManDer.Visible = True

            Me.pbCalidadManoIzq.Visible = blnMostrarCalidadIzq
            Me.pbCalidadManoDer.Visible = blnMostrarCalidadDer

            Me.chkHueIzq.Checked = blnHabilitarIndiceIzq
            Me.chkHueIzq.Enabled = False

            Me.chkHueDer.Checked = blnHabilitarIndiceDer
            Me.chkHueDer.Enabled = False

            'asignar el color de la calidad de la huella
            Select Case intCalidadIzq
                Case Type.Enumeracion.IndiceCalidadHuella.MuyAlta
                    Me.pbCalidadManoIzq.Image = My.Resources.estado_verde
                Case Type.Enumeracion.IndiceCalidadHuella.Alta
                    Me.pbCalidadManoIzq.Image = My.Resources.estado_azul
                Case Type.Enumeracion.IndiceCalidadHuella.Media
                    Me.pbCalidadManoIzq.Image = My.Resources.estado_amarillo
            End Select

            'asignar el color de la calidad de la huella
            Select Case intCalidadDer
                Case Type.Enumeracion.IndiceCalidadHuella.MuyAlta
                    Me.pbCalidadManoDer.Image = My.Resources.estado_verde
                Case Type.Enumeracion.IndiceCalidadHuella.Alta
                    Me.pbCalidadManoDer.Image = My.Resources.estado_azul
                Case Type.Enumeracion.IndiceCalidadHuella.Media
                    Me.pbCalidadManoDer.Image = My.Resources.estado_amarillo
            End Select

            chkHueIzq_Click(Nothing, Nothing)
            chkHueDer_Click(Nothing, Nothing)

            'si no hay huella en la mano derecha, hacer el cambio de mano
            If blnCambiarMano = True Then
                pbManoIzq_Click(Nothing, Nothing)
                blnCambiarMano = False
            End If

            'si ambos dedos estan observados o amputados, iniciar la recaptura automatica
            If blnTieneManoIzq = False And blnTieneManoDer = False Then
                btnRecapturar_Click(Nothing, Nothing)
            End If

        End Sub
#End Region

#End Region

        Private Sub frmCaptura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

            Me.ManoSeleccionada = enmTipoMano.Derecha
            Me.pbManoDer.BorderStyle = BorderStyle.Fixed3D
            Me.pbManoDer.BackColor = Color.SteelBlue

            Me.pnlManoIzqDetalle.Visible = False

            If ValidarParametrosEntrada() = False Then Me.Close()

            IniciarSDK()

            If Me.CBDeviceIndex.Items.Count < 1 Then
                MessageBox.Show("Dispositivo no encontrado.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()
            End If

            Me.Timer1.Start()

        End Sub

        Private Sub frmCaptura_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown

            Me.SuspendLayout()

            'si se realiza la verificacion de la huella, el sistema mostrara los dedos disponibles
            If _TipoBusqueda = enmTipoBusqueda.Verificacion Then
                mostrarHuellasDisponibles()
                If Me._HabilitarRecaptura = True Then Me.btnRecapturar.Visible = True
            End If

            Me.btnCapturarHuella.Enabled = False

            Iniciar_Dispositivo()
            IniciarCaptura()

            Me.btnSalir.Enabled = True
            blnCargaForm = True

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

        Private Sub pbManoIzq_Click(sender As System.Object, e As System.EventArgs) Handles pbManoIzq.Click

            SeleccionarMano(blnCambiarMano, enmTipoMano.Izquierda)

        End Sub

        Private Sub pbManoDer_Click(sender As System.Object, e As System.EventArgs) Handles pbManoDer.Click

            SeleccionarMano(blnCambiarMano, enmTipoMano.Derecha)

        End Sub

        Private Sub chkHueIzq_Click(sender As Object, e As System.EventArgs) Handles chkHueIzq.Click

            If Me.chkHueIzq.Checked = True Then
                If Me.pbManoIzq.Enabled = True Then Me.pbManoIzq.Image = My.Resources.mano_izquierda
                Me.chkHueIzq.Text = "Indice Izquierdo"
            Else
                If Me.pbManoIzq.Enabled = True Then Me.pbManoIzq.Image = My.Resources.mano_izquierda02
                Me.chkHueIzq.Text = "Pulgar Izquierdo"
            End If

        End Sub

        Private Sub chkHueDer_Click(sender As Object, e As System.EventArgs) Handles chkHueDer.Click

            If Me.chkHueDer.Checked = True Then
                If Me.pbManoDer.Enabled = True Then Me.pbManoDer.Image = My.Resources.mano_derecha
                Me.chkHueDer.Text = "Indice Derecho"
            Else
                If Me.pbManoDer.Enabled = True Then Me.pbManoDer.Image = My.Resources.mano_derecha02
                Me.chkHueDer.Text = "Pulgar Derecho"
            End If

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            WorkerThread.Abort()
            Me.Close()

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            m_hDevice.SetDiodesStatus(DiodesStatus.turn_off, DiodesStatus.turn_off)
            Thread.Sleep(100)
            WorkerThread.Abort()
            Me.Timer1.Stop()

            If Not objDTOHuellaIndice Is Nothing Then

                If objDTOHuellaIndice.HayDatos = True Then

                    Dim objBssAfis As New APPControlHuellaVisita.AfisDemo(_CNBDHuella)
                    Dim intIDTemplateCol As New List(Of Integer)
                    Dim strMensajeError As String = ""
                    Dim intEstado As Short = -1

                    Select Case Me._TipoBusqueda

                        Case enmTipoBusqueda.Verificacion

                            intEstado = objBssAfis.VerificarHuella(APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS10,
                                                                    Me._IDTipoDocumento, Me._NumeroDocumento, Me.TipoDedo,
                                                                    APPControlHuellaVisita.Type.Enumeracion.TipoPlantilla.ANSI378,
                                                                    objDTOHuellaIndice.TemplateAnsi,
                                                                    intIDTemplateCol, strMensajeError)


                        Case enmTipoBusqueda.Identificacion

                            'intEstado = objBssAfis.Identificar(objDTOHuellaIndice.TemplateSuprema, Me.TipoDedo, True, _
                            '                       APPControlHuellaVisita.Type.Enumeracion.enumRSE_NivelSeguridad.RSE_SECURITY_1_TO_100000,
                            '                       intIDTemplateCol, strMensajeError)

                        Case enmTipoBusqueda.IdentificacionPendxSalir

                            intEstado = objBssAfis.Identificar(APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS10,
                                                               Me.TipoDedo, Enumeracion.TipoPlantilla.ANSI378,
                                                               objDTOHuellaIndice.TemplateAnsi, True,
                                                               intIDTemplateCol, _IDTemplateColSinSalida, strMensajeError)

                    End Select

                    If intEstado = 0 Then 'ok
                        'retorna los ids de los templates encontrados
                        Me._ReturnIDTemplateColRpta = intIDTemplateCol
                        Me.DialogResult = Windows.Forms.DialogResult.OK

                    Else

                        Dim strMensaje As String = ""
                        Dim strTitulo As String = ""

                        Select Case Me._TipoBusqueda

                            Case APPControlHuellaVisita.Huellero.FS10.frmIdentificarPopup.enmTipoBusqueda.Verificacion
                                strMensaje = "La Huella capturada del dedo seleccionado, no coincide con los datos. Vuelva ha intentarlo."
                                strTitulo = "Verificacion"

                            Case APPControlHuellaVisita.Huellero.FS10.frmIdentificarPopup.enmTipoBusqueda.IdentificacionPendxSalir
                                strMensaje = "La Huella capturada del dedo seleccionado, no coincide con ninguna huella pendiente por salir."
                                strTitulo = "Identificacion"

                            Case Else
                                strMensaje = "Los datos no coinciden"
                                strTitulo = Me.Text
                        End Select

                        MessageBox.Show(strMensaje, strTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    End If

                End If

            Else
                Me.pbHuella.Image = My.Resources.huella_x
                MessageBox.Show("No se ha registrado la captura de la huella. Vuelva ha intentarlo", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Me.btnAceptar.Enabled = False
            Me.btnCapturarHuella.Enabled = True

            HabilitarRecaptura()

        End Sub

        Private Sub btnRecapturar_Click(sender As System.Object, e As System.EventArgs) Handles btnRecapturar.Click

            If Not WorkerThread Is Nothing Then WorkerThread.Abort()

            Me._RecapturarReturn = True
            Me._ReturnIDTemplateColRpta = New List(Of Integer)

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub btnCapturarHuella_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturarHuella.Click

            Me.SuspendLayout()

            Me.pbHuella.Image = Nothing
            Me.pbLeyendaColor.Image = Nothing
            objDTOHuellaIndice = Nothing

            Me.btnAceptar.Enabled = True
            Me.btnCapturarHuella.Enabled = False

            m_bScanning = False
            m_bCancelOperation = False
            Me.Timer1.Start()
            IniciarCaptura()

            Me.ResumeLayout()

        End Sub

        Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

            If Not objDTOHuellaIndice Is Nothing Then btnAceptar_Click(Nothing, Nothing)

        End Sub

    End Class
End Namespace
