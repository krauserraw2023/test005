Imports Futronic.MathAPIHelper
Imports System.Threading
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports System.IO
Imports APPControlHuellaVisita.Type.Enumeracion
Imports System.Drawing
Imports APPControlHuellaVisita.Business
Imports System.Windows.Forms
Imports APPControlHuellaVisita.Huellero.DLL.FS88H
Imports APPControlHuellaVisita.Lector.Futronic.LoadDll.ScanAPI
Imports APPControlHuellaVisita.Huellero.UI.FS10.frmCapturaHuellaUnico
Imports System.Data.Sql

Namespace Huellero.FS10

    Public Class uscValidarHuellaBasic
        Dim dispositivoAbierto As Boolean = False

        Private Enum OPERATION_MODE
            OM_CAPTURE = 0
            OM_CREATE = 1
            OM_VERIFY = 2
            OM_IDENTIFY = 3
        End Enum

        Private Shared FTR_MATCH_SCORE_VALUE As Integer() = {37, 65, 93, 121, 146, 189}

        Dim m_ImageSize As Huellero.DLL.FS88H.FTRSCAN_IMAGE_SIZE
        Dim m_pImage As Byte() = Nothing
        Dim m_pTemplate As Byte() = Nothing
        Dim m_OperationMode As OPERATION_MODE
        Dim m_bStop As Boolean = False
        Dim m_bExit As Boolean = False
        Dim m_nErrorCode As Integer = 0
        Dim m_nTemplateFormat As Integer = 0
        Dim m_csFolderDb As String = Nothing
        Dim m_byFingerPosition As Byte = 0
        Dim m_fMatchScore As Single = 0
        Dim m_WorkerThread As Thread = Nothing

        Dim _nOutTemplateSize As Integer

        Dim m_TipDispo As Utilidad.enmDispositivoCompatibilidad = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_UNKNOWN_TYPE
        Dim n_indice_huella As Type.Enumeracion.TipoDedo = Type.Enumeracion.TipoDedo.Ninguno

        Dim c_dirPathWSQ As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\wsq\"
        Dim c_dirPathBMP As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\BMP\"
        Dim c_dirPathANSI As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\ansi\"
        Dim c_dirPathISO As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\iso\"

        Dim colorLedOn As Color = Color.FromArgb(0, 192, 0)
        Dim colorLedOff As Color = Color.Gray

        Private threadParams As ThreadParameters
        Dim bCancel As Boolean = False

        Private pPen As Pen = New Pen(Color.Green)
        Private penred As Pen = New Pen(Color.Red)

        Private miFont As Font = New Font("Arial", 18, FontStyle.Italic)
        Private font2 As Font = New Font("Arial", 32, FontStyle.Italic)

        Delegate Sub SetProcesoLedCallback(ledON As Boolean)
        Delegate Sub SetImageCallback()

        Delegate Sub SetUpdateTextCallback(sText As String, xCoord As Integer, yCoord As Integer)
        Delegate Sub SetUpdateTextCallback2(sText As String, xCoord As Integer, yCoord As Integer, miPen As Pen, fuente As Font)
        Delegate Sub SetUpdateTextCalidadHuellaCallback(calidadHuella As Integer)

        Delegate Sub SetDosageCallback(ByVal value As Integer)
        Delegate Sub SetTextCallback(ByVal text As String)

        Delegate Sub HuellaCapturadoCallback()

        Public Event _HuellaCapturado_event()


        Class ThreadParameters
            Public hDevice As Device
            Public height As Integer
            Public width As Integer
            Public imageData As Byte()
            Public continueProcess As Boolean

            Public imageDataSeg As Byte()
            Public imageDataSubf As Byte()
            Public paramSeg As SegmParameters
            Public dataSubf As SubfPointCoord()
            Public bSegmentation As Boolean
            Public dosage As Integer
            Public mode As Integer
            Public autoTh As Integer
            Public indiceCalidad As Integer
        End Class


#Region "metodos_publicas"
        Public Function getTemplateAnsiByte() As Byte()
            Return uscHuellaThumb._TemplateANSI
        End Function

        Public Function getIndiceCalidad() As Integer
            Return uscHuellaThumb._IndiceCalidad
        End Function
        Public Function getImagenHuellaByte() As Byte()
            Return uscHuellaThumb._ImagenHuellaByte()
        End Function
        Public Function getTipoDedoSel() As Integer
            Return uscHuellaThumb._TipoDedo
        End Function
        Public Sub setTipoDedoSel(indTipoDedoIzq As Integer, indTipoDedoDer As Integer)

            If indTipoDedoIzq = 3 Then
                rbMedIzq.Visible = True
                usc_izq_med.Visible = True
                rbMedIzq.Checked = True
            End If
            If indTipoDedoIzq = 4 Then
                rbIndIzq.Visible = True
                usc_izq_ind.Visible = True
                rbIndIzq.Checked = True
            End If
            If indTipoDedoIzq = 5 Then
                rbPulIzq.Visible = True
                usc_izq_pul.Visible = True
                rbPulIzq.Checked = True
            End If

            If indTipoDedoDer = 6 Then
                rbPulDer.Visible = True
                usc_der_pul.Visible = True
            End If
            If indTipoDedoDer = 7 Then
                rbIndDer.Visible = True
                usc_der_ind.Visible = True
            End If
            If indTipoDedoDer = 8 Then
                rbMedDer.Visible = True
                usc_der_med.Visible = True
            End If

        End Sub
#End Region

#Region "CAPTURA"
        Private Sub DoScan(ByVal param As Object)
            Dim threadParam As ThreadParameters = DirectCast(param, ThreadParameters)
            Dim bOk As Boolean = False
            Dim criticalError As Boolean = False
            Dim imageSize As Size

            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 Then
                threadParam.hDevice.EliminateBackground = True
                Me.bCancel = False
                Dim nNfiq As Integer = 0
                Dim er As Boolean = False
                Dim rs As Boolean = False

                While (threadParam.continueProcess And criticalError = False)
                    If Me.bCancel = True Then Exit While

                    bOk = True
                    Try
                        threadParam.imageData = threadParam.hDevice.GetFrame()
                        rs = threadParam.hDevice.MathImageNfIQ(threadParam.imageData, threadParam.width, threadParam.height, nNfiq, bOk)
                        UpdateScreenImage2()

                        If rs = True Then UpdateTextCalidadHuella(nNfiq)

                    Catch ex As FutronicException
                        If ex.ErrorCode = 4306 Then
                            threadParam.imageData = Nothing
                            UpdateScreenImage2()
                            Continue While
                        End If
                        SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
                        'Continue While
                    Catch ex2 As Exception
                        criticalError = True
                    End Try
                End While
                If criticalError Or bCancel Then
                    threadParam.imageData = Nothing
                    UpdateScreenImage2()

                    threadParam.indiceCalidad = 0
                    threadParam.hDevice.Dispose()
                    threadParam.hDevice = Nothing
                    ProcesoLed(False)
                    Exit Sub
                End If
                threadParam.indiceCalidad = nNfiq

                Try
                    savebmp(threadParam)
                    ConvertWSQ(threadParam)
                    ConvertAnsiSDK(threadParam)

                    threadParams.hDevice.Close()
                    threadParam.hDevice.Dispose()
                    threadParam.hDevice = Nothing
                    ProcesoLed(False)

                    'notificar evento terminado

                Catch ex As Exception

                End Try
                NotificarHuellaCapturado()
            Else 'FS60 decadactilar
                Try
                    UpdateBuffer(threadParam.imageData, True)
                    UpdateScreenImage2()

                    threadParam.hDevice.EliminateBackground = True
                    If threadParam.hDevice.Information.DeviceCompatibility = 8 Or threadParam.hDevice.Information.DeviceCompatibility = 15 Then
                        threadParam.hDevice.PreviewMode = False
                        threadParam.hDevice.EliminateBackground = True
                        threadParam.hDevice.PreviewMode = True
                    End If
                Catch ex As FutronicException
                    SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
                    If criticalError Then
                        threadParam.hDevice.Dispose()
                        threadParam.hDevice = Nothing
                        ProcesoLed(False)
                        Exit Sub
                    End If
                End Try

                While (threadParam.continueProcess And criticalError = False)
                    bOk = False

                    Try
                        threadParam.imageDataSeg = threadParam.hDevice.GetFrame(threadParams.dosage)
                        bOk = threadParam.hDevice.MathImageSegmentAuto(threadParam.imageDataSeg, threadParam.width, threadParam.height, threadParam.imageData,
                                      Nothing, threadParam.paramSeg, threadParam.dataSubf, threadParam.bSegmentation, threadParam.autoTh)

                        SetDosageValue(threadParams.dosage)
                        UpdateScreenImage2()

                        If threadParam.dataSubf(0).err = 0 Then UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(0).qfutr))

                    Catch ex As FutronicException
                        SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
                    Catch ex2 As Exception
                        criticalError = True
                    End Try
                End While

                If criticalError Then
                    threadParam.hDevice.Dispose()
                    threadParam.hDevice = Nothing
                    ProcesoLed(False)
                    Exit Sub
                End If

                '''''''''''''''''''''Proceso final para obtener las huellas
                Try
                    UpdateScreenImage2()
                    UpdateText2("Por favor, no quite el dedo!", 20, 40, pPen, miFont)

                    If threadParam.hDevice.Information.DeviceCompatibility = 8 OrElse threadParam.hDevice.Information.DeviceCompatibility = 15 Then
                        threadParam.hDevice.PreviewMode = False
                        imageSize = threadParam.hDevice.ImageSize
                        threadParam.height = imageSize.Height
                        threadParam.width = imageSize.Width
                        Array.Resize(threadParam.imageData, threadParam.height * threadParam.width)
                        Array.Resize(threadParam.imageDataSeg, threadParam.height * threadParam.width)
                    End If

                    threadParam.imageDataSeg = threadParam.hDevice.GetFrame(threadParams.dosage)

                    bOk = threadParam.hDevice.MathImageSegment(threadParam.imageDataSeg, threadParam.width, threadParam.height, threadParam.imageData,
                                                           threadParam.imageDataSubf, threadParam.paramSeg, threadParam.dataSubf, threadParam.bSegmentation)
                    UpdateScreenImage2()

                    If threadParam.dataSubf(0).err = 0 Then UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(0).qfutr))

                Catch ex As Exception
                    threadParams.hDevice.Close()
                    threadParam.hDevice.Dispose()
                    threadParam.hDevice = Nothing
                    ProcesoLed(False)
                    Exit Sub
                End Try

                Try
                    savebmp(threadParam)
                    ConvertWSQ(threadParam)
                    ConvertAnsiSDK(threadParam)

                    threadParams.hDevice.Close()
                    threadParam.hDevice.Dispose()
                    threadParam.hDevice = Nothing
                    ProcesoLed(False)

                Catch ex As Exception
                    Try
                        threadParam.hDevice.Dispose()
                        threadParam.hDevice = Nothing
                        ProcesoLed(False)
                    Catch ex2 As Exception

                    End Try
                End Try
            End If


        End Sub

        Private Sub NotificarHuellaCapturado()
            If Me.InvokeRequired Then
                Me.Invoke(New HuellaCapturadoCallback(AddressOf Me.NotificarHuellaCapturado))
            Else
                RaiseEvent _HuellaCapturado_event()
            End If
        End Sub




        Private Sub SetErrorMessage(message As String)

        End Sub

        Private Sub ProcesoLed(ledON As Boolean)
            If Me.InvokeRequired Then
                Me.Invoke(New SetProcesoLedCallback(AddressOf Me.ProcesoLed), ledON)
            Else
                Led(ledON)
            End If
        End Sub

        Private Sub SetDosageValue(ByVal value As Integer)

            If Me.InvokeRequired Then
                Me.Invoke(New SetDosageCallback(AddressOf SetDosageValue), New Object() {value})
            End If

        End Sub

        Private Shared Sub UpdateBuffer(ByVal data As Byte(), ByVal bparam As Boolean)
            If bparam = True Then
                For i As Integer = 0 To data.Length - 1
                    data(i) = 255
                Next
            Else
                For i As Integer = 0 To data.Length - 1
                    data(i) = 0
                Next
            End If
        End Sub

        Private Sub UpdateScreenImage2()
            If Me.InvokeRequired Then
                Me.Invoke(New SetImageCallback(AddressOf Me.UpdateScreenImage2))
            Else
                Dim picture As Bitmap
                If threadParams.imageData Is Nothing Then
                    picture = Nothing
                Else
                    picture = Device.GetBitmapFromBuffer2(threadParams.imageData, threadParams.height, threadParams.width)
                End If

                DrawImage(picture)
            End If
        End Sub

        Private Sub UpdateText2(sText As String, xCoord As Integer, yCoord As Integer, miPen As Pen, fFuente As Font)
            If Me.InvokeRequired Then
                Me.Invoke(New SetUpdateTextCallback2(AddressOf Me.UpdateText2), New Object() {sText, xCoord, yCoord, miPen, fFuente})
            Else
                Me.UpdateString2(sText, xCoord, yCoord, miPen, fFuente)
            End If
        End Sub

        Private Sub UpdateTextCalidadHuella(calidadHuella As Integer)
            If Me.InvokeRequired Then
                Me.Invoke(New SetUpdateTextCalidadHuellaCallback(AddressOf Me.UpdateTextCalidadHuella), New Object() {calidadHuella})
            Else
                Me.UpdateStringCalidadHuella(calidadHuella)
                If calidadHuella < 3 Then
                    capturarHuella()
                    If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H Then
                        RaiseEvent _HuellaCapturado_event()
                    End If

                End If
            End If
        End Sub

        Private Sub ConvertWSQ(ByVal threadParam As ThreadParameters)
            Dim NomArc As String = ""
            Dim m_hDevice As New ScanAPIHelperFS60.Device
            Dim fBitRate As Double = 0.75
            Dim WSQ_Image As Byte()
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0

            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 And (Me.threadParams.indiceCalidad > 3 Or Me.threadParams.indiceCalidad <= 0) Then
                Exit Sub
            End If

            Try
                m_hDevice.Open()
                NomArc = c_dirPathWSQ
                imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 Then
                    WSQ_Image = m_hDevice.WSQ_FromRawImage(threadParam.imageData, threadParam.width, threadParam.height, fBitRate)
                    Array.Copy(threadParam.imageData, SizeSubf, imagetempSubfBin, 0, threadParam.width * threadParam.height)
                    WSQ_Image = m_hDevice.WSQ_FromRawImage(imagetempSubfBin, threadParam.width, threadParam.height, fBitRate)

                    uscHuellaThumb._AnchoImgPixel = threadParam.width
                    uscHuellaThumb._LargoImgPixel = threadParam.height
                Else 'decadactilar
                    WSQ_Image = m_hDevice.WSQ_FromRawImage(threadParam.imageDataSeg, threadParam.width, threadParam.height, fBitRate)

                    If threadParam.dataSubf(0).err = 0 Then
                        Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs)
                        WSQ_Image = m_hDevice.WSQ_FromRawImage(imagetempSubfBin, threadParam.dataSubf(0).ws, threadParam.dataSubf(0).hs, fBitRate)

                        uscHuellaThumb._AnchoImgPixel = threadParam.dataSubf(0).ws
                        uscHuellaThumb._LargoImgPixel = threadParam.dataSubf(0).hs
                    End If
                End If

                uscHuellaThumb._Wsq = WSQ_Image
                SaveWSQ(NomArc & 0 + 1 & ".wsq", WSQ_Image)
                m_hDevice.Close()
            Catch ex As Exception
                MsgBox("Operación generar WSQ: " & ex.Message)
            End Try
        End Sub

        Sub SaveWSQ(ByVal NomArc As String, ByVal WSQ_Image As Byte())
            Try
                Dim file As New FileStream(NomArc, FileMode.Create)
                file.Write(WSQ_Image, 0, WSQ_Image.Length)
                file.Close()
            Catch ex As Exception

            End Try
        End Sub

        Public Sub UpdateStringCalidadHuella(ByVal calidadHuella As Integer)
            If PBox_PreviewHuellas.Image IsNot Nothing Then
                Try
                    lblCalidad.ForeColor = Color.White
                    Select Case calidadHuella
                        Case 1
                            lblCalidad.BackColor = Color.Green
                        Case 2
                            lblCalidad.BackColor = Color.Blue
                        Case 3
                            lblCalidad.BackColor = Color.Yellow
                            lblCalidad.ForeColor = Color.Black
                        Case Else
                            lblCalidad.BackColor = Color.Red

                    End Select
                    lblCalidad.Text = calidadHuella
                Catch ex As Exception

                End Try
            End If

            If calidadHuella < 3 Then _IniciarCapturaHuella()

        End Sub

        Public Sub UpdateString(ByVal sText As String, ByVal xCoord As Integer, ByVal yCoord As Integer)
            If PBox_PreviewHuellas.Image IsNot Nothing Then
                Try
                    Dim g As Graphics = Graphics.FromImage(PBox_PreviewHuellas.Image)
                    Dim P As New Point(xCoord, yCoord)

                    Using b As New SolidBrush(Color.Red) 'pen.Color)
                        g.DrawString(sText & "XX", Font, b, P)
                    End Using
                    g.Dispose()
                    PBox_PreviewHuellas.Invalidate()
                Catch ex As Exception

                End Try
            End If
        End Sub

        Public Sub UpdateString2(ByVal sText As String, ByVal xCoord As Integer, ByVal yCoord As Integer, ByVal pen_ As Pen, ByVal font_ As Font)
            If PBox_PreviewHuellas.Image IsNot Nothing Then
                Try
                    Dim blueBrush As New SolidBrush(Color.Blue)

                    Dim g As Graphics = Graphics.FromImage(PBox_PreviewHuellas.Image)
                    Dim P As New Point(xCoord, yCoord)

                    Using b As New SolidBrush(pen_.Color)
                        g.DrawString(sText, font_, b, P)
                    End Using

                    g.Dispose()
                    PBox_PreviewHuellas.Invalidate()
                Catch ex As Exception

                End Try
            End If
        End Sub

        Private Shared Function CreateImage(ByVal width As Integer, ByVal heigth As Integer, ByVal buffer As Byte(), ByRef RawImage() As Byte) As Image
            Dim _image As Image
            Dim bmp As New Bitmap(width, heigth, PixelFormat.Format24bppRgb)
            Dim rect As New Rectangle(Point.Empty, bmp.Size)
            Dim bmpData As BitmapData = bmp.LockBits(rect, ImageLockMode.ReadWrite, bmp.PixelFormat)
            Try
                Dim ptr As IntPtr = bmpData.Scan0
                Dim bytes As Integer = bmpData.Stride * bmpData.Height
                Marshal.Copy(buffer, 0, ptr, bytes)

                Dim iRawImgSize As Integer
                iRawImgSize = width * heigth
                ReDim RawImage(iRawImgSize - 1)
                System.Runtime.InteropServices.Marshal.Copy(ptr, RawImage, 0, iRawImgSize)
            Finally
                bmp.UnlockBits(bmpData)
                _image = DirectCast(bmp, Image)
            End Try
            Return _image
        End Function

        Private Sub savebmp(ByVal threadParam As ThreadParameters)
            For Each fichero As String In Directory.GetFiles(c_dirPathBMP, "*.bmp")
                File.Delete(fichero)
            Next

            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 Then 'FS10
                Try
                    If threadParam.indiceCalidad < 4 And threadParam.indiceCalidad > 0 Then
                        Dim myFile As New Wsq2Bmp.UtilidadFutronic.MyBitmapFile(threadParam.width, threadParam.height, threadParam.imageData)

                        uscHuellaThumb._ImagenHuellaByte = myFile.BitmatFileData
                        uscHuellaThumb._IndiceCalidad = threadParam.indiceCalidad

                    End If
                Catch ex As Exception
                    uscHuellaThumb.LimpiarHuella()
                End Try
            Else 'FS60
                Try
                    If True Then
                        Dim Img As Image
                        Dim imagetemp As Byte()
                        Dim imagetempSubf As Byte()
                        Dim imagetempSubfBin As Byte()
                        Dim wmod As Integer
                        Dim SizeSubf As Integer = 0

                        imagetemp = New Byte(threadParam.width * threadParam.height * 3 - 1) {}

                        For j As Integer = 0 To threadParam.width * threadParam.height - 1
                            imagetemp(j * 3) = threadParam.imageDataSeg(j)
                            imagetemp(j * 3 + 1) = threadParam.imageDataSeg(j)

                            imagetemp(j * 3 + 2) = threadParam.imageDataSeg(j)
                        Next

                        imagetempSubf = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) * 3 - 1) {}
                        imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                        If threadParam.dataSubf(0).err = 0 Then
                            wmod = threadParam.dataSubf(0).ws Mod 4
                            Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs)

                            For k As Integer = 0 To threadParam.dataSubf(0).hs - 1
                                For j As Integer = 0 To threadParam.dataSubf(0).ws - 1
                                    imagetempSubf(j * 3 + wmod * k + 3 * threadParam.dataSubf(0).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(0).ws)
                                    imagetempSubf(j * 3 + 1 + wmod * k + 3 * threadParam.dataSubf(0).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(0).ws)
                                    imagetempSubf(j * 3 + 2 + wmod * k + 3 * threadParam.dataSubf(0).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(0).ws)
                                Next
                            Next


                            Dim indCalidad As Integer = 0

                            Img = CreateImage(threadParam.dataSubf(0).ws, threadParam.dataSubf(0).hs, imagetempSubf, Nothing)
                            Dim ar As Byte() = CType((New ImageConverter()).ConvertTo(Img, GetType(Byte())), Byte())
                            indCalidad = threadParam.dataSubf(0).qfutr

                            uscHuellaThumb._ImagenHuellaByte = ar
                            uscHuellaThumb._IndiceCalidad = indCalidad

                        End If

                    End If
                Catch ex As Exception
                    MsgBox("Generación de imagen BMP: " & ex.Message)
                End Try
            End If
        End Sub

        Public Sub DrawImage(ByVal picture As Bitmap)
            If PBox_PreviewHuellas.Image IsNot Nothing Then PBox_PreviewHuellas.Image.Dispose()

            Dim picture2 As Bitmap

            If Not picture Is Nothing Then
                picture2 = New Bitmap(picture.GetThumbnailImage(PBox_PreviewHuellas.Width, PBox_PreviewHuellas.Height, Nothing, IntPtr.Zero))
            Else
                picture2 = picture
            End If

            PBox_PreviewHuellas.Image = picture2
        End Sub

        Sub ConvertAnsiSDK(ByVal threadParam As ThreadParameters)
            Dim h_device As IntPtr
            Dim pnOutTemplateSize As Integer
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0
            Dim val_Ansi As Boolean

            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 Then
                Try
                    h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

                    imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                    Array.Copy(threadParam.imageData, SizeSubf, imagetempSubfBin, 0, threadParam.width * threadParam.height)
                    Dim m_pImage_ANSI As Byte()
                    m_pImage_ANSI = New Byte(threadParam.width * threadParam.height) {}

                    'OBTENER ANSI DESDE BUFFER
                    val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.width, threadParam.height, m_pImage_ANSI, pnOutTemplateSize)

                    Dim path As String = ""
                    path = c_dirPathANSI & 0 + 1 & ".ansi"
                    Dim file As New FileStream(path, FileMode.Create)
                    file.Write(m_pImage_ANSI, 0, pnOutTemplateSize)
                    file.Close()

                    uscHuellaThumb._TemplateANSI = IO.File.ReadAllBytes(path)

                    Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)
                Catch ex As Exception

                End Try
            Else
                Try
                    h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

                    imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}

                    If threadParam.dataSubf(0).err = 0 Then
                        Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs)

                        Dim m_pImage_ANSI As Byte() = New Byte(threadParam.dataSubf(0).ws * threadParam.dataSubf(0).hs) {}

                        'OBTENER ANSI DESDE BUFFER
                        val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.dataSubf(0).ws, threadParam.dataSubf(0).hs, m_pImage_ANSI, pnOutTemplateSize)

                        Dim path As String = c_dirPathANSI & 0 + 1 & ".ansi"
                        Dim file As New FileStream(path, FileMode.Create)
                        file.Write(m_pImage_ANSI, 0, pnOutTemplateSize)
                        file.Close()
                        SizeSubf = SizeSubf + threadParam.dataSubf(0).hs * threadParam.dataSubf(0).ws

                        uscHuellaThumb._TemplateANSI = IO.File.ReadAllBytes(path)
                    End If

                    Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)
                Catch ex As Exception
                    MsgBox("Generación de template ANSI: " & ex.Message)
                End Try
            End If


        End Sub

#End Region

#Region "Otros"

        Private Sub Led(Encender As Boolean)
            Dim hDevice As New Device()
            Try
                hDevice.Open()
                Dim param1 As UInteger = &H0
                Dim param2 As UInteger = &H0

                If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60 Then
                    hDevice.ControlPin3(&H100000, 0, 250) 'beep del dispositivo
                    Thread.Sleep(100) 'medio segundo
                    hDevice.ControlPin3(0, param2, 250)
                End If

                uscHuellaThumb.chkHuellaNoDisponible.Checked = False

                Select Case Me.n_indice_huella
                    Case TipoDedo.MeniqueIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H1 : usc_izq_men.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H2 : usc_izq_men.BackColor = Me.colorLedOn
                    Case TipoDedo.AnularIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H4 : usc_izq_anu.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H8 : usc_izq_anu.BackColor = Me.colorLedOn
                    Case TipoDedo.MedioIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H10 : usc_izq_med.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H20 : usc_izq_med.BackColor = Me.colorLedOn
                    Case TipoDedo.IndiceIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H40 : usc_izq_ind.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H80 : usc_izq_ind.BackColor = Me.colorLedOn

                    Case TipoDedo.IndiceDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H1000 : usc_der_ind.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H2000 : usc_der_ind.BackColor = Me.colorLedOn
                    Case TipoDedo.MedioDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H4000 : usc_der_med.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H8000 : usc_der_med.BackColor = Me.colorLedOn
                    Case TipoDedo.AnularDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H10000 : usc_der_anu.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H20000 : usc_der_anu.BackColor = Me.colorLedOn
                    Case TipoDedo.MeniqueDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H40000 : usc_der_men.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H80000 : usc_der_men.BackColor = Me.colorLedOn
                    Case TipoDedo.PulgarIzquierdo
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H100 : usc_izq_pul.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H200 : usc_izq_pul.BackColor = Me.colorLedOn
                    Case TipoDedo.PulgarDerecho
                        If uscHuellaThumb._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H400 : usc_der_pul.BackColor = Color.Red
                        If uscHuellaThumb._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H800 : usc_der_pul.BackColor = Me.colorLedOn
                End Select

                If Encender = False Then
                    param1 = 0
                    btnCapturar.Text = "Iniciar"
                    Try
                        threadParams.continueProcess = False
                    Catch ex2 As Exception
                    End Try
                    EstadoCheckDedos(False)
                End If

                If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60 Then hDevice.ControlPin3(param1, param2, 250)

                hDevice.Close()
            Catch ex As Exception
                Try
                    hDevice.Close()
                    hDevice = Nothing
                Catch ex2 As Exception
                    hDevice = Nothing
                End Try
            End Try
        End Sub

        Private Function ConectarDispositivo() As Boolean
            ProcesoLed(True)
            Dim imageSize As Size
            Dim workingThread As Thread

            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10 Then
                Try
                    threadParams = New ThreadParameters
                    threadParams.hDevice = New Device()
                    threadParams.hDevice.Open()          ' Abrimos la conexion
                    If threadParams.hDevice.IsFingerPresent Then
                        Dim c As Integer = 0
                        While threadParams.hDevice.IsFingerPresent
                            MsgBox("Por favor, retire el dedo del cristal o limpie el equipo biométrico.", MsgBoxStyle.Information)
                            c = c + 1
                            If c > 5 Then 'si no se soluciona en el 6to intento se sale
                                Try
                                    threadParams.hDevice.Close()
                                    threadParams.hDevice.Dispose()
                                    ProcesoLed(False)
                                    Return False
                                Catch ex As Exception
                                    Return False
                                End Try
                            End If
                        End While
                    End If

                    threadParams.continueProcess = True

                    workingThread = New Thread(New ParameterizedThreadStart(AddressOf DoScan))

                    threadParams.hDevice.InvertImage = True

                    imageSize = threadParams.hDevice.ImageSize
                    threadParams.height = imageSize.Height
                    threadParams.width = imageSize.Width

                    threadParams.imageData = New Byte(threadParams.height * threadParams.width - 1) {}

                    workingThread.Start(threadParams)
                    btnCapturar.Text = "Capturar"
                Catch ex As FutronicException
                    Dim vv As Boolean
                    SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, vv))
                    If vv = True Then
                        threadParams.hDevice = Nothing
                        threadParams = Nothing
                    End If
                    Return False
                End Try
                Return True
            Else 'FS60 decadactilar
                Try
                    threadParams = New ThreadParameters()
                    threadParams.hDevice = New Device()
                    threadParams.hDevice.Open()
                    If threadParams.hDevice.IsFingerPresent Then
                        Dim c As Integer = 0
                        While threadParams.hDevice.IsFingerPresent
                            MsgBox("Por favor, retire el dedo del cristal o limpie el equipo biométrico.", MsgBoxStyle.Information)
                            c = c + 1
                            If c > 5 Then 'si no se soluciona en el 6to intento se sale
                                Try
                                    threadParams.hDevice.Close()
                                    threadParams.hDevice.Dispose()
                                    ProcesoLed(False)
                                    Return False
                                Catch ex As Exception
                                    Return False
                                End Try
                            End If
                        End While
                    End If

                    threadParams.continueProcess = True

                    workingThread = New Thread(New ParameterizedThreadStart(AddressOf DoScan))

                    threadParams.hDevice.InvertImage = True
                    threadParams.hDevice.PreviewMode = True

                    imageSize = threadParams.hDevice.ImageSize
                    threadParams.height = imageSize.Height
                    threadParams.width = imageSize.Width

                    threadParams.hDevice.ImageFormat = 1
                    threadParams.mode = 1

                    threadParams.imageDataSeg = New Byte(threadParams.height * threadParams.width - 1) {}

                    threadParams.paramSeg.nParamAngle = SegmAdjustment.noangle
                    threadParams.paramSeg.nWidthSubf = MathNums.xsize
                    threadParams.paramSeg.nHeightSubf = MathNums.ysize

                    threadParams.paramSeg.nParamFing = SegmAdjustment.nfing1

                    threadParams.paramSeg.nParamNfiq = SegmAdjustment.qfutr

                    threadParams.paramSeg.nParamFixedSize = SegmAdjustment.fixedsize


                    threadParams.imageDataSubf = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) * threadParams.paramSeg.nParamFing - 1) {}
                    threadParams.dataSubf = New SubfPointCoord(threadParams.paramSeg.nParamFing - 1) {}

                    threadParams.imageData = New Byte(threadParams.height * threadParams.width) {}

                    workingThread.Start(threadParams)
                    btnCapturar.Text = "Capturar"
                Catch ex As FutronicException
                    Dim vv As Boolean
                    SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, vv))
                    If vv = True Then
                        threadParams.hDevice = Nothing
                        threadParams = Nothing
                        ProcesoLed(False)
                        Return False
                    End If
                End Try
                Return True
            End If

        End Function
        Private Sub EstadoCheckDedos(bloquear As Boolean)
            rbMenIzq.Enabled = Not bloquear
            rbAnuIzq.Enabled = Not bloquear
            rbMedIzq.Enabled = Not bloquear
            rbIndIzq.Enabled = Not bloquear
            rbPulIzq.Enabled = Not bloquear
            rbPulDer.Enabled = Not bloquear
            rbIndDer.Enabled = Not bloquear
            rbMedDer.Enabled = Not bloquear
            rbAnuDer.Enabled = Not bloquear
            rbMenDer.Enabled = Not bloquear
        End Sub

        Private Sub uscValidarHuellaBasic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            If System.IO.Directory.Exists(c_dirPathANSI) = False Then System.IO.Directory.CreateDirectory(c_dirPathANSI)
            If System.IO.Directory.Exists(c_dirPathBMP) = False Then System.IO.Directory.CreateDirectory(c_dirPathBMP)
            If System.IO.Directory.Exists(c_dirPathWSQ) = False Then System.IO.Directory.CreateDirectory(c_dirPathWSQ)
            If System.IO.Directory.Exists(c_dirPathISO) = False Then System.IO.Directory.CreateDirectory(c_dirPathISO)
        End Sub

        Private Sub btnCapturar_Click(sender As Object, e As EventArgs) Handles btnCapturar.Click
            _IniciarCapturaHuella()
        End Sub

        Private Sub capturarHuella()
            btnCapturar.Text = "Iniciar"

            If Not threadParams Is Nothing Then threadParams.continueProcess = False
            EstadoCheckDedos(False)

        End Sub
#End Region


        Public Sub _IniciarCapturaHuella()
            usc_izq_men.BackColor = Color.Gray
            usc_izq_anu.BackColor = Color.Gray
            usc_izq_med.BackColor = Color.Gray
            usc_izq_ind.BackColor = Color.Gray
            usc_izq_pul.BackColor = Color.Gray

            usc_der_pul.BackColor = Color.Gray
            usc_der_ind.BackColor = Color.Gray
            usc_der_med.BackColor = Color.Gray
            usc_der_anu.BackColor = Color.Gray
            usc_der_men.BackColor = Color.Gray


            Dim b As Boolean = False
            If dispositivoAbierto = False Then
                While b = False
                    Try
                        Dim hDevice As New Device()
                        hDevice.Open()
                        Me.m_TipDispo = hDevice.Information.DeviceCompatibility
                        hDevice.Close()
                        b = True
                        dispositivoAbierto = True
                    Catch ex As Exception
                    End Try
                    If b = False AndAlso MsgBox("Dispositivo biométrico no conectado, por favor conecte en el puerto USB y click en Aceptar", MsgBoxStyle.OkCancel + MsgBoxStyle.Question) = MsgBoxResult.Cancel Then
                        Exit Sub
                    End If
                End While
            End If



            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H Then

                If btnCapturar.Text = "Iniciar" Then
                    m_pTemplate = New Byte(ftrNativeLib.ftrAnsiSdkGetMaxTemplateSize() - 1) {}

                    StartThread(OPERATION_MODE.OM_CAPTURE)

                    uscHuellaThumb.LimpiarHuella()

                    If rbMenIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MeniqueIzquierdo
                    If rbAnuIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.AnularIzquierdo
                    If rbMedIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MedioIzquierdo
                    If rbIndIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.IndiceIzquierdo
                    If rbPulIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.PulgarIzquierdo

                    If rbPulDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.PulgarDerecho
                    If rbIndDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.IndiceDerecho
                    If rbMedDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MedioDerecho
                    If rbAnuDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.AnularDerecho
                    If rbMenDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MeniqueDerecho
                    Me.n_indice_huella = uscHuellaThumb._TipoDedo
                    btnCapturar.Text = "Capturar"
                Else 'capturar huella
                    m_bStop = True
                    btnCapturar.Text = "Iniciar"

                    EstadoCheckDedos(False)

                    SaveTemplateToFile(m_pTemplate, _nOutTemplateSize)
                End If

            Else

                'lblMessage.Text = ""
                If btnCapturar.Text = "Iniciar" Then
                    uscHuellaThumb.LimpiarHuella()

                    If rbMenIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MeniqueIzquierdo
                    If rbAnuIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.AnularIzquierdo
                    If rbMedIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MedioIzquierdo
                    If rbIndIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.IndiceIzquierdo
                    If rbPulIzq.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.PulgarIzquierdo

                    If rbPulDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.PulgarDerecho
                    If rbIndDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.IndiceDerecho
                    If rbMedDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MedioDerecho
                    If rbAnuDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.AnularDerecho
                    If rbMenDer.Checked Then uscHuellaThumb._TipoDedo = TipoDedo.MeniqueDerecho
                    Me.n_indice_huella = uscHuellaThumb._TipoDedo
                    btnCapturar.Text = "Capturar"
                    'btnAbortarCap.Enabled = True
                    If ConectarDispositivo() Then
                        EstadoCheckDedos(True)
                    End If
                Else
                    capturarHuella()
                End If

            End If



        End Sub

        Public Sub _CancelarCapturaHuella()

            If Me.m_TipDispo = Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H Then
                m_bExit = True
                m_bStop = True

                StartThread(OPERATION_MODE.OM_CREATE)

                If m_WorkerThread IsNot Nothing Then
                    m_WorkerThread.Abort()
                    m_WorkerThread.Join()
                End If
            Else
                If Not threadParams Is Nothing AndAlso Not threadParams.hDevice Is Nothing Then
                    Me.bCancel = True
                    Try
                        threadParams.hDevice.AbortRoll(False)
                    Catch ex As FutronicException
                    Catch ex2 As Exception

                    End Try
                    threadParams.continueProcess = False
                Else
                    btnCapturar.Enabled = True
                End If
            End If

            btnCapturar.Text = "Iniciar"
        End Sub

        Public Function _CompararHuella(huellaUsuarioDesdeBD As Byte()) As Boolean
            Dim entTmpl As APPControlHuellaVisita.Entity.Ent_HuellaTemplate
            Dim codError As Integer = 0
            Dim rpta As Integer = 0


            Try
                Dim bssSys As New APPControlHuellaVisita.Business.SysBiometria("")

                Dim sms As String = ""

                rpta = bssSys.compararTemplateAnsi_futronic(huellaUsuarioDesdeBD, uscHuellaThumb._TemplateANSI, APPControlHuellaVisita.Type.Enumeracion.enumNivelSeguridadFAR.MATCH_SCORE_HIGH_MEDIUM, sms)

                Select Case rpta
                    Case 1 'match
                        Return True
                    Case Is < 0
                        MessageBox.Show("Ocurrió un error interno, " & sms & ", intente nuevamente.", "Alerta..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Case Else 'no match

                End Select

            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Alerta..", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try

            Return False
        End Function

        Public Function _TieneHuellaCapturada() As Boolean
            Return IIf(uscHuellaThumb._TemplateANSI Is Nothing, False, True)
        End Function
        Public Function _getTipoDedoSelectMano() As Integer
            Dim i As Integer = 0
            If rbMenIzq.Checked Then i = 1
            If rbAnuIzq.Checked Then i = 2
            If rbMedIzq.Checked Then i = 3
            If rbIndIzq.Checked Then i = 4
            If rbPulIzq.Checked Then i = 5

            If rbPulDer.Checked Then i = 6
            If rbIndDer.Checked Then i = 7
            If rbMedDer.Checked Then i = 8
            If rbAnuDer.Checked Then i = 9
            If rbMenDer.Checked Then i = 10
            Return i
        End Function



#Region "--------------------------- lector FS88H --------------------"
        Private Sub StartThread(ByVal om As OPERATION_MODE)
            'EnableControls(False)
            m_OperationMode = om
            m_WorkerThread = New Thread(New ThreadStart(AddressOf ReadThreadProc))
            m_WorkerThread.SetApartmentState(ApartmentState.STA)
            m_WorkerThread.Start()
        End Sub
        Private Sub ReadThreadProc()
            m_bStop = False
            Dim hDevice As IntPtr = OpenDevice()

            While Not m_bStop
                ftrNativeLib.ftrScanSetOptions(hDevice, 64, 64)
                ftrNativeLib.ftrScanSetDiodesStatus(hDevice, Byte.MaxValue, 0)
                DoScanFS88H(hDevice)
            End While
            ftrNativeLib.ftrScanSetDiodesStatus(hDevice, 0, 0)
            ftrNativeLib.ftrScanCloseDevice(hDevice)
            hDevice = IntPtr.Zero
            'EnableControls(True)
        End Sub
        Private Sub ReadThreadProcORIGINAL()
            m_bStop = False
            While Not m_bStop
                Dim hDevice As IntPtr = OpenDevice()
                If hDevice <> IntPtr.Zero Then
                    DoScanFS88H(hDevice)
                    ftrNativeLib.ftrScanCloseDevice(hDevice)
                    hDevice = IntPtr.Zero
                End If
            End While
        End Sub

        Private Function OpenDevice() As IntPtr
            Dim hDevice As IntPtr = ftrNativeLib.ftrScanOpenDevice()

            If hDevice = IntPtr.Zero Then Return IntPtr.Zero

            m_ImageSize = New FTRSCAN_IMAGE_SIZE()

            If Not ftrNativeLib.ftrScanGetImageSize(hDevice, m_ImageSize) Then
                ftrNativeLib.ftrScanCloseDevice(hDevice)
                Return IntPtr.Zero
            End If

            m_pImage = New Byte(m_ImageSize.nImageSize - 1) {}
            Return hDevice
        End Function

        Private Function DoScanFS88H(ByVal hDevice As IntPtr) As Boolean
            Dim nStart As Integer = 0

            Dim bRC As Boolean = False

            Select Case m_OperationMode
                Case OPERATION_MODE.OM_CAPTURE

                    'bRC = ftrNativeLib.ftrAnsiSdkCaptureImage(hDevice, m_pImage)
                    'bRC = ftrNativeLib.ftrScanGetImage2(hDevice, 6, m_pImage)
                    'bRC = ftrNativeLib.ftrScanGetDarkImage(hDevice, m_pImage)

                    nStart = Environment.TickCount
                    bRC = ftrNativeLib.ftrAnsiSdkCreateTemplate(hDevice, m_byFingerPosition, m_pImage, m_pTemplate, _nOutTemplateSize)

                    If Not bRC Then m_nErrorCode = Marshal.GetLastWin32Error()
                    Exit Select
                Case OPERATION_MODE.OM_CREATE
                    Dim nOutTemplateSize As Integer = 0
                    nStart = Environment.TickCount
                    bRC = ftrNativeLib.ftrAnsiSdkCreateTemplate(hDevice, m_byFingerPosition, m_pImage, m_pTemplate, nOutTemplateSize)

                    If Not bRC Then
                        m_nErrorCode = Marshal.GetLastWin32Error()
                    Else
                        SaveTemplateToFile(m_pTemplate, nOutTemplateSize)
                        m_bStop = True
                    End If

                    Exit Select
                Case Else
            End Select


            If m_pImage IsNot Nothing Then
                Dim myFile As MyBitmapFile = New MyBitmapFile(m_ImageSize.nWidth, m_ImageSize.nHeight, m_pImage)
                Dim BmpStream As MemoryStream = New MemoryStream(myFile.BitmatFileData)
                Dim Bmp As Bitmap = New Bitmap(BmpStream)
                PBox_PreviewHuellas.Image = Bmp

                Dim nNfiq As Integer = 3
                Dim bOk As Boolean = False
                Dim m As Futronic.MathAPIHelper.Device = New Futronic.MathAPIHelper.Device
                m.Open()
                Dim xx As Boolean = m.MathImageNfIQ(m_pImage, m_ImageSize.nWidth, m_ImageSize.nHeight, nNfiq, bOk)
                m.Close()

                UpdateTextCalidadHuella(nNfiq)

            Else
                PBox_PreviewHuellas.Image = Nothing
            End If

            Return bRC
        End Function


        Private Sub SaveTemplateToFile(ByVal template As Byte(), ByVal size As Integer)
            uscHuellaThumb._TemplateANSI = template
        End Sub

#End Region
    End Class
End Namespace