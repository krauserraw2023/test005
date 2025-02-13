Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Namespace Lector.Futronic
    Public Class LoadDll
        'Public Enum FingerPost
        '    FTR_ANSISDK_FINGPOS_UK = 0 'desconocido

        '    FTR_ANSISDK_FINGPOS_RT = 1 'pulgar derecho
        '    FTR_ANSISDK_FINGPOS_RI = 2 'indice derecho 
        '    FTR_ANSISDK_FINGPOS_RM = 3 'medio derecho
        '    FTR_ANSISDK_FINGPOS_RR = 4 'anular derecho
        '    FTR_ANSISDK_FINGPOS_RL = 5 'menique derecho

        '    FTR_ANSISDK_FINGPOS_LT = 6 'pulgar izquierdo
        '    FTR_ANSISDK_FINGPOS_LI = 7 'indice izquierdo
        '    FTR_ANSISDK_FINGPOS_LM = 8 'medio izquierdo
        '    FTR_ANSISDK_FINGPOS_LR = 9 'anular izquierdo
        '    FTR_ANSISDK_FINGPOS_LL = 10 'menique izquierdo
        'End Enum

        Public Shared Function getScannerName(ByVal tipoScanner As Utilidad.enmDispositivoCompatibilidad) As String
            Dim strName As String = ""
            Select Case tipoScanner
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS1
                    strName = "FS80"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS80H
                    strName = "FS80H"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS3
                    strName = "FS88"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS88H
                    strName = "FS88H"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS25
                    strName = "FS25"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS50
                    strName = "FS50"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS60
                    strName = "FS60"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS64
                    strName = "FS64"
                Case Utilidad.enmDispositivoCompatibilidad.FTR_DEVICE_USB_2_0_TYPE_FS10
                    strName = "FS10"
                Case Else
                    strName = "<<DESCONOCIDO>>"
            End Select
            Return strName
        End Function

        Public Shared Function getErrorMessage(ByVal code As Utilidad.enmError, ByRef criticalError As Boolean) As String
            Dim message As String = ""
            criticalError = False
            Select Case code
                Case Utilidad.enmError.kNO_ERROR
                    message = ""
                Case Utilidad.enmError.kEMPTY_FRAME
                    message = "Empty frame"
                Case Utilidad.enmError.kMOVABLE_FINGER
                    message = "Movable finger"
                Case Utilidad.enmError.kNOT_CONNECTED_DEVICE
                    criticalError = True
                    message = "Parece ser que el dispositivo no se encuentra conectado."
                Case Utilidad.enmError.kNO_FRAME
                    message = "No frame"
                Case Utilidad.enmError.kUSER_CANCELED
                    message = "Cancelado por usuario"
                Case Utilidad.enmError.kHARDWARE_INCOMPATIBLE
                    message = "Incompatible hardware"
                Case Utilidad.enmError.kFIRMWARE_INCOMPATIBLE
                    message = "Incompatible firmware"
                Case Utilidad.enmError.kINVALID_AUTHORIZATION_CODE
                    message = "Código de autorización errorea"
                Case Utilidad.enmError.kNOT_SUPPORTED
                    message = "Caracteristica no soportada"
                    criticalError = True

                Case Utilidad.enmError.kROLL_NOT_STARTED
                    message = "La operación de rolado de huella no inicializada"
                    criticalError = True
                Case Utilidad.enmError.kROLL_PROGRESS_DATA
                    message = "Procesando..."
                Case Utilidad.enmError.kROLL_TIMEOUT
                    message = "Operación fuera de tiempo..."
                Case Utilidad.enmError.kROLL_ABORTED
                    message = "Operación cancelada por usuario"
                    criticalError = True
                Case Utilidad.enmError.kROLL_ALREADY_STARTED
                    message = "Operación en curso"
                    criticalError = True
                Case Utilidad.enmError.kROLL_PROGRESS_REMOVE_FINGER
                    message = "Retire el dedo del escaner"
                Case Utilidad.enmError.kROLL_PROGRESS_PUT_FINGER
                    message = "Coloque el dedo en el escaner para rolar"
                Case Utilidad.enmError.kROLL_PROGRESS_POST_PROCESSING
                    message = "Post processing... -"
                Case Utilidad.enmError.kNO_MORE_ITEMS
                    message = "No hay mas datos disponibles."
                    criticalError = True
                Case Utilidad.enmError.kNOT_ENOUGH_MEMORY
                    message = "No hay espacio disponible suficiente para procesar este comando."
                    criticalError = True
                Case Utilidad.enmError.kNO_SYSTEM_RESOURCES
                    message = "Insufficient system resources exist to complete the requested service."
                    criticalError = True
                Case Utilidad.enmError.kTIMEOUT
                    message = "Operación cancelada porque expiró el tiempo."
                    criticalError = True
                Case Utilidad.enmError.kNOT_READY
                    message = "El dispositivo no está en marcha."
                    criticalError = True
                Case Utilidad.enmError.kBAD_CONFIGURATION
                    message = "The configuration data for this product is corrupt. Contact your support personnel."
                    criticalError = True
                Case Utilidad.enmError.kINVALID_PARAMETER
                    message = "El parámetro es incorrecto."
                    criticalError = True
                Case Utilidad.enmError.kCALL_NOT_IMPLEMENTED
                    message = "Función no soportada por este dispositivo."
                    criticalError = True
                Case Utilidad.enmError.kWRITE_PROTECT
                    message = "The device is write protected."
                    criticalError = True
                Case Utilidad.enmError.kMESSAGE_EXCEEDS_MAX_SIZE
                    message = "The message provided exceeds the maximum size allowed for this parameter."
                    criticalError = True
                Case Else
                    message = "Error desconocido"
                    criticalError = True
            End Select

            Return message
        End Function



        <DllImport("WSQ_library.dll", CharSet:=CharSet.Ansi, CallingConvention:=CallingConvention.Cdecl)> Private Shared Function _CreateBMPFromWSQByteArray(
        <[In]()> ByVal input_data_stream As Byte(),
        <MarshalAs(UnmanagedType.I4)> ByVal input_stream_length As Integer) As IntPtr
        End Function

        Public Shared Function CreateBMPFromWSQByteArray(<[In]()> ByVal input_data_streamWSQ As Byte(),
                  <[In]()> ByVal input_stream_length As Integer) As IntPtr
            Dim bitmap_ptr As IntPtr = IntPtr.Zero
            Try
                bitmap_ptr = _CreateBMPFromWSQByteArray(input_data_streamWSQ, input_stream_length)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.OkOnly, "CreateBMPFromWSQByteArray Exception")
            End Try

            CreateBMPFromWSQByteArray = bitmap_ptr

        End Function

        <DllImport("kernel32.dll")>
        Private Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
        End Function
        <DllImport("kernel32.dll")>
        Private Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal lpProcName As String) As IntPtr
        End Function
        <DllImport("kernel32", EntryPoint:="FreeLibrary", SetLastError:=True)>
        Private Shared Function FreeLibrary(ByVal hModule As IntPtr) As Boolean
        End Function


        Public Class WSQ
            Private hModule As IntPtr = IntPtr.Zero
            Public Structure FTRIMGPARMS
                Public Width As Integer
                Public Height As Integer
                Public DPI As Integer
                Public RAW_size As Integer
                Public WSQ_size As Integer
                Public Bitrate As Double
            End Structure
            Public ftrWSQ_FromRawImage As ftrWSQ_FromRawImage_ = Nothing
            Public Delegate Function ftrWSQ_FromRawImage_(ByVal ftrHandle As Integer, ByVal ftrWSQBuf As Byte(), ByVal ftrImpar As FTRIMGPARMS, ByVal ftrWSQBuf As Byte()) As Boolean


            Public Sub New(ByVal sDllName As String)
                hModule = LoadLibrary(sDllName)
                If hModule = IntPtr.Zero Then
                    MessageBox.Show("Load " & sDllName & " failed.", "Error")
                    Return
                End If
                ''''''''''''''''''''CREADO
                ftrWSQ_FromRawImage = DirectCast(GetAddress(hModule, "ftrWSQ_FromRAWImage", GetType(ftrWSQ_FromRawImage_)), ftrWSQ_FromRawImage_)

                ''''''''''''''''''''CREADO
            End Sub

        End Class

        Public Class ScanAPI


            Public Structure FTRSCAN_DEVICE_INFO
                Public nWidth As Integer
                Public nHeight As Integer
                Public nImageSize As Integer
            End Structure


            Public Structure FTRSCAN_FRAME_PARAMETERS

                Dim nContrastOnDose2 As Integer
                Dim nContrastOnDose4 As Integer
                Dim nDose As Integer
                Dim nBrightnessOnDose1 As Integer
                Dim nBrightnessOnDose2 As Integer
                Dim nBrightnessOnDose3 As Integer
                Dim nBrightnessOnDose4 As Integer
                Dim FakeReplicaParams As FTRSCAN_FAKE_REPLICA_PARAMETERS
                Dim Bytes As Object

            End Structure

            Public Structure FTRSCAN_FAKE_REPLICA_PARAMETERS
                Dim bCalculated As Boolean
                Dim nCalculatedSum1 As Integer
                Dim nCalculatedSumFuzzy As Integer
                Dim nCalculatedSumEmpty As Integer
                Dim nCalculatedSum2 As Integer
                Dim dblCalculatedTremor As Double
                Dim dblCalculatedValue As Double
            End Structure






            Private hModule As IntPtr = IntPtr.Zero
            Public ftrScanOpenDevice As ftrScanOpenDevice_ = Nothing
            Public ftrScanCloseDevice As ftrScanCloseDevice_ = Nothing
            Public ftrScanGetImage As ftrScanGetImage_ = Nothing
            Public ftrScanGetImageSize As ftrScanGetImageSize_ = Nothing
            Public ftrScanIsFingerPresent As ftrScanIsFingerPresent_ = Nothing
            Public ftrScanGetFrame As ftrScanGetFrame_ = Nothing





            Public Delegate Function ftrScanOpenDevice_() As Integer
            Public Delegate Function ftrScanCloseDevice_(ByVal ftrHandle As Integer) As Integer
            Public Delegate Function ftrScanGetImage_(ByVal ftrHandle As Integer, ByVal NDose As Integer, ByVal pBuffer As Byte()) As Boolean
            Public Delegate Function ftrScanGetImageSize_(ByVal ftrHandle As Integer, ByRef Device_Info As FTRSCAN_DEVICE_INFO) As Boolean
            Public Delegate Function ftrScanIsFingerPresent_(ByVal ftrHandle As Integer, ByRef Device_Info As FTRSCAN_DEVICE_INFO) As Boolean
            Public Delegate Function ftrScanGetFrame_(ByVal ftrHandle As Integer, ByRef pBuffer As Byte(), ByRef p As FTRSCAN_FRAME_PARAMETERS) As Boolean




            Public Sub New(ByVal sDllName As String)
                Try


                    hModule = LoadLibrary(sDllName)
                    If hModule = IntPtr.Zero Then
                        MessageBox.Show("Load " & sDllName & " failed.", "Error")
                        Return
                    End If
                    ''''''''''''''''''''CREADO
                    ftrScanOpenDevice = DirectCast(GetAddress(hModule, "ftrScanOpenDevice", GetType(ftrScanOpenDevice_)), ftrScanOpenDevice_)
                    ftrScanCloseDevice = DirectCast(GetAddress(hModule, "ftrScanCloseDevice", GetType(ftrScanCloseDevice_)), ftrScanCloseDevice_)
                    ftrScanGetImage = DirectCast(GetAddress(hModule, "ftrScanGetImage", GetType(ftrScanGetImage_)), ftrScanGetImage_)
                    ftrScanGetImageSize = DirectCast(GetAddress(hModule, "ftrScanGetImageSize", GetType(ftrScanGetImageSize_)), ftrScanGetImageSize_)
                    ftrScanIsFingerPresent = DirectCast(GetAddress(hModule, "ftrScanIsFingerPresent", GetType(ftrScanIsFingerPresent_)), ftrScanIsFingerPresent_)
                    ftrScanGetFrame = DirectCast(GetAddress(hModule, "ftrScanGetFrame", GetType(ftrScanGetFrame_)), ftrScanGetFrame_)

                    ''''''''''''''''''''CREADO
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Sub

        End Class



#Region "Compartido"
        Private Shared Function GetAddress(ByVal dllModule As IntPtr, ByVal functionname As String, ByVal t As System.Type) As [Delegate]
            Try
                Dim addr As IntPtr = GetProcAddress(dllModule, functionname)
                Return If(addr = IntPtr.Zero, Nothing, Marshal.GetDelegateForFunctionPointer(addr, t))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Function
#End Region


        Public Class BITMAPFILEHEADER
            Private bfType As UShort
            Private m_bfSize As UInteger
            Private bfReserved1 As UShort
            Private bfReserved2 As UShort
            Private m_bfOffBits As UInteger

            Public Sub New()
                'bfType = CUShort("B" + "M") * &H100
                bfType = 19778
                bfReserved1 = bfReserved2 = 0
            End Sub
            Public ReadOnly Property SizeOfBFH() As Integer
                Get
                    Return (Marshal.SizeOf(bfType) + Marshal.SizeOf(m_bfSize) + Marshal.SizeOf(bfReserved1) + Marshal.SizeOf(bfReserved2) + Marshal.SizeOf(m_bfOffBits))
                End Get
            End Property
            Public WriteOnly Property BfSize() As UInteger
                Set(ByVal value As UInteger)
                    m_bfSize = value
                End Set
            End Property
            Public WriteOnly Property BfOffBits() As UInteger
                Set(ByVal value As UInteger)
                    m_bfOffBits = value
                End Set
            End Property
            Public Function GetByteData() As Byte()
                Dim m_Data As Byte() = New Byte(SizeOfBFH - 1) {}
                Dim temp As Byte() = System.BitConverter.GetBytes(bfType)
                Dim offset As Integer = 0
                Array.Copy(temp, 0, m_Data, 0, temp.Length)
                offset = temp.Length
                temp = System.BitConverter.GetBytes(m_bfSize)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(bfReserved1)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(bfReserved2)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(m_bfOffBits)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                Return m_Data
            End Function
            Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
                target = value
                Return value
            End Function
        End Class

        Public Class RGBQUAD
            Private m_rgbBlue As Byte
            Private m_rgbGreen As Byte
            Private m_rgbRed As Byte
            Private rgbReserved As Byte

            Public Sub New()
                rgbReserved = 0
            End Sub
            Public ReadOnly Property SizeOfRgbquad() As Integer
                Get
                    Return (Marshal.SizeOf(m_rgbBlue) + Marshal.SizeOf(m_rgbGreen) + Marshal.SizeOf(m_rgbRed) + Marshal.SizeOf(rgbReserved))
                End Get
            End Property
            Public WriteOnly Property RGBBlue() As Byte
                Set(ByVal value As Byte)
                    m_rgbBlue = value
                End Set
            End Property
            Public WriteOnly Property RGBGreen() As Byte
                Set(ByVal value As Byte)
                    m_rgbGreen = value
                End Set
            End Property
            Public WriteOnly Property RGBRed() As Byte
                Set(ByVal value As Byte)
                    m_rgbRed = value
                End Set
            End Property
            Public Function GetGRBTableByteData() As Byte()
                Dim m_Data As Byte() = New Byte(256 * SizeOfRgbquad - 1) {}
                Dim nOffset As Integer = 0
                For i As Integer = 0 To 255
                    m_Data(nOffset) = CByte(i)
                    m_Data(nOffset + 1) = CByte(i)
                    m_Data(nOffset + 2) = CByte(i)
                    m_Data(nOffset + 3) = 0
                    nOffset += 4
                Next
                Return m_Data
            End Function
        End Class

        Public Class BITMAPINFOHEADER
            Private m_biSize As UInteger
            Private m_biWidth As Integer
            Private m_biHeight As Integer
            Private biPlanes As UShort
            Private biBitCount As UShort
            Private biCompression As UInteger
            Private biSizeImage As UInteger
            Private m_biXPelsPerMeter As Integer
            Private m_biYPelsPerMeter As Integer
            Private biClrUsed As UInteger
            Private biClrImportant As UInteger

            Public Sub New()
                biPlanes = 1
                biBitCount = 8
                biCompression = 0
                'BI_RGB; #define BI_RGB        0L
                biSizeImage = 0
                biClrUsed = biClrImportant = 0
                m_biXPelsPerMeter = &H4CE6
                '500DPI
                m_biYPelsPerMeter = &H4CE6
                '500DPI
                m_biSize = CUInt(SizeOfBIH)
            End Sub
            Public ReadOnly Property SizeOfBIH() As Integer
                Get
                    Return (Marshal.SizeOf(m_biSize) + Marshal.SizeOf(m_biWidth) + Marshal.SizeOf(m_biHeight) + Marshal.SizeOf(biPlanes) + Marshal.SizeOf(biBitCount) + Marshal.SizeOf(biCompression) + Marshal.SizeOf(biSizeImage) + Marshal.SizeOf(m_biXPelsPerMeter) + Marshal.SizeOf(m_biYPelsPerMeter) + Marshal.SizeOf(biClrUsed) + Marshal.SizeOf(biClrImportant))
                End Get
            End Property
            Public Property BiSize() As UInteger
                Get
                    Return m_biSize
                End Get
                Set(ByVal value As UInteger)
                    m_biSize = value
                End Set
            End Property
            Public WriteOnly Property BiWidth() As Integer
                Set(ByVal value As Integer)
                    m_biWidth = value
                End Set
            End Property
            Public WriteOnly Property BiHeight() As Integer
                Set(ByVal value As Integer)
                    m_biHeight = value
                End Set
            End Property
            Public WriteOnly Property BiXPelsPerMeter() As Integer
                Set(ByVal value As Integer)
                    m_biXPelsPerMeter = value
                End Set
            End Property
            Public WriteOnly Property BiYPelsPerMeter() As Integer
                Set(ByVal value As Integer)
                    m_biYPelsPerMeter = value
                End Set
            End Property
            Public Function GetByteData() As Byte()
                Dim m_Data As Byte() = New Byte(SizeOfBIH - 1) {}
                Dim temp As Byte() = System.BitConverter.GetBytes(m_biSize)
                Dim offset As Integer = 0
                Array.Copy(temp, 0, m_Data, 0, temp.Length)
                offset = temp.Length
                temp = System.BitConverter.GetBytes(m_biWidth)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(m_biHeight)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(biPlanes)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(biBitCount)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(biCompression)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(biSizeImage)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(m_biXPelsPerMeter)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(m_biYPelsPerMeter)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(biClrUsed)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                offset += temp.Length
                temp = System.BitConverter.GetBytes(biClrImportant)
                Array.Copy(temp, 0, m_Data, offset, temp.Length)
                Return m_Data
            End Function
            Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
                target = value
                Return value
            End Function
        End Class

        Public Class BITMAPINFO
            Public bmiHeader As BITMAPINFOHEADER
            Public bmiColors As RGBQUAD

            Public Sub New()
                bmiHeader = New BITMAPINFOHEADER()
                bmiColors = New RGBQUAD()
            End Sub
            Protected Overrides Sub Finalize()
                Try
                    bmiHeader = Nothing
                    bmiColors = Nothing
                Finally
                    MyBase.Finalize()
                End Try
            End Sub
            Public ReadOnly Property SizeOfBI() As Integer
                Get
                    Return (bmiHeader.SizeOfBIH + bmiColors.SizeOfRgbquad * 256)
                End Get
            End Property
        End Class

        Public Class MyBitmapFile
            Private m_fileHeaderBitmap As BITMAPFILEHEADER
            Private m_infoBitmap As BITMAPINFO
            Private m_BmpData As Byte()

            Public Sub MyBitmapFile()
                m_fileHeaderBitmap = New BITMAPFILEHEADER()
                m_infoBitmap = New BITMAPINFO()
            End Sub
            Protected Overrides Sub Finalize()
                Try
                    m_BmpData = Nothing
                    m_fileHeaderBitmap = Nothing
                    m_infoBitmap = Nothing
                    GC.Collect()
                Finally
                    MyBase.Finalize()
                End Try
            End Sub

            Public Sub MyBitmapFile(ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal pImage As Byte())
                m_fileHeaderBitmap = New BITMAPFILEHEADER()
                m_infoBitmap = New BITMAPINFO()

                Dim length As Integer = m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI + nWidth * nHeight
                m_fileHeaderBitmap.BfSize = CUInt(length)
                m_fileHeaderBitmap.BfOffBits = CUInt(m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI)
                m_infoBitmap.bmiHeader.BiWidth = nWidth
                m_infoBitmap.bmiHeader.BiHeight = nHeight

                m_BmpData = New Byte(length - 1) {}
                Dim TempData As Byte() = m_fileHeaderBitmap.GetByteData()
                Array.Copy(TempData, 0, m_BmpData, 0, TempData.Length)
                Dim offset As Integer = TempData.Length
                TempData = m_infoBitmap.bmiHeader.GetByteData()
                Array.Copy(TempData, 0, m_BmpData, offset, TempData.Length)
                offset += TempData.Length
                TempData = m_infoBitmap.bmiColors.GetGRBTableByteData()
                Array.Copy(TempData, 0, m_BmpData, offset, TempData.Length)
                offset += TempData.Length
                'rotate image
                Dim pRotateImage As Byte() = New Byte(nWidth * nHeight - 1) {}
                Dim nImgOffset As Integer = 0
                For iCyc As Integer = 0 To nHeight - 1
                    Array.Copy(pImage, (nHeight - iCyc - 1) * nWidth, pRotateImage, nImgOffset, nWidth)
                    nImgOffset += nWidth
                Next
                Array.Copy(pRotateImage, 0, m_BmpData, offset, pRotateImage.Length)
                TempData = Nothing
                pRotateImage = Nothing
            End Sub

            Public Sub MyBitmapFile(ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal pImage As IntPtr)
                m_fileHeaderBitmap = New BITMAPFILEHEADER()
                m_infoBitmap = New BITMAPINFO()

                Dim length As Integer = m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI + nWidth * nHeight
                m_fileHeaderBitmap.BfSize = CUInt(length)
                m_fileHeaderBitmap.BfOffBits = CUInt(m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI)
                m_infoBitmap.bmiHeader.BiWidth = nWidth
                m_infoBitmap.bmiHeader.BiHeight = nHeight

                m_BmpData = New Byte(length - 1) {}
                Dim TempData As Byte() = m_fileHeaderBitmap.GetByteData()
                Array.Copy(TempData, 0, m_BmpData, 0, TempData.Length)
                Dim offset As Integer = TempData.Length
                TempData = m_infoBitmap.bmiHeader.GetByteData()
                Array.Copy(TempData, 0, m_BmpData, offset, TempData.Length)
                offset += TempData.Length
                TempData = m_infoBitmap.bmiColors.GetGRBTableByteData()
                Array.Copy(TempData, 0, m_BmpData, offset, TempData.Length)
                offset += TempData.Length
                'rotate image
                Dim pRotateImage As Byte() = New Byte(nWidth * nHeight - 1) {}
                Dim nImgOffset As Integer = 0
                Dim pPtr As IntPtr

                For iCyc As Integer = 0 To nHeight - 1
                    pPtr = New IntPtr(pImage.ToInt32() + (nHeight - iCyc - 1) * nWidth)
                    Marshal.Copy(pPtr, pRotateImage, nImgOffset, nWidth)
                    'Array.Copy(pImage, (nHeight - iCyc - 1) * nWidth, pRotateImage, nImgOffset, nWidth);
                    nImgOffset += nWidth
                Next
                Array.Copy(pRotateImage, 0, m_BmpData, offset, pRotateImage.Length)
                TempData = Nothing
                pRotateImage = Nothing
            End Sub

            Public ReadOnly Property BitmatFileData() As Byte()
                Get
                    Return m_BmpData
                End Get
            End Property

        End Class


        Public Structure FTRSCAN_IMAGE_SIZE
            Public nWidth As Integer
            Public nHeight As Integer
            Public nImageSize As Integer
        End Structure

        Public Class ANSI_ISO_ftrNativeLib
            Public Const FTR_ERROR_SUCCESS As Integer = 0
            Public Const FTR_ERROR_EMPTY_FRAME As Integer = 4306
            Public Const FTR_ERROR_MOVABLE_FINGER As Integer = &H20000001
            Public Const FTR_ERROR_NO_FRAME As Integer = &H20000002
            Public Const FTR_ERROR_USER_CANCELED As Integer = &H20000003
            Public Const FTR_ERROR_HARDWARE_INCOMPATIBLE As Integer = &H20000004
            Public Const FTR_ERROR_FIRMWARE_INCOMPATIBLE As Integer = &H20000005
            Public Const FTR_ERROR_INVALID_AUTHORIZATION_CODE As Integer = &H20000006
            Public Const FTR_ERROR_ROLL_NOT_STARTED As Integer = &H20000007
            Public Const FTR_ERROR_ROLL_PROGRESS_DATA As Integer = &H20000008
            Public Const FTR_ERROR_ROLL_TIMEOUT As Integer = &H20000009
            Public Const FTR_ERROR_ROLL_ABORTED As Integer = &H2000000A
            Public Const FTR_ERROR_ROLL_ALREADY_STARTED As Integer = &H2000000B
            Public Const FTR_ERROR_NO_MORE_ITEMS As Integer = 259
            Public Const FTR_ERROR_NOT_ENOUGH_MEMORY As Integer = 8
            Public Const FTR_ERROR_NO_SYSTEM_RESOURCES As Integer = 1450
            Public Const FTR_ERROR_TIMEOUT As Integer = 1460
            Public Const FTR_ERROR_NOT_READY As Integer = 21
            Public Const FTR_ERROR_BAD_CONFIGURATION As Integer = 1610
            Public Const FTR_ERROR_INVALID_PARAMETER As Integer = 87
            Public Const FTR_ERROR_CALL_NOT_IMPLEMENTED As Integer = 120
            Public Const FTR_ERROR_NOT_SUPPORTED As Integer = 50
            Public Const FTR_ERROR_WRITE_PROTECT As Integer = 19
            Public Const FTR_ERROR_MESSAGE_EXCEEDS_MAX_SIZE As Integer = 4336

            Public Const FTR_ANSISDK_ERROR_IMAGE_SIZE_NOT_SUP As Integer = &H30000001
            Public Const FTR_ANSISDK_ERROR_EXTRACTION_UNSPEC As Integer = &H30000002
            Public Const FTR_ANSISDK_ERROR_EXTRACTION_BAD_IMP As Integer = &H30000003
            Public Const FTR_ANSISDK_ERROR_MATCH_NULL As Integer = &H30000004
            Public Const FTR_ANSISDK_ERROR_MATCH_PARSE_PROBE As Integer = &H30000005
            Public Const FTR_ANSISDK_ERROR_MATCH_PARSE_GALLERY As Integer = &H30000006
            Public Const FTR_ANSISDK_ERROR_MORE_DATA As Integer = &H30000007


            <DllImport("ftrScanAPI.dll", SetLastError:=True)>
            Public Shared Function ftrScanOpenDevice() As IntPtr
            End Function

            <DllImport("ftrScanAPI.dll", SetLastError:=True)>
            Public Shared Sub ftrScanCloseDevice(ByVal hDevice As IntPtr)
            End Sub

            <DllImport("ftrScanAPI.dll", SetLastError:=True)>
            Public Shared Function ftrScanGetImageSize(ByVal hDevice As IntPtr, ByRef pImageSize As FTRSCAN_IMAGE_SIZE) As Boolean
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkCaptureImage(ByVal hDevice As IntPtr, ByVal pBuffer As Byte()) As Boolean
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkGetMaxTemplateSize() As Integer
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkCreateTemplate(ByVal hDevice As IntPtr, ByVal byFingerPosition As Byte, ByVal pOutImageBuffer As Byte(), ByVal pOutTemplate As Byte(), ByRef pnOutTemplateSize As Integer) As Boolean
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkCreateTemplateFromBuffer(ByVal hDevice As IntPtr, ByVal byFingerPosition As Byte, ByVal pImageBuffer As Byte(), ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal pOutTemplate As Byte(),
         ByRef pnOutTemplateSize As Integer) As Boolean
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkVerifyTemplate(ByVal hDevice As IntPtr, ByVal byFingerPosition As Byte, ByVal pInTemplate As Byte(), ByVal pOutImageBuffer As Byte(), ByRef pfOutResult As Single) As Boolean
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkMatchTemplates(ByVal pProbeTemplate As Byte(), ByVal pGaleryTemplate As Byte(), ByRef pfOutResult As Single) As Boolean
            End Function

            <DllImport("ftrAnsiSdk.dll", SetLastError:=True)>
            Public Shared Function ftrAnsiSdkConvertAnsiTemplateToIso(ByVal pTemplateANSI As Byte(), ByVal pTemplateIso As Byte(), ByRef pnInOutTemplateSize As Integer) As Boolean
            End Function

        End Class
    End Class
End Namespace