Imports System.Threading
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
Imports Futronic.MathAPIHelper
Imports APPControlHuellaVisita.Type.Enumeracion
Imports System.Drawing

Public Class frmCapturaDeca
    Dim c_dirPathWSQ As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\wsq\"
    Dim c_dirPathBMP As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\BMP\"
    Dim c_dirPathANSI As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\ansi\"
    Dim c_dirPathISO As String = My.Application.Info.DirectoryPath & "\tmp\tmp_bmt\iso\"

    Dim nNumBloqueCaptura As Integer = 1
    Dim nNumSegmentos As Integer = 4 'por defecto 4 huellas

    Dim nCountTime As Integer = 0
    Dim bCountTimeON As Boolean = False

    Dim colorLedOn As Color = Color.FromArgb(0, 192, 0)
    Dim colorLedOff As Color = Color.Gray

    Private threadParams As ThreadParameters
    Dim workingThread As Thread

    Dim lstUscHuellaActivaB1 As List(Of uscThumbFinger) 'huellas activas del bloque1
    Dim lstUscHuellaActivaB2 As List(Of uscThumbFinger)
    Dim lstUscHuellaActivaB3 As List(Of uscThumbFinger)

    Dim lstIconoDedos As New List(Of uscIconFinger)

    Private pen As Pen = New Pen(Color.Green)
    Private miFont As Font = New Font("Arial", 30, FontStyle.Italic)

    Delegate Sub SetProcesoLedCallback(ledON As Boolean)

    Delegate Sub SetImageCallback()
    Delegate Sub SetDosageCallback(ByVal value As Integer)
    Delegate Sub SetTextCallback(ByVal text As String)
    Delegate Sub SetUpdateTextCalidadHuellaCallback(calidadHuella As Integer, xCoord As Integer, yCoord As Integer)

    Class ThreadParameters
        Public hDevice As Device
        Public height As Integer
        Public width As Integer
        Public imageData As Byte()
        Public continueProcess As Boolean

        Public cancelarProceso As Boolean

        Public imageDataSeg As Byte()
        Public imageDataSubf As Byte()
        Public paramSeg As SegmParameters
        Public dataSubf As SubfPointCoord()
        Public bSegmentation As Boolean
        Public dosage As Integer
        Public mode As Integer
        Public autoTh As Integer
    End Class

#Region "Propiedades publicas"
    Public Property _RegId As Integer = -1
    Public Property _PenId As Integer = -1
    Public Property _UsuarioId As Integer = -1
    Public Property _CnBdHuella As String = ""
    Public Property _TipDocIdentId As Integer = -1
    Public Property _NumDocIdent As String = ""
    Public Property _CodRP As String = ""
    Public Property _ApePat As String = ""
    Public Property _ApeMat As String = ""
    Public Property _Nombres As String = ""

    Public ReadOnly Property _outListaTemplateId As Dictionary(Of Integer, Integer)
        Get
            Return lstListTemplateIds
        End Get
    End Property

    Private lstListTemplateIds As New Dictionary(Of Integer, Integer)
