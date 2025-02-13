Imports System.IO
Imports System.Windows.Forms
Imports APPControlHuellaVisita.Type

Public Class uscCaptura
    Private b_DispositivoIniciado As Boolean = False

    Private m_DeviceHandle As Integer

    Private NumIntentoCapturaHuella As Integer = 0

    Private m_byImgData As Byte()
    Private m_byImgRaw As Byte()
    Private m_ImageWidth As Integer
    Private m_ImageHeight As Integer

    Private b_ventana_popup As Boolean = False 'indica si hay una ventana de confirmación abierta

    Private b_capturaValida As Boolean = False

    Private tmp_dir As String = Application.StartupPath & "\tmp\biometria"

    Private enm_TipoDedo As Enumeracion.TipoDedo = Enumeracion.TipoDedo.NoEspecificado
    Private enm_CalidadMinimaHuellaAceptable As Enumeracion.IndiceCalidadHuella = Enumeracion.IndiceCalidadHuella.NoEspecificado  'indica cual sera el indica de calidad minima aceptable para la huella
    Private capturando As Boolean = False

    Public Property _CalidadIndiceHuellaCapturada As Enumeracion.IndiceCalidadHuella = Enumeracion.IndiceCalidadHuella.NoEspecificado
    Public Property _TemplateANSI() As Byte() = Nothing
    Public Property _TemplateSUPREMA() As Byte() = Nothing
    Public Property _WSQ() As Byte() = Nothing
    Public Property _ImagenHuella As Byte() = Nothing
    Private fCallBack As RSRawCaptureCallback
    Public Property _MostrarLeyenda As Boolean
        Get
            Return lblEstado.Visible
        End Get
        Set(value As Boolean)
            lblEstado.Visible = value
        End Set
    End Property

    Public Event _Accion_HuellaCapturada()
#Region "Funciones_publicas"
    Public Sub _ReiniciarDispositivo()
        Try
            RS_StopViewWindow(m_DeviceHandle)
        Catch ex As Exception

        End Try
        Try
            RS_AbortCapture(m_DeviceHandle)
        Catch ex As Exception

        End Try
        Try
            RS_ExitDevice(m_DeviceHandle)
        Catch ex As Exception

        End Try
        b_DispositivoIniciado = False

        Me._IniciarDispositivo()

    End Sub

    ''' <summary>
    ''' Permite iniciar dispositivo de captura, internamente inicia el SDK, luego el dispositivo.
    ''' </summary>
    ''' <param name="liberarMemoriaCaptura">Flag que indica si se debe o no liberar memoria luego de la captura</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function _IniciarDispositivo() As Boolean

        If b_DispositivoIniciado = True Then Return True

        If IniciarSDK() = False Then
            MessageBox.Show("No se pudo inicializar el SDK.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Iniciar_Dispositivo() = False Then
            MessageBox.Show("SDK inicializado pero o se pudo inicializar el dispositivo.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        b_DispositivoIniciado = True

        Try
            Dim result As Integer = RS_SetCaptureMode(m_DeviceHandle, 2, RS_AUTO_SENSITIVITY_NORMAL, True) '2=Flat Single

            If result <> RS_SUCCESS Then
                Me.lblEstado.Text = "No se puede iniciar el modo captura N°1 : " & result
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        If Directory.Exists(tmp_dir) = False Then Directory.CreateDirectory(tmp_dir)

        Return True
    End Function
    Public Sub _FinalizarCaptura()
        If b_DispositivoIniciado = True Then
            Dim intRs As Integer = 0

            Try
                intRs = RS_ExitDevice(m_DeviceHandle)
                'Thread.Sleep(200)
            Catch ex As Exception
                'nada
                Dim s As String
                s = s
            End Try
        End If
    End Sub
    Public Sub _CerrarTodosDispositivos()

        RS_ExitAllDevices()

    End Sub
    Public Sub _FinalizarDispositivo()

        'Dim f1, f2, f3, f4, f5 As Date
        'f1 = Now

        If b_DispositivoIniciado = True Then

            Dim intRs As Integer = 0
            Try

                Me.lblEstado.Visible = True
                Me.lblEstado.Text = "Cargando datos espere..."
                RS_StopViewWindow(m_DeviceHandle)

                RS_AbortCapture(m_DeviceHandle)
                'f3 = Now
                intRs = RS_ExitDevice(m_DeviceHandle)
                'f4 = Now
            Catch ex As Exception
                'nada
                Dim s As String
                s = s
                MessageBox.Show(s)
            End Try

            b_DispositivoIniciado = False
        End If
        'f5 = Now

        'MessageBox.Show("usc: inicio: " & f1 & "f1:" & f2 & "f2:" & f3 & "f3:" & f4 & "f4:" & f5)

    End Sub

    Public Function _IniciarCaptura(TipoDedo As Type.Enumeracion.TipoDedo, CalidadMinimaHuellaAceptable As Type.Enumeracion.IndiceCalidadHuella)
        Me.enm_TipoDedo = TipoDedo
        Me.enm_CalidadMinimaHuellaAceptable = CalidadMinimaHuellaAceptable
        capturando = False
        If Me.b_DispositivoIniciado = False Then
            MessageBox.Show("Debe iniciar el dispositivo de captura de huella.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Me.enm_CalidadMinimaHuellaAceptable = Enumeracion.IndiceCalidadHuella.NoEspecificado Then
            MessageBox.Show("Debe especificar la calidad mínima aceptable para la captura de la huella.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
        If Me.enm_TipoDedo = Enumeracion.TipoDedo.NoEspecificado Then
            MessageBox.Show("Debe especificar el tipo de dedo.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        If Me.b_DispositivoIniciado = False Then
            MessageBox.Show("Debe inicializar el dispositivo y al terminar cerrar el dispositivo.", "Captura dactilar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        VistaPreviaStart()
        Timer1.Stop()

        If IniciarCaptura() = False Then Return False

        Return True
    End Function

#End Region

#Region "Eventos"
    Public Delegate Sub RSRawCaptureCallbackInt(ByVal nDeviceHandle As Integer, ByVal nErrorCode As Integer, ByRef pbyImgData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer)

    Private Sub RawCaptureCallback(ByVal nDeviceHandle As Integer, ByVal nErrorCode As Integer, ByRef pbyImgData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer)
        Dim pbyDummyData As Byte
        capturando = False
        Dim CallBack As RSRawCaptureCallbackInt = New RSRawCaptureCallbackInt(AddressOf RawCaptureCallbackInt)
        Try
            If (nErrorCode = RS_SUCCESS) Then
                ReDim m_byImgData(nWidth * nHeight - 1)
                CopyMemFromPtr(m_byImgData(0), pbyImgData, nWidth * nHeight)
                m_ImageWidth = nWidth
                m_ImageHeight = nHeight

                Dim nom_arch_img = tmp_dir & "\" & Now.ToFileTime.ToString & ".bmp"
                If RS_SaveBitmap(m_byImgData(0), Me.m_ImageWidth, Me.m_ImageHeight, nom_arch_img) = RS_SUCCESS Then
                    ReDim m_byImgRaw(nWidth * nHeight - 1)
                    Array.Copy(m_byImgData, m_byImgRaw, m_byImgRaw.Length)
                    m_byImgData = System.IO.File.ReadAllBytes(nom_arch_img)
                    IO.File.Delete(nom_arch_img)
                End If
                Invoke(CallBack, nDeviceHandle, nErrorCode, pbyImgData, nWidth, nHeight)
            Else
                pbyDummyData = 1
                Try
                    BeginInvoke(CallBack, nDeviceHandle, nErrorCode, pbyDummyData, nWidth, nHeight)
                Catch ex As Exception
                    Dim s As String
                    s = s
                    MessageBox.Show(ex.Message, "EXCEPCION 1")
                End Try
            End If
        Catch ex As Exception
            Dim s As String
            s = s
            MessageBox.Show(ex.Message, "EXCEPCION 2")
        End Try
    End Sub

    Private Sub RawCaptureCallbackInt(ByVal nDeviceHandle As Integer, ByVal nErrorCode As Integer, ByRef pbyImgData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer)
        Try
            Dim strErrMsg As String

            If (nErrorCode = RS_SUCCESS) Then
                If SaveImage() = True Then
                    'ImagenVistaPrevia()
                End If

                If b_capturaValida = True Then
                    Timer1.Stop()
                    CerrarVentana()
                Else
                    Timer1.Start()
                End If
            Else
                strErrMsg = ""
                If RS_GetErrString(nErrorCode, strErrMsg) = RS_SUCCESS Then
                    Me.lblEstado.Text = strErrMsg
                End If
                Exit Sub
            End If
        Catch ex As Exception
            Dim s As String
            s = s
            MessageBox.Show(ex.Message)
        End Try

    End Sub
#End Region

#Region "Funciones_SDK"
    Private Function IniciarSDK() As Boolean
        Try
            'SDKIniciado = False
            Dim numOfDevice As Integer
            Dim result As Integer

            result = RS_InitSDK("", 0, numOfDevice)
            If result <> RS_SUCCESS Then
                Me.lblEstado.Text = "No se puede inicializar el SDK : " & result
                Return False
            End If


            If numOfDevice = 0 Then
                Me.lblEstado.Text = "Dispositivo no detectado"
                Return False
            End If

            Me.lblEstado.Text = "SDK se ha inicializado satisfactoriamente"

            For i = 0 To numOfDevice - 1
                CBDeviceIndex.Items.Add("Device " & i)
            Next i

            If numOfDevice > 0 Then
                CBDeviceIndex.SelectedIndex = 0
                CBDeviceIndex.Enabled = True
            Else
                CBDeviceIndex.Enabled = False
            End If
            'SDKIniciado = True
        Catch ex As Exception
            Dim s As String
            s = s
        End Try

        Return True
    End Function

    Private Function Iniciar_Dispositivo() As Boolean
        Try
            Dim deviceIndex As Integer
            Dim result As Integer


            Me.CBDeviceIndex.Enabled = False
            deviceIndex = Me.CBDeviceIndex.SelectedIndex
            If deviceIndex = -1 Then
                Me.lblEstado.Text = "Dispositivo biométrico no reconocido"
                Return False
            End If
            result = RS_InitDevice(deviceIndex, m_DeviceHandle)

            If result <> RS_SUCCESS Then
                Me.lblEstado.Text = "No se puede inicializar el dispositivo : " & result
                Return False
            End If

        Catch ex As Exception
            Dim s As String
            s = s
        End Try

        Return True
    End Function

    Private Function IniciarCaptura() As Boolean
        Try
            m_ImageWidth = m_ImageHeight = 0
            Dim nRetVal As Integer

            'Dim fCallBack As RSRawCaptureCallback = New RSRawCaptureCallback(AddressOf RawCaptureCallback)
            fCallBack = New RSRawCaptureCallback(AddressOf RawCaptureCallback)

            RS_RegisterCaptureDataCallback(m_DeviceHandle, fCallBack)

            nRetVal = RS_StartCapture(m_DeviceHandle, True, 0)
            If nRetVal = RS_ERR_CAPTURE_IS_RUNNING Then Return True 'si esta encendida el lector no hacer nada

            If nRetVal = RS_ERR_SENSOR_DIRTY Then
                b_ventana_popup = True
                MessageBox.Show("Por favor, limpie la superficie del sensor (lente) de captura dactilar", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                b_ventana_popup = False
                Return False
            End If
            If nRetVal = RS_ERR_FINGER_EXIST Then
                b_ventana_popup = True
                lblEstado.Text = "Por favor, retire el dedo por un momento o limpie el dispositivo biométrico"
                b_ventana_popup = False
                Return False
            End If

            If nRetVal <> RS_SUCCESS Then
                Me.lblEstado.Text = "No se puede iniciar el modo captura " & nRetVal
                Return False
            End If
            capturando = True
        Catch ex As Exception
            Dim s As String
            s = s
        End Try
        Return True
    End Function

    Private Sub VistaPreviaStart()
        Try
            Dim result As Integer
            Dim drawRect As RECT
            Dim ret As Boolean

            ret = GetClientRect(pbHuella.Handle, drawRect)

            result = RS_SetViewWindow2(m_DeviceHandle, Me.pbHuella.Handle, drawRect, False)

            If result <> RS_SUCCESS Then
                Me.lblEstado.Text = "No se puede mostrar la ventana : " & result
                Exit Sub
            End If
        Catch ex As Exception
            Dim s As String
            s = s
        End Try

    End Sub

    Private Sub VistaPreviaStop()

        Dim result As Integer

        result = RS_StopViewWindow(m_DeviceHandle)

        If result <> RS_SUCCESS Then
            Me.lblEstado.Text = "No se puede detener vista previa : " & result
            Exit Sub
        End If
        If capturando Then
            RS_AbortCapture(m_DeviceHandle)
            Do While (capturando)

            Loop
        End If
        If Not Me._ImagenHuella Is Nothing Then
            RaiseEvent _Accion_HuellaCapturada()
        End If
        Me.Visible = False
    End Sub

    Private Sub leerImagenRaw(ByVal nombreArchivo As String)
        Try
            Dim ptrRawImg As Long

            Dim resultado As Integer
            resultado = RSE_ReadImageData(nombreArchivo, ptrRawImg, m_ImageWidth, m_ImageHeight)
            If resultado <> 0 Then
                Return
            End If
            Dim iRawImgSize As Integer
            iRawImgSize = m_ImageWidth * m_ImageHeight
            Dim ptr As IntPtr
            ptr = ptrRawImg
            ReDim m_byImgRaw(iRawImgSize - 1)
            System.Runtime.InteropServices.Marshal.Copy(ptr, m_byImgRaw, 0, iRawImgSize)
            RSE_FreeMemory(ptrRawImg)
        Catch ex As Exception
            Dim s As String
            s = s
        End Try
    End Sub

    Private Function SaveImage() As Boolean
        Dim tmpl As Byte() = Nothing
        Dim wsq As Byte() = Nothing
        Dim value As Boolean = False

        Dim nomTmp As String = Now.ToFileTime.ToString

        NumIntentoCapturaHuella = NumIntentoCapturaHuella + 1

        '----------------------------> artificio local ----------
        Dim intCalidad As Integer

        If RSE_GetQualityScoreMem(m_byImgData, m_byImgData.Length, intCalidad) <> RSE_SUCCESS Then
            lblEstado.Text = "No se puede verificar la calidad de la imagen"
            Return False
        End If

        'lblCalidadCaptura.Text = "CALIDAD CAPTURA: " & intCalidad
        'lblDedo.Text = NombreDedo() & " - Intentos:" & NumIntentoCapturaHuella
        '---------------------------------------------------------

        If NumIntentoCapturaHuella <= 10 And intCalidad > Me.enm_CalidadMinimaHuellaAceptable And intCalidad <> 1 And (Me.enm_TipoDedo = Enumeracion.TipoDedo.IndiceDerecho Or Me.enm_TipoDedo = Enumeracion.TipoDedo.IndiceIzquierdo Or _
                                   Me.enm_TipoDedo = Enumeracion.TipoDedo.PulgarDerecho Or Me.enm_TipoDedo = Enumeracion.TipoDedo.PulgarIzquierdo) Then
            lblEstado.Text = "La calidad " & intCalidad & " de la imagen no es aceptable para el tipo del dedo"
            b_capturaValida = False
            Return False
        End If

        If intCalidad <= Me.enm_CalidadMinimaHuellaAceptable Then
            b_capturaValida = True
            Me._CalidadIndiceHuellaCapturada = intCalidad 'controlHuella._IndiceCalidadImagen = intCalidad
            Me._ImagenHuella = m_byImgData

            tmpl = GenerarPlantillaMem(m_byImgRaw, Me.enm_TipoDedo, Me.m_ImageWidth, Me.m_ImageHeight, Type.Enumeracion.TipoPlantilla.ANSI378)
            If tmpl Is Nothing Then
                lblEstado.Text = "No se pudo generar la plantilla ANSI"
                Me.limpiarHuella()
                b_capturaValida = False
                Return False
            End If

            Me._TemplateANSI = tmpl

            tmpl = GenerarPlantillaMem(m_byImgRaw, Me.enm_TipoDedo, Me.m_ImageWidth, Me.m_ImageHeight, Type.Enumeracion.TipoPlantilla.Suprema)
            If tmpl Is Nothing Then
                Me.limpiarHuella()
                lblEstado.Text = "No se pudo generar la plantilla SUPREMA"
                b_capturaValida = False
                Return False
            End If

            Me._TemplateSUPREMA = tmpl

            wsq = GeneraraWSQMem(Me._ImagenHuella)
            If wsq Is Nothing Then
                Me.limpiarHuella()
                Return False
            End If

            Me._WSQ = wsq
            value = True
        Else
            b_capturaValida = False
            Me.lblEstado.Text = "La calidad de la huella no esta permitida, vuelva ha intentarlo"
        End If
        Return value
    End Function
#End Region
#Region "Accion"
    Private Function GenerarPlantillaMem(ImgRAW As Byte(), TipoDedo As Integer, anchoImgRAW As Integer, altoImgRAW As Integer, ByVal TipoPlantilla As Type.Enumeracion.TipoPlantilla) As Byte()
        Dim Resultado As Integer
        Dim templateBuffer As Long
        Dim bytesTemplate As Byte() = Nothing
        Dim templateLen As Integer
        Try
            Dim value As String = ""

            Try
                Select Case TipoPlantilla
                    Case Type.Enumeracion.TipoPlantilla.Suprema
                        Resultado = RSE_ExtractTemplateEx(ImgRAW, anchoImgRAW, altoImgRAW, TipoDedo, RSE_TEMP_ORIGINAL, templateBuffer, templateLen)
                    Case Type.Enumeracion.TipoPlantilla.ISO19794_2
                        Resultado = RSE_ExtractTemplateEx(ImgRAW, anchoImgRAW, altoImgRAW, TipoDedo, RSE_TEMP_ISO19794_2, templateBuffer, templateLen)
                    Case Type.Enumeracion.TipoPlantilla.ANSI378
                        Resultado = RSE_ExtractTemplateEx(ImgRAW, anchoImgRAW, altoImgRAW, TipoDedo, RSE_TEMP_ANSI378, templateBuffer, templateLen)
                End Select

                If Resultado <> 0 Then
                    Me.lblEstado.Text = "ERROR: " + Resultado.ToString()
                    Return Nothing
                Else
                    Dim ptr As IntPtr
                    ptr = templateBuffer
                    ReDim bytesTemplate(templateLen)
                    System.Runtime.InteropServices.Marshal.Copy(ptr, bytesTemplate, 0, templateLen)
                    'RSE_FreeMemory(templateBuffer)
                End If
            Catch ex As Exception
                Me.lblEstado.Text = "No se pudo generar la plantilla"
                MessageBox.Show(ex.Message + "\r\n" + ex.StackTrace)
                Return Nothing
            End Try
        Catch ex As Exception
            Dim s As String
            s = s
        End Try


        Return bytesTemplate

    End Function

    Private Function GeneraraWSQMem(ByVal ImgHuella As Byte()) As Byte()
        Dim wsq As Byte() = Nothing
        Try
            Dim buffWSQ As Long = 0
            Dim lngWSQ As Integer = 0

            Dim value As String = ""

            Dim Resultado As Integer = 0
            Const ratio As Single = 1

            Dim v As Integer = 0

            v = RSE_CompressWSQMem(ImgHuella, ImgHuella.Length, "", ratio, buffWSQ, lngWSQ)
            If v = RSE_ERR_NO_DEVICE Then
                lblEstado.Text = "Dispositivo biometrico no conectado al equipo"
                Return Nothing
            End If
            If v = RSE_ERR_CANNOT_READ_FILE Then
                lblEstado.Text = "No se puede leer la imagen"
                Return Nothing
            End If
            If v = RSE_ERR_UNSUPPORTED_FILE Then
                lblEstado.Text = "Formato de imagen no soportado"
                Return Nothing
            End If
            If v = RSE_ERR_CANNOT_COMPRESS_WSQ Then
                lblEstado.Text = "No se puede comprimir la imagen"
                Return Nothing
            End If

            Dim ptr As IntPtr
            ptr = buffWSQ
            ReDim wsq(lngWSQ)
            System.Runtime.InteropServices.Marshal.Copy(ptr, wsq, 0, lngWSQ)
            RS_FreeImageData(buffWSQ)
        Catch ex As Exception
            Dim s As String
            s = s
        End Try

        Return wsq
    End Function

#End Region
#Region "Otros"
    Private Sub limpiarHuella()
        Me._ImagenHuella = Nothing
        Me._CalidadIndiceHuellaCapturada = Enumeracion.IndiceCalidadHuella.NoEspecificado
        Me._TemplateANSI = Nothing
        Me._TemplateSUPREMA = Nothing
        Me._WSQ = Nothing

        Me.NumIntentoCapturaHuella = 0
    End Sub

    Private Function NombreDedo() As String

        Dim value As String = ""

        Select Case Me.enm_TipoDedo
            Case Enumeracion.TipoDedo.PulgarDerecho
                value = "Pulgar Derecho"
            Case Enumeracion.TipoDedo.IndiceDerecho
                value = "Indice Derecho"
            Case Enumeracion.TipoDedo.MedioDerecho
                value = "Medio Derecho"
            Case Enumeracion.TipoDedo.AnularDerecho
                value = "Anular Derecho"
            Case Enumeracion.TipoDedo.MeniqueDerecho
                value = "Menique Derecho"
            Case Enumeracion.TipoDedo.PulgarIzquierdo
                value = "Pulgar Izquierdo"
            Case Enumeracion.TipoDedo.IndiceIzquierdo
                value = "Indice Izquierdo"
            Case Enumeracion.TipoDedo.MedioIzquierdo
                value = "Medio Izquierdo"
            Case Enumeracion.TipoDedo.AnularIzquierdo
                value = "Anular Izquierdo"
            Case Enumeracion.TipoDedo.MeniqueIzquierdo
                value = "Menique Izquierdo"
        End Select

        Return value

    End Function

    Public Sub CerrarVentana()
        VistaPreviaStop()
    End Sub
#End Region

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If b_ventana_popup = False Then
            If IniciarCaptura() = False Then
                CerrarVentana()
            End If
            Timer1.Stop()
        End If
    End Sub

    Private Sub uscCaptura_Disposed(sender As Object, e As System.EventArgs) Handles Me.Disposed

    End Sub

    Private Sub uscCaptura_HandleDestroyed(sender As Object, e As System.EventArgs) Handles Me.HandleDestroyed

    End Sub
End Class