#End Region
#Region "CAPTURA"


    Private Sub DoScan(ByVal param As Object)
        Dim threadParam As ThreadParameters = DirectCast(param, ThreadParameters)
        Dim bOk As Boolean = False
        Dim criticalError As Boolean = False
        Dim imageSize As Size

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

        While (threadParam.continueProcess And threadParam.cancelarProceso = False And criticalError = False)
            bOk = False

            Try
                threadParam.paramSeg.nParamNfiq = CInt(SegmAdjustment.qfutr)
                bOk = threadParam.hDevice.MathFrameSegmentPreviewAuto(threadParams.dosage, threadParam.imageDataSeg, threadParam.imageData, Nothing, _
                                                                    threadParam.paramSeg, threadParam.dataSubf, threadParam.bSegmentation, threadParam.autoTh)
                SetDosageValue(threadParams.dosage)

                UpdateScreenImage2()

                For i As Integer = 0 To threadParam.paramSeg.nParamFing - 1
                    If threadParam.dataSubf(i).err = 0 Then
                        UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(i).qfutr), threadParam.dataSubf(i).xs - threadParam.dataSubf(i).ws / 2, threadParam.dataSubf(i).ys - threadParam.dataSubf(i).hs / 2)
                    End If
                Next
            Catch ex As FutronicException
                SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, criticalError))
            Catch ex2 As Exception
                criticalError = True
            End Try
        End While

        If threadParam.cancelarProceso = True Then
            ProcesoLed(False)
            threadParams.hDevice.Close()
            Exit Sub
        End If


        '''''''''''''''''''''Proceso final para obtener las huellas
        Try
            UpdateScreenImage2()
            'UpdateText2("Por favor, no quite el dedo!", 20, 40, pPen, miFont)

            If threadParam.hDevice.Information.DeviceCompatibility = 8 OrElse threadParam.hDevice.Information.DeviceCompatibility = 15 Then
                threadParam.hDevice.PreviewMode = False
                imageSize = threadParam.hDevice.ImageSize
                threadParam.height = imageSize.Height
                threadParam.width = imageSize.Width
                Array.Resize(threadParam.imageData, threadParam.height * threadParam.width)
                Array.Resize(threadParam.imageDataSeg, threadParam.height * threadParam.width)
            End If

            threadParam.imageDataSeg = threadParam.hDevice.GetFrame(threadParams.dosage)

            bOk = threadParam.hDevice.MathImageSegment(threadParam.imageDataSeg, threadParam.width, threadParam.height, threadParam.imageData, _
                                                       threadParam.imageDataSubf, threadParam.paramSeg, threadParam.dataSubf, threadParam.bSegmentation)

            UpdateScreenImage2()

            For i As Integer = 0 To threadParam.paramSeg.nParamFing - 1
                If threadParam.dataSubf(i).err = 0 Then
                    UpdateTextCalidadHuella(Convert.ToString(threadParam.dataSubf(i).qfutr), threadParam.dataSubf(i).xs - threadParam.dataSubf(i).ws / 2, threadParam.dataSubf(i).ys - threadParam.dataSubf(i).hs / 2)
                End If
            Next
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
            'ConvertISOSDK(threadParam)

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
    End Sub

    Private Sub SetErrorMessage(message As String)
        If Me.lblMessage.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf Me.SetErrorMessage)
            Me.Invoke(d, message)
        Else
            lblMessage.Text = message
        End If
    End Sub

    Private Sub ProcesoLed(ledON As Boolean)
        If Me.InvokeRequired Then
            Dim d As New SetProcesoLedCallback(AddressOf Me.ProcesoLed)
            Me.Invoke(d, ledON)
        Else
            Led(ledON)
        End If
    End Sub


    Private Sub SetDosageValue(ByVal value As Integer)
        If Me.InvokeRequired Then
            Dim d As New SetDosageCallback(AddressOf SetDosageValue)
            Me.Invoke(d, New Object() {value})
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
            Dim d As New SetImageCallback(AddressOf Me.UpdateScreenImage2)
            Me.Invoke(d)
        Else
            Dim picture As Bitmap = Device.GetBitmapFromBuffer2(threadParams.imageData, threadParams.height, threadParams.width)
            DrawImage(picture)
        End If
    End Sub

    Public Sub UpdateString(ByVal sText As String, ByVal xCoord As Integer, ByVal yCoord As Integer)
        If PBox_Huellas.Image IsNot Nothing Then
            Dim g As Graphics = Graphics.FromImage(PBox_Huellas.Image)
            Dim P As New Point(xCoord, yCoord)

            Using b As New SolidBrush(Color.Red) 'pen.Color)
                g.DrawString(sText, Font, b, P)
            End Using
            g.Dispose()
            PBox_Huellas.Invalidate()
        End If
    End Sub

    Public Sub UpdateString2(ByVal sText As String, ByVal xCoord As Integer, ByVal yCoord As Integer, ByVal pen_ As Pen, ByVal font_ As Font)
        If PBox_Huellas.Image IsNot Nothing Then
            Try
                Dim g As Graphics = Graphics.FromImage(PBox_Huellas.Image)
                Dim P As New Point(xCoord, yCoord)

                Using b As New SolidBrush(Color.Green) 'pen_.Color)
                    g.DrawString(sText, font_, b, P)
                End Using
                g.Dispose()
                PBox_Huellas.Invalidate()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub UpdateTextCalidadHuella(calidadHuella As Integer, xCoord As Integer, yCoord As Integer)
        If Me.InvokeRequired Then
            Dim d As New SetUpdateTextCalidadHuellaCallback(AddressOf Me.UpdateTextCalidadHuella)
            Me.Invoke(d, New Object() {calidadHuella, xCoord, yCoord})
        Else
            Me.UpdateStringCalidadHuella(calidadHuella, xCoord, yCoord)
        End If
    End Sub

    Public Sub UpdateStringCalidadHuella(ByVal calidadHuella As Integer, ByVal xCoord As Integer, ByVal yCoord As Integer)
        If PBox_Huellas.Image IsNot Nothing Then
            Try
                Dim fondoNfqBrush As New SolidBrush(Color.Blue)

                Dim b As New SolidBrush(Color.White)

                Dim g As Graphics = Graphics.FromImage(PBox_Huellas.Image)
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

                g.FillEllipse(fondoNfqBrush, xCoord, yCoord, 40, 50)
                g.DrawEllipse(New Pen(Color.FromArgb(20, 20, 20), 1), xCoord, yCoord, 40, 50)
                g.DrawString(calidadHuella, miFont, b, Ptxt)
                fondoNfqBrush.Dispose()

                b.Dispose()
                g.Dispose()
                PBox_Huellas.Invalidate()
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

                For Each fichero As String In Directory.GetFiles(c_dirPathBMP, "*.bmp")
                    File.Delete(fichero)
                Next

                Img = CreateImage(threadParam.width, threadParam.height, imagetemp, Nothing)
                Img.Save(c_dirPathBMP & "FP.bmp", System.Drawing.Imaging.ImageFormat.Bmp)

                If nNumBloqueCaptura = 1 Then pbBloque1.Image = Img
                If nNumBloqueCaptura = 2 Then pbBloque2.Image = Img
                If nNumBloqueCaptura = 3 Then pbBloque3.Image = Img

                For i As Integer = 0 To threadParams.paramSeg.nParamFing - 1
                    If threadParam.dataSubf(i).err = 0 Then
                        wmod = threadParam.dataSubf(i).ws Mod 4
                        Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs)

                        For k As Integer = 0 To threadParam.dataSubf(i).hs - 1
                            For j As Integer = 0 To threadParam.dataSubf(i).ws - 1
                                imagetempSubf(j * 3 + wmod * k + 3 * threadParam.dataSubf(i).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(i).ws)
                                imagetempSubf(j * 3 + 1 + wmod * k + 3 * threadParam.dataSubf(i).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(i).ws)
                                imagetempSubf(j * 3 + 2 + wmod * k + 3 * threadParam.dataSubf(i).ws * k) = imagetempSubfBin(j + k * threadParam.dataSubf(i).ws)
                            Next
                        Next

                        Dim ar As Byte()
                        Dim indCalidad As Integer = 0

                        Img = CreateImage(threadParam.dataSubf(i).ws, threadParam.dataSubf(i).hs, imagetempSubf, Nothing)
                        'Img.Save(Direc_Path_BMP & "FP" + Convert.ToString(i + 1) + ".bmp", System.Drawing.Imaging.ImageFormat.Bmp)
                        SizeSubf = SizeSubf + threadParam.dataSubf(i).hs * threadParam.dataSubf(i).ws

                        ar = CType((New ImageConverter()).ConvertTo(Img, GetType(Byte())), Byte())

                        indCalidad = threadParam.dataSubf(i).qfutr
                        ' If indCalidad <= 3 And indCalidad > 0 Then
                        Select Case nNumBloqueCaptura
                            Case 1
                                lstUscHuellaActivaB1.Item(i)._ImagenHuellaByte = ar
                                lstUscHuellaActivaB1.Item(i)._IndiceCalidad = indCalidad
                            Case 2
                                lstUscHuellaActivaB2.Item(i)._ImagenHuellaByte = ar
                                lstUscHuellaActivaB2.Item(i)._IndiceCalidad = indCalidad
                            Case 3
                                lstUscHuellaActivaB3.Item(i)._ImagenHuellaByte = ar
                                lstUscHuellaActivaB3.Item(i)._IndiceCalidad = indCalidad
                                'Try
                                '    If indCalidad > 3 Then
                                '        lstUscHuellasActivasB3.Item(i)._FocoError = True
                                '    Else
                                '        lstUscHuellasActivasB3.Item(i)._FocoError = False
                                '    End If
                                'Catch ex As Exception

                                'End Try
                        End Select
                        'End If
                    End If
                Next
            End If
        Catch ex As FutronicException
            SetErrorMessage("Código de error: " & ex.ErrorCode & "  " & ex.Message)
        End Try

    End Sub

    Public Sub DrawImage(ByVal pictire As Bitmap)
        If PBox_Huellas.Image IsNot Nothing Then PBox_Huellas.Image.Dispose()

        PBox_Huellas.Image = pictire
    End Sub

    Sub ConvertWSQ(ByVal threadParam As ThreadParameters)
        Dim NomArc As String = ""
        Try
            Dim m_hDevice As New ScanAPIHelperFS60.Device
            Dim fBitRate As Double = 0.75
            Dim WSQ_Image As Byte()

            m_hDevice.Open()

            NomArc = c_dirPathWSQ
            WSQ_Image = m_hDevice.WSQ_FromRawImage(threadParam.imageDataSeg, threadParam.width, threadParam.height, fBitRate)
            SaveWSQ(NomArc & "0.wsq", WSQ_Image)
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0
            imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}
            For i As Integer = 0 To threadParams.paramSeg.nParamFing - 1
                If threadParam.dataSubf(i).err = 0 Then
                    Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs)

                    WSQ_Image = m_hDevice.WSQ_FromRawImage(imagetempSubfBin, threadParam.dataSubf(i).ws, threadParam.dataSubf(i).hs, fBitRate)
                    SaveWSQ(NomArc & i + 1 & ".wsq", WSQ_Image)
                    SizeSubf = SizeSubf + threadParam.dataSubf(i).hs * threadParam.dataSubf(i).ws
                    Select Case nNumBloqueCaptura
                        Case 1
                            lstUscHuellaActivaB1.Item(i)._Wsq = WSQ_Image
                            lstUscHuellaActivaB1.Item(i)._AnchoImgPixel = threadParam.dataSubf(i).ws
                            lstUscHuellaActivaB1.Item(i)._LargoImgPixel = threadParam.dataSubf(i).hs
                        Case 2
                            lstUscHuellaActivaB2.Item(i)._Wsq = WSQ_Image
                            lstUscHuellaActivaB2.Item(i)._AnchoImgPixel = threadParam.dataSubf(i).ws
                            lstUscHuellaActivaB2.Item(i)._LargoImgPixel = threadParam.dataSubf(i).hs
                        Case 3
                            lstUscHuellaActivaB3.Item(i)._Wsq = WSQ_Image
                            lstUscHuellaActivaB3.Item(i)._AnchoImgPixel = threadParam.dataSubf(i).ws
                            lstUscHuellaActivaB3.Item(i)._LargoImgPixel = threadParam.dataSubf(i).hs
                    End Select
                End If
            Next
            m_hDevice.Close()
        Catch ex As FutronicException
            SetErrorMessage("Código de error: " & ex.ErrorCode & "  " & ex.Message)
        End Try
    End Sub

    Sub SaveWSQ(ByVal NomArc As String, ByVal WSQ_Image As Byte())
        Dim file As New FileStream(NomArc, FileMode.Create)
        file.Write(WSQ_Image, 0, WSQ_Image.Length)
        file.Close()
    End Sub

    Sub ConvertAnsiSDK(ByVal threadParam As ThreadParameters)
        Try
            Dim h_device As IntPtr
            h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

            Dim pnOutTemplateSize As Integer
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0
            Dim val_Ansi As Boolean
            imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}
            For i As Integer = 0 To threadParams.paramSeg.nParamFing - 1
                If threadParam.dataSubf(i).err = 0 Then

                    'ALMACENA BMP SEGMENTADO
                    Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs)
                    Dim m_pImage_ANSI As Byte()
                    m_pImage_ANSI = New Byte(threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs) {}

                    'OBTENER ANSI DESDE BUFFER
                    val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.dataSubf(i).ws, threadParam.dataSubf(i).hs, m_pImage_ANSI, pnOutTemplateSize)

                    Dim path As String = ""
                    path = c_dirPathANSI & i + 1 & ".ansi"
                    Dim file As New FileStream(path, FileMode.Create)
                    file.Write(m_pImage_ANSI, 0, pnOutTemplateSize)
                    file.Close()
                    SizeSubf = SizeSubf + threadParam.dataSubf(i).hs * threadParam.dataSubf(i).ws

                    Select Case nNumBloqueCaptura
                        Case 1
                            lstUscHuellaActivaB1.Item(i)._TemplateANSI = IO.File.ReadAllBytes(path)
                        Case 2
                            lstUscHuellaActivaB2.Item(i)._TemplateANSI = IO.File.ReadAllBytes(path)
                        Case 3
                            lstUscHuellaActivaB3.Item(i)._TemplateANSI = IO.File.ReadAllBytes(path)
                    End Select
                End If
            Next
            Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)
        Catch ex As FutronicException
            Dim vv As Boolean
            SetErrorMessage(Lector.Futronic.LoadDll.getErrorMessage(ex.ErrorCode, vv))
        End Try

    End Sub

    Sub ConvertISOSDK(ByVal threadParam As ThreadParameters)
        Try
            Dim h_device As IntPtr
            h_device = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanOpenDevice()

            Dim pnOutTemplateSize As Integer
            Dim imagetempSubfBin As Byte()
            Dim SizeSubf As Integer = 0
            Dim val_Ansi As Boolean
            imagetempSubfBin = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) - 1) {}
            For i As Integer = 0 To threadParams.paramSeg.nParamFing - 1
                If threadParam.dataSubf(i).err = 0 Then

                    'ALMACENA BMP SEGMENTADO
                    Array.Copy(threadParam.imageDataSubf, SizeSubf, imagetempSubfBin, 0, threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs)
                    Dim m_pImage_ANSI As Byte()
                    m_pImage_ANSI = New Byte(threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs) {}

                    'OBTENER ANSI DESDE BUFFER
                    val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkCreateTemplateFromBuffer(h_device, 0, imagetempSubfBin, threadParam.dataSubf(i).ws, threadParam.dataSubf(i).hs, m_pImage_ANSI, pnOutTemplateSize)

                    Dim m_pImage_ISO As Byte()
                    m_pImage_ISO = New Byte(threadParam.dataSubf(i).ws * threadParam.dataSubf(i).hs) {}

                    val_Ansi = Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrAnsiSdkConvertAnsiTemplateToIso(m_pImage_ANSI, m_pImage_ISO, m_pImage_ANSI.Length)

                    Dim file As New FileStream(Me.c_dirPathISO & i + 1 & ".iso", FileMode.Create)
                    file.Write(m_pImage_ISO, 0, pnOutTemplateSize)
                    file.Close()
                    SizeSubf = SizeSubf + threadParam.dataSubf(i).hs * threadParam.dataSubf(i).ws
                End If
            Next

            Lector.Futronic.LoadDll.ANSI_ISO_ftrNativeLib.ftrScanCloseDevice(h_device)

        Catch ex As FutronicException
            SetErrorMessage("Código de error: " & ex.ErrorCode & "  " & ex.Message)
        End Try
    End Sub

    Private Function ConectarDispositivo(numSegmentos As Integer) As Boolean

        ProcesoLed(True)
        Try
            Dim modeNumber As Integer = 0       '' Tamaño de la imagen
            Dim imageSize As Size
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
                            ProcesoLed(True)
                            Return False
                        Catch ex As Exception
                            Return False
                        End Try
                    End If
                End While
            End If

            threadParams.continueProcess = True  ' Indica si el proceso en continuo
            workingThread = New Thread(AddressOf DoScan)
            threadParams.hDevice.InvertImage = True
            threadParams.hDevice.PreviewMode = True
            imageSize = threadParams.hDevice.ImageSize
            threadParams.height = imageSize.Height
            threadParams.width = imageSize.Width
            threadParams.hDevice.ImageFormat = modeNumber
            threadParams.mode = modeNumber

            threadParams.imageDataSeg = New Byte(threadParams.height * threadParams.width - 1) {}
            threadParams.paramSeg.nParamAngle = CInt(SegmAdjustment.noangle)
            threadParams.paramSeg.nWidthSubf = CInt(MathNums.xsize)
            threadParams.paramSeg.nHeightSubf = CInt(MathNums.ysize)
            threadParams.paramSeg.nParamFing = numSegmentos ' Indica la cantidad de dedos que reconocerá
            threadParams.paramSeg.nParamNfiq = CInt(SegmAdjustment.qfutr)
            threadParams.paramSeg.nParamFixedSize = CInt(SegmAdjustment.fixedsize)
            threadParams.paramSeg.nWidthSubf = CInt(MathNums.xsize)
            threadParams.paramSeg.nHeightSubf = CInt(MathNums.ysize)
            threadParams.imageDataSubf = New Byte(CInt(MathNums.maxsubfsize) * CInt(MathNums.maxsubfsize) * threadParams.paramSeg.nParamFing - 1) {}

            threadParams.dataSubf = New SubfPointCoord(threadParams.paramSeg.nParamFing - 1) {}
            threadParams.imageData = New Byte(threadParams.height * threadParams.width) {}
            workingThread.Start(threadParams)
            btnCapturar.Text = "Capturar"
            threadParams.cancelarProceso = False
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
    End Function


    Private Sub Led(Encender As Boolean)
        Dim hDevice As New Device()
        Try
            hDevice.Open()
            Dim param1 As UInteger = &H0
            Dim param2 As UInteger = &H0

            hDevice.ControlPin3(&H100000, 0, 250) 'beep del dispositivo
            Thread.Sleep(100) 'medio segundo
            hDevice.ControlPin3(0, param2, 250)

            For Each obj As uscIconFinger In lstIconoDedos
                obj.Visible = False
            Next

            Select Case Me.nNumBloqueCaptura
                Case 1
                    usc_izq_men.Visible = True
                    usc_izq_anu.Visible = True
                    usc_izq_med.Visible = True
                    usc_izq_ind.Visible = True

                    uscMenIzq.chkHuellaNoDisponible.Checked = False
                    uscAnuIzq.chkHuellaNoDisponible.Checked = False
                    uscMedIzq.chkHuellaNoDisponible.Checked = False
                    uscIndIzq.chkHuellaNoDisponible.Checked = False

                    If Encender = False Then 'apagar
                        If uscMenIzq._EstadoDedo <> EstadoDedo.Amputado Then uscMenIzq.chkHuellaNoDisponible.Visible = True
                        If uscAnuIzq._EstadoDedo <> EstadoDedo.Amputado Then uscAnuIzq.chkHuellaNoDisponible.Visible = True
                        If uscMedIzq._EstadoDedo <> EstadoDedo.Amputado Then uscMedIzq.chkHuellaNoDisponible.Visible = True
                        If uscIndIzq._EstadoDedo <> EstadoDedo.Amputado Then uscIndIzq.chkHuellaNoDisponible.Visible = True
                    Else 'encender
                        'uscMenIzq._FocoEnceder = False
                        'uscAnuIzq._FocoEnceder = False
                        'uscMedIzq._FocoEnceder = False
                        'uscIndIzq._FocoEnceder = False

                        'If uscMenIzq._EstadoDedo <> EstadoDedo.Amputado Then uscMenIzq._FocoEnceder = True
                        'If uscAnuIzq._EstadoDedo <> EstadoDedo.Amputado Then uscAnuIzq._FocoEnceder = True
                        'If uscMedIzq._EstadoDedo <> EstadoDedo.Amputado Then uscMedIzq._FocoEnceder = True
                        'If uscIndIzq._EstadoDedo <> EstadoDedo.Amputado Then uscIndIzq._FocoEnceder = True
                    End If

                    If uscMenIzq._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H1 : usc_izq_men.BackColor = Color.Red
                    If uscMenIzq._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H2 : usc_izq_men.BackColor = Me.colorLedOn
                    If uscAnuIzq._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H4 : usc_izq_anu.BackColor = Color.Red
                    If uscAnuIzq._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H8 : usc_izq_anu.BackColor = Me.colorLedOn
                    If uscMedIzq._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H10 : usc_izq_med.BackColor = Color.Red
                    If uscMedIzq._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H20 : usc_izq_med.BackColor = Me.colorLedOn
                    If uscIndIzq._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H40 : usc_izq_ind.BackColor = Color.Red
                    If uscIndIzq._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H80 : usc_izq_ind.BackColor = Me.colorLedOn
                Case 2
                    usc_der_ind.Visible = True
                    usc_der_med.Visible = True
                    usc_der_anu.Visible = True
                    usc_der_men.Visible = True

                    uscIndDer.chkHuellaNoDisponible.Checked = False
                    uscMedDer.chkHuellaNoDisponible.Checked = False
                    uscAnuDer.chkHuellaNoDisponible.Checked = False
                    uscMenDer.chkHuellaNoDisponible.Checked = False

                    If Encender = False Then
                        If uscIndDer._EstadoDedo <> EstadoDedo.Amputado Then uscIndDer.chkHuellaNoDisponible.Visible = True
                        If uscMedDer._EstadoDedo <> EstadoDedo.Amputado Then uscMedDer.chkHuellaNoDisponible.Visible = True
                        If uscAnuDer._EstadoDedo <> EstadoDedo.Amputado Then uscAnuDer.chkHuellaNoDisponible.Visible = True
                        If uscMenDer._EstadoDedo <> EstadoDedo.Amputado Then uscMenDer.chkHuellaNoDisponible.Visible = True
                    End If

                    If uscIndDer._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H1000 : usc_der_ind.BackColor = Color.Red
                    If uscIndDer._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H2000 : usc_der_ind.BackColor = Me.colorLedOn
                    If uscMedDer._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H4000 : usc_der_med.BackColor = Color.Red
                    If uscMedDer._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H8000 : usc_der_med.BackColor = Me.colorLedOn
                    If uscAnuDer._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H10000 : usc_der_anu.BackColor = Color.Red
                    If uscAnuDer._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H20000 : usc_der_anu.BackColor = Me.colorLedOn
                    If uscMenDer._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H40000 : usc_der_men.BackColor = Color.Red
                    If uscMenDer._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H80000 : usc_der_men.BackColor = Me.colorLedOn
                Case 3
                    usc_izq_pul.Visible = True
                    usc_der_pul.Visible = True

                    uscPulIzq.chkHuellaNoDisponible.Checked = False
                    uscPulDer.chkHuellaNoDisponible.Checked = False

                    If Encender = False Then
                        If uscPulIzq._EstadoDedo <> EstadoDedo.Amputado Then uscPulIzq.chkHuellaNoDisponible.Visible = True
                        If uscPulDer._EstadoDedo <> EstadoDedo.Amputado Then uscPulDer.chkHuellaNoDisponible.Visible = True
                    End If

                    If uscPulIzq._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H100 : usc_izq_pul.BackColor = Color.Red
                    If uscPulIzq._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H200 : usc_izq_pul.BackColor = Me.colorLedOn
                    If uscPulDer._EstadoDedo = EstadoDedo.Amputado Then param1 = param1 Or &H400 : usc_der_pul.BackColor = Color.Red
                    If uscPulDer._EstadoDedo <> EstadoDedo.Amputado Then param1 = param1 Or &H800 : usc_der_pul.BackColor = Me.colorLedOn
            End Select

            If Encender = False Then
                param1 = 0

                For Each obj As uscIconFinger In lstIconoDedos
                    obj.BackColor = Me.colorLedOff
                Next
                btnCapturar.Text = "Reiniciar captura"

                btnAnterior.Enabled = True
                btnSiguiente.Enabled = True
                'btnCapturar.Enabled = False
                btnAbortar.Enabled = False
                btnCancelar.Enabled = True
                btnAceptar.Enabled = True
                btnAmputado.Enabled = True

                For Each obj As uscIconFinger In lstIconoDedos
                    obj.BackColor = Me.colorLedOff
                Next
            End If

            hDevice.ControlPin3(param1, param2, 250)

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
#End Region

#Region "OTROS"
    Private Sub ConfigurarAmputados()
        Dim f As New frmConfigAmputadoDeca
        f._izq_men_amputado = If(uscMenIzq._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._izq_anu_amputado = If(uscAnuIzq._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._izq_med_amputado = If(uscMedIzq._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._izq_ind_amputado = If(uscIndIzq._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._izq_pul_amputado = If(uscPulIzq._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._der_men_amputado = If(uscMenDer._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._der_anu_amputado = If(uscAnuDer._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._der_med_amputado = If(uscMedDer._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._der_ind_amputado = If(uscIndDer._EstadoDedo = EstadoDedo.Amputado, True, False)
        f._der_pul_amputado = If(uscPulDer._EstadoDedo = EstadoDedo.Amputado, True, False)

        If f.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each usc In TabPage1.Controls
                If TypeOf usc Is uscThumbFinger Then
                    usc.LimpiarHuella()
                End If
            Next

            pbBloque1.Image = Nothing
            pbBloque2.Image = Nothing
            pbBloque3.Image = Nothing

            If f._izq_men_amputado = True Then uscMenIzq._EstadoDedo = EstadoDedo.Amputado
            If f._izq_anu_amputado = True Then uscAnuIzq._EstadoDedo = EstadoDedo.Amputado
            If f._izq_med_amputado = True Then uscMedIzq._EstadoDedo = EstadoDedo.Amputado
            If f._izq_ind_amputado = True Then uscIndIzq._EstadoDedo = EstadoDedo.Amputado
            If f._izq_pul_amputado = True Then uscPulIzq._EstadoDedo = EstadoDedo.Amputado
            If f._der_men_amputado = True Then uscMenDer._EstadoDedo = EstadoDedo.Amputado
            If f._der_anu_amputado = True Then uscAnuDer._EstadoDedo = EstadoDedo.Amputado
            If f._der_med_amputado = True Then uscMedDer._EstadoDedo = EstadoDedo.Amputado
            If f._der_ind_amputado = True Then uscIndDer._EstadoDedo = EstadoDedo.Amputado
            If f._der_pul_amputado = True Then uscPulDer._EstadoDedo = EstadoDedo.Amputado

            For Each obj As uscIconFinger In lstIconoDedos
                obj.Visible = False
            Next

            Select Case nNumBloqueCaptura
                Case 1
                    usc_izq_men.Visible = True
                    usc_izq_anu.Visible = True
                    usc_izq_med.Visible = True
                    usc_izq_ind.Visible = True
                Case 2
                    usc_der_ind.Visible = True
                    usc_der_med.Visible = True
                    usc_der_anu.Visible = True
                    usc_der_men.Visible = True
                Case 3
                    usc_izq_pul.Visible = True
                    usc_der_pul.Visible = True
            End Select
        End If
    End Sub

    Private Sub VerificarDispositivo()
        Dim b As Boolean = False
        While b = False
            Try
                Dim hDevice As New Device()
                hDevice.Open()
                If hDevice.Information.DeviceCompatibility <> 8 And hDevice.Information.DeviceCompatibility <> 15 Then
                    MsgBox("Dispositivo biométrico no compatible para la captura decadactilar.", MsgBoxStyle.Question)
                    Me.Close()
                End If
                'lblScanner.Text = "Scanner: " & Lector.Futronic.LoadDll.getScannerName(Me.m_TipoDispositivo)
                'lblFilmware.Text = "Filmware: " & hDevice.VersionInformation.FirmwareVersion.ToString()
                'lblHardware.Text = "Hardware: " & hDevice.VersionInformation.HardwareVersion.ToString()
                hDevice.Close()
                b = True
            Catch ex As Exception
            End Try
            If b = False AndAlso MsgBox("Dispositivo biométrico no conectado, por favor conecte en el puerto USB y click en Aceptar", MsgBoxStyle.OkCancel + MsgBoxStyle.Question) = MsgBoxResult.Cancel Then
                Me.Close()
                Exit Sub
            End If
        End While
    End Sub

    Private Sub capturarHuella()
        lblMessage.Text = ""
        If btnCapturar.Text = "Capturar" Then
            btnCapturar.Text = "Reiniciar captura"
            If Not threadParams Is Nothing Then
                threadParams.cancelarProceso = False
                threadParams.continueProcess = False 'Para el proceso de reconocimiento de huella
            End If

            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
            btnAbortar.Enabled = False
            btnCancelar.Enabled = True
            btnAceptar.Enabled = True
            btnAmputado.Enabled = True
        Else
            Try
                VerificarDispositivo()

                btnCapturar.Text = "Capturar"

                Dim numSeg As Integer = 0

                lstUscHuellaActivaB1 = New List(Of uscThumbFinger)
                lstUscHuellaActivaB2 = New List(Of uscThumbFinger)
                lstUscHuellaActivaB3 = New List(Of uscThumbFinger)

                Select Case nNumBloqueCaptura
                    Case 1
                        If uscMenIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscMenIzq)
                        If uscAnuIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscAnuIzq)
                        If uscMedIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscMedIzq)
                        If uscIndIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscIndIzq)
                    Case 2
                        If uscIndDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscIndDer)
                        If uscMedDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscMedDer)
                        If uscAnuDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscAnuDer)
                        If uscMenDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscMenDer)
                    Case 3
                        If uscPulIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB3.Add(uscPulIzq)
                        If uscPulDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB3.Add(uscPulDer)
                End Select
                ConectarDispositivo(numSeg)

                btnAnterior.Enabled = False
                btnSiguiente.Enabled = False
                'btnCapturar.Enabled = True
                btnAbortar.Enabled = True
                btnCancelar.Enabled = False
                btnAceptar.Enabled = False
                btnAmputado.Enabled = False
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Grabar()
        '------------------- validar antes de grabar ------------>
        Dim sms As String = ""
        For Each usc In TabPage1.Controls
            If TypeOf usc Is uscThumbFinger Then
                Dim con As uscThumbFinger = usc

                If con._EstadoDedo = EstadoDedo.Disponible And con._IndiceCalidad > 3 Then
                    MsgBox("La calidad de la huella " & con._NombreLargoDedo & " no es aceptable, debe marcar como observado.", vbExclamation)
                    Exit Sub
                End If

                If con._EstadoDedo = EstadoDedo.Disponible And con._Wsq Is Nothing Then
                    sms = sms & con._NombreLargoDedo & "   Estado: " & con._EstadoDedo & vbCrLf
                End If
                If con._EstadoDedo <> EstadoDedo.Disponible Then
                    con._Wsq = Nothing
                    con._TemplateANSI = Nothing
                    con._TemplateISO = Nothing
                End If
            End If
        Next
        If sms.Trim.Length > 0 Then
            MsgBox("La siguientes huellas se encuentran pendientes de captura." & vbCrLf & sms, vbExclamation)
            Exit Sub
        End If
        '<--------------------------------------------

        Dim bs As New Business.SysBiometria(Me._CnBdHuella)
        Dim s As String = ""
        Dim id As Integer = -1

        For Each usc In TabPage1.Controls
            If TypeOf usc Is uscThumbFinger Then
                Dim ctrHuella As uscThumbFinger = usc

                If ctrHuella._Codigo > 0 Then Continue For

                id = bs.GrabarHuella(-1, enmTipoCapturaHuella.HUELLA_PLANA, ctrHuella._TipoDedo, enumTipoDispositivo.Futronic_Deca_FS60, ctrHuella._TemplateANSI, _
                                     ctrHuella._Wsq, ctrHuella._AnchoImgPixel, ctrHuella._LargoImgPixel, ctrHuella._IndiceCalidad, _
                                    ctrHuella._EstadoDedo, ctrHuella._Observacion, Me._TipDocIdentId, Me._NumDocIdent, Me._CodRP, _ApePat, Me._ApeMat, _Nombres,
                                    Me._RegId, Me._PenId, Me._UsuarioId, s)

                If id = -1 Then
                    MsgBox(s, vbExclamation)
                    Exit Sub
                Else
                    ctrHuella._Codigo = id
                    Dim tipDedo As Integer = 0
                    tipDedo = ctrHuella._TipoDedo
                    lstListTemplateIds.Add(tipDedo, id)
                End If

            End If
        Next

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region

    Private Sub btnAnterior_Click(sender As System.Object, e As System.EventArgs) Handles btnAnterior.Click
        VerificarDispositivo()

        nNumBloqueCaptura = nNumBloqueCaptura - 1
        If nNumBloqueCaptura <= 1 Then
            nNumBloqueCaptura = 1
            btnAnterior.Image = My.Resources.fle_pri1
        End If
        btnSiguiente.Image = My.Resources.fle_pri11

        lstUscHuellaActivaB1 = New List(Of uscThumbFinger)
        lstUscHuellaActivaB2 = New List(Of uscThumbFinger)
        lstUscHuellaActivaB3 = New List(Of uscThumbFinger)

        Dim numSeg As Integer = 0

        Select Case nNumBloqueCaptura
            Case 1S
                If uscMenIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscMenIzq)
                If uscAnuIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscAnuIzq)
                If uscMedIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscMedIzq)
                If uscIndIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscIndIzq)
            Case 2
                If uscIndDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscIndDer)
                If uscMedDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscMedDer)
                If uscAnuDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscAnuDer)
                If uscMenDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscMenDer)
            Case 3
                If uscPulIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB3.Add(uscPulIzq)
                If uscPulDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB3.Add(uscPulDer)
        End Select

        ConectarDispositivo(numSeg)

        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        btnAbortar.Enabled = True
        btnCancelar.Enabled = False
        btnAceptar.Enabled = False
        btnAmputado.Enabled = False

        btnCapturar.Text = "Capturar"
    End Sub

    Private Sub btnSiguiente_Click(sender As System.Object, e As System.EventArgs) Handles btnSiguiente.Click
        VerificarDispositivo()

        nNumBloqueCaptura = nNumBloqueCaptura + 1
        If nNumBloqueCaptura >= 3 Then
            nNumBloqueCaptura = 3
            btnSiguiente.Image = My.Resources.next_32
        End If
        btnAnterior.Image = My.Resources.back_32
        lstUscHuellaActivaB1 = New List(Of uscThumbFinger)
        lstUscHuellaActivaB2 = New List(Of uscThumbFinger)
        lstUscHuellaActivaB3 = New List(Of uscThumbFinger)

        Dim numSeg As Integer = 0

        Select Case nNumBloqueCaptura
            Case 1
                If uscMenIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscMenIzq)
                If uscAnuIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscAnuIzq)
                If uscMedIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscMedIzq)
                If uscIndIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB1.Add(uscIndIzq)
            Case 2
                If uscIndDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscIndDer)
                If uscMedDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscMedDer)
                If uscAnuDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscAnuDer)
                If uscMenDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB2.Add(uscMenDer)
            Case 3
                If uscPulIzq._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB3.Add(uscPulIzq)
                If uscPulDer._EstadoDedo <> EstadoDedo.Amputado Then numSeg = numSeg + 1 : lstUscHuellaActivaB3.Add(uscPulDer)
        End Select

        ConectarDispositivo(numSeg)
        btnAnterior.Enabled = False
        btnSiguiente.Enabled = False
        btnAbortar.Enabled = True
        btnCancelar.Enabled = False
        btnAceptar.Enabled = False
        btnAmputado.Enabled = False

        btnCapturar.Text = "Capturar"
    End Sub

    Private Sub btnCapturar_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturar.Click
        capturarHuella()
    End Sub

    Private Sub btnAmputado_Click(sender As System.Object, e As System.EventArgs) Handles btnAmputado.Click
        ConfigurarAmputados()
    End Sub

    Private Sub frmCapturaHuellaAsist_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Dim sms As String = ""

        If Me._UsuarioId = -1 Then sms = "Id de usuario no válido."
        If Me._RegId = -1 Then sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Id del región no especificado"
        If Me._PenId = -1 Then sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Id del penal no especificado"
        If String.IsNullOrEmpty(Me._CnBdHuella) Then sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Cadena de conexión a la base de datos de huella no especificada"
        If sms.Trim.Length > 0 Then
            MsgBox(sms, MsgBoxStyle.Exclamation)
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Exit Sub
        End If

        If Not System.IO.Directory.Exists(c_dirPathWSQ) Then System.IO.Directory.CreateDirectory(c_dirPathWSQ)
        If Not System.IO.Directory.Exists(c_dirPathBMP) Then System.IO.Directory.CreateDirectory(c_dirPathBMP)
        If Not System.IO.Directory.Exists(c_dirPathANSI) Then System.IO.Directory.CreateDirectory(c_dirPathANSI)
        If Not System.IO.Directory.Exists(c_dirPathISO) Then System.IO.Directory.CreateDirectory(c_dirPathISO)

        With lstIconoDedos
            .Add(usc_izq_men)
            .Add(usc_izq_anu)
            .Add(usc_izq_med)
            .Add(usc_izq_ind)
            .Add(usc_izq_pul)
            .Add(usc_der_pul)
            .Add(usc_der_ind)
            .Add(usc_der_med)
            .Add(usc_der_anu)
            .Add(usc_der_men)
        End With
        For Each usc In TabPage1.Controls
            If TypeOf usc Is uscThumbFinger Then
                Dim xusc As uscThumbFinger = usc
                xusc.btnObs.Visible = True
            End If
        Next
    End Sub

    Private Sub uscAnuIzq__DobleClick(sender As uscThumbFinger) Handles uscMenIzq._DobleClick, uscAnuIzq._DobleClick, uscMedIzq._DobleClick, _
                                                                            uscIndIzq._DobleClick, uscPulIzq._DobleClick, uscPulDer._DobleClick, _
                                                                            uscIndDer._DobleClick, uscMedDer._DobleClick, uscAnuDer._DobleClick, _
                                                                            uscMenDer._DobleClick
        Dim f As New frmVisorHuella()
        f.PictureBox1.Image = sender._Imagen
        f.ShowDialog()
    End Sub

    Private Sub pbBloque1_DoubleClick(sender As Object, e As System.EventArgs) Handles pbBloque1.DoubleClick
        Dim f As New frmVisorHuella()
        f.PictureBox1.Image = pbBloque1.Image
        f.ShowDialog()
    End Sub

    Private Sub pbBloque2_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbBloque2.DoubleClick
        Dim f As New frmVisorHuella()
        f.PictureBox1.Image = pbBloque2.Image
        f.ShowDialog()
    End Sub

    Private Sub pbBloque3_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbBloque3.DoubleClick
        Dim f As New frmVisorHuella()
        f.PictureBox1.Image = pbBloque3.Image
        f.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        Grabar()
    End Sub

    Private Sub btnAbortar_Click(sender As System.Object, e As System.EventArgs) Handles btnAbortar.Click
        lblMessage.Text = ""
        If Not threadParams Is Nothing AndAlso Not threadParams.hDevice Is Nothing Then
            Try
                threadParams.hDevice.AbortRoll(False)
            Catch ex As FutronicException

            Catch ex2 As Exception

            End Try
            threadParams.continueProcess = False
            threadParams.cancelarProceso = True
        Else
            btnCapturar.Enabled = True
            btnAnterior.Enabled = True
            btnSiguiente.Enabled = True
            btnAmputado.Enabled = True
            btnCancelar.Enabled = True
            btnAceptar.Enabled = True
            btnAbortar.Enabled = False
            btnCapturar.Text = "Iniciar captura"
        End If
    End Sub

    Private Sub frmCapturaDeca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If System.IO.Directory.Exists(c_dirPathANSI) = False Then System.IO.Directory.CreateDirectory(c_dirPathANSI)
        If System.IO.Directory.Exists(c_dirPathBMP) = False Then System.IO.Directory.CreateDirectory(c_dirPathBMP)
        If System.IO.Directory.Exists(c_dirPathWSQ) = False Then System.IO.Directory.CreateDirectory(c_dirPathWSQ)
        If System.IO.Directory.Exists(c_dirPathISO) = False Then System.IO.Directory.CreateDirectory(c_dirPathISO)


    End Sub

    Private Sub frmCapturaDeca_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.Control Then 'simular doble pulsacion de tecla(analogo al doble click)
            If bCountTimeON = False Then
                nCountTime = 0
                bCountTimeON = True
                tmrControlPulsacion.Start()
            Else
                bCountTimeON = False
                tmrControlPulsacion.Stop()
                'MsgBox(nCountTime)
                btnCapturar.PerformClick()
            End If
        End If
    End Sub

    Private Sub tmrControlPulsacion_Tick(sender As System.Object, e As System.EventArgs) Handles tmrControlPulsacion.Tick
        nCountTime = nCountTime + 1
        If nCountTime > 14 Then
            bCountTimeON = False
            nCountTime = 0
        End If
    End Sub
End Class