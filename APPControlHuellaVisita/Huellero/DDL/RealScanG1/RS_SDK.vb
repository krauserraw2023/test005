Imports System.Runtime.InteropServices

Public Module RS_SDK

    ' Device type
    Public Const RS_DEVICE_REALSCAN_10 As Long = &H0
    Public Const RS_DEVICE_REALSCAN_10F As Long = &H1
    Public Const RS_DEVICE_REALSCAN_D As Long = &H10
    Public Const RS_DEVICE_REALSCAN_DF As Long = &H11
    Public Const RS_DEVICE_REALSCAN_F As Long = &H20

    ' Initialization Mode
    Public Const RS_INIT_HIDE_INIDLG As Long = &H1
    Public Const RS_INIT_SHOW_INIDLG As Long = &H2
    Public Const RS_INIT_FULL As Long = &H4         ' full initialization of all parts

    ' Capture mode
    Public Const RS_CAPTURE_DISABLED As Long = &H0
    Public Const RS_CAPTURE_ROLL_FINGER As Long = &H1
    Public Const RS_CAPTURE_FLAT_SINGLE_FINGER As Long = &H2
    Public Const RS_CAPTURE_FLAT_TWO_FINGERS As Long = &H3
    Public Const RS_CAPTURE_FLAT_LEFT_FOUR_FINGERS As Long = &H4
    Public Const RS_CAPTURE_FLAT_RIGHT_FOUR_FINGERS As Long = &H5
    Public Const RS_CAPTURE_FLAT_LEFT_PALM As Long = &H6
    Public Const RS_CAPTURE_FLAT_RIGHT_PALM As Long = &H7

    Public Const RS_CAPTURE_FLAT_SINGLE_FINGER_EX As Long = &H12
    Public Const RS_CAPTURE_FLAT_TWO_FINGERS_EX As Long = &H13



    ' Options for capturing flat fingers
    Public Const RS_AUTO_SENSITIVITY_NORMAL As Long = &H0
    Public Const RS_AUTO_SENSITIVITY_HIGH As Long = &H1
    Public Const RS_AUTO_SENSITIVITY_HIGHER As Long = &H2

    ' Roll direction  
    Public Const RS_ROLL_DIR_L2R As Long = &H0
    Public Const RS_ROLL_DIR_R2L As Long = &H1
    Public Const RS_ROLL_DIR_AUTO As Long = &H2

    ' Roll profile
    Public Const RS_ROLL_PROFILE_LOW As Long = &H1
    Public Const RS_ROLL_PROFILE_NORMAL As Long = &H2
    Public Const RS_ROLL_PROFILE_HIGH As Long = &H3

    ' Text alignment
    Public Const RS_TEXT_ALIGN_LEFT As Long = &H0
    Public Const RS_TEXT_ALIGN_CENTER As Long = &H1
    Public Const RS_TEXT_ALIGN_RIGHT As Long = &H2

    ' Beeper pattern
    Public Const RS_BEEP_PATTERN_NONE As Long = 0
    Public Const RS_BEEP_PATTERN_1 As Long = 1  ' 1 short beep
    Public Const RS_BEEP_PATTERN_2 As Long = 2  ' 2 short beeps

    ' Keypad code
    Public Const RS_REALSCAN10_NO_KEY As Long = &H0
    Public Const RS_REALSCAN10_PLAY_KEY As Long = &H20
    Public Const RS_REALSCAN10_STOP_KEY As Long = &H40
    Public Const RS_REALSCAN10_ALL_KEYS As Long = &H7F

    Public Const RS_REALSCAND_NO_KEY As Long = &H0
    Public Const RS_REALSCAND_KEY_0 As Long = &H20
    Public Const RS_REALSCAND_ALL_KEYS As Long = &H7F

    ' Finger Index
    Public Const RS_FINGER_ALL As Long = &H0

    Public Const RS_FINGER_LEFT_LITTLE As Long = &H1
    Public Const RS_FINGER_LEFT_RING As Long = &H2
    Public Const RS_FINGER_LEFT_MIDDLE As Long = &H3
    Public Const RS_FINGER_LEFT_INDEX As Long = &H4
    Public Const RS_FINGER_LEFT_THUMB As Long = &H5

    Public Const RS_FINGER_RIGHT_THUMB As Long = &H6
    Public Const RS_FINGER_RIGHT_INDEX As Long = &H7
    Public Const RS_FINGER_RIGHT_MIDDLE As Long = &H8
    Public Const RS_FINGER_RIGHT_RING As Long = &H9
    Public Const RS_FINGER_RIGHT_LITTLE As Long = &HA

    Public Const RS_FINGER_TWO_THUMB As Long = &HB
    Public Const RS_FINGER_LEFT_FOUR As Long = &HC
    Public Const RS_FINGER_RIGHT_FOUR As Long = &HD

    ' Finger position for segmentation
    Public Const RS_FGP_UNKNOWN As Long = 0
    Public Const RS_FGP_RIGHT_THUMB As Long = 1
    Public Const RS_FGP_RIGHT_INDEX As Long = 2
    Public Const RS_FGP_RIGHT_MIDDLE As Long = 3
    Public Const RS_FGP_RIGHT_RING As Long = 4
    Public Const RS_FGP_RIGHT_LITTLE As Long = 5
    Public Const RS_FGP_LEFT_THUMB As Long = 6
    Public Const RS_FGP_LEFT_INDEX As Long = 7
    Public Const RS_FGP_LEFT_MIDDLE As Long = 8
    Public Const RS_FGP_LEFT_RING As Long = 9
    Public Const RS_FGP_LEFT_LITTLE As Long = 10
    Public Const RS_FGP_PLAIN_RIGHT_THUMB As Long = 11
    Public Const RS_FGP_PLAIN_LEFT_THUMB As Long = 12
    Public Const RS_FGP_PLAIN_RIGHT_FOUR As Long = 13
    Public Const RS_FGP_PLAIN_LEFT_FOUR As Long = 14
    Public Const RS_FGP_PLAIN_TWO_THUMBS As Long = 15
    Public Const RS_FGP_EJI_OR_TIP As Long = 16

    ' LED for RealScan-10
    Public Const RS_LED_MODE_ALL As Long = &H0
    Public Const RS_LED_MODE_LEFT_FINGER4 As Long = &H1
    Public Const RS_LED_MODE_RIGHT_FINGER4 As Long = &H2
    Public Const RS_LED_MODE_TWO_THUMB As Long = &H3
    Public Const RS_LED_MODE_ROLL As Long = &H4
    Public Const RS_LED_POWER As Long = &H5

    Public Const RS_LED_OFF As Long = &H0
    Public Const RS_LED_GREEN As Long = &H1
    Public Const RS_LED_RED As Long = &H2
    Public Const RS_LED_YELLOW As Long = &H3

    ' Slap type
    Public Const RS_SLAP_LEFT_FOUR As Long = 1
    Public Const RS_SLAP_RIGHT_FOUR As Long = 2
    Public Const RS_SLAP_FOUR_FINGER As Long = 3
    Public Const RS_SLAP_TWO_THUMB As Long = 4
    Public Const RS_SLAP_TWO_FINGER As Long = 5
    Public Const RS_SLAP_ONE_FINGER As Long = 6

    ' Security level
    Public Const RS_SECURITY_1_TO_10000 As Long = &H3
    Public Const RS_SECURITY_1_TO_100000 As Long = &H4
    Public Const RS_SECURITY_1_TO_1000000 As Long = &H5
    Public Const RS_SECURITY_1_TO_10000000 As Long = &H6
    Public Const RS_SECURITY_1_TO_100000000 As Long = &H7

    ' Contrast enhancement
    Public Const RS_CONTRAST_ENHANCEMENT_DEFVALUE As Long = 0
    Public Const RS_CONTRAST_ENHANCEMENT_MAXVALUE As Long = 40

    ' Key
    Public Const RS_REALSCANF_NO_KEY As Byte = &H0
    Public Const RS_REALSCANF_UP_KEY As Byte = &H1
    Public Const RS_REALSCANF_DOWN_KEY As Byte = &H2
    Public Const RS_REALSCANF_LEFT_KEY As Byte = &H4
    Public Const RS_REALSCANF_RIGHT_KEY As Byte = &H5
    Public Const RS_REALSCANF_PLAY_KEY As Byte = &H20
    Public Const RS_REALSCANF_STOP_KEY As Byte = &H40
    Public Const RS_REALSCANF_FOOTSWITCH As Byte = &H80
    Public Const RS_REALSCANF_ALL_KEYS As Byte = &HFF

    'LCD Display
    Public Const RS_LCD_WIDTH_MAX As Long = 320
    Public Const RS_LCD_HEIGHT_MAX As Long = 240
    Public Const RS_LCD_DATA_SIZE_MAX As Long = 153600

    '==============================================================================================
    ' Data Structures
    '==============================================================================================
    ' Device information
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSDeviceInfo
        Dim deviceType As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim productName() As Byte      ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim deviceID() As Byte         ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim firmwareVersion() As Byte  ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim hardwareVersion() As Byte  ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim reserved() As Integer      ' 32
    End Structure

    ' SDK information
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSSDKInfo
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim product() As Byte      ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim version() As Byte      ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim buildDate() As Byte    ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim reserved() As Integer  ' 16
    End Structure

    Public Structure RECT
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure

    '==============================================================================================
    ' General API declarations
    '==============================================================================================
    Public Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
    Public Declare Function GetClientRect Lib "user32" (ByVal windowHandle As IntPtr, ByRef rect As RECT) As Boolean
    Public Declare Sub CopyMemFromPtr Lib "kernel32" Alias "RtlMoveMemory" (ByRef dstAddr As Byte, ByRef srcAddr As Byte, ByVal dataSize As Integer)

    '==============================================================================================
    ' RS_SDK API declarations
    '==============================================================================================
    ' Capture callback function
    Public Delegate Sub RSKeypadCallback(ByVal nDeviceHandle As Integer, ByVal KeyCode As UInteger)
    Public Delegate Sub RSRawCaptureCallback(ByVal nDeviceHandle As Integer, ByVal nErrorCode As Integer, ByRef pbyImgData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer)

    ' Device APIs
    Public Declare Function RS_InitSDK Lib "RS_SDK.dll" (ByVal configFilename As String, ByVal configOption As Integer, ByRef numOfDevice As Integer) As Integer
    Public Declare Function RS_InitDevice Lib "RS_SDK.dll" (ByVal deviceIndex As Integer, ByRef devicehandle As Integer) As Integer
    Public Declare Function RS_ExitDevice Lib "RS_SDK.dll" (ByVal devicehandle As Integer) As Integer
    Public Declare Function RS_ExitAllDevices Lib "RS_SDK.dll" () As Integer
    Public Declare Function RS_GetDeviceInfo Lib "RS_SDK.dll" (ByVal devicehandle As Integer, ByRef deviceInfo As RSDeviceInfo) As Integer

    ' Capture APIs
    Public Declare Function RS_SetCaptureMode Lib "RS_SDK.dll" (ByVal devicehandle As Integer, ByVal CaptureMode As Integer, ByVal captureOption As Integer, ByVal withModeLED As Boolean) As Integer
    Public Declare Function RS_RegisterCaptureDataCallback Lib "RS_SDK.dll" (ByVal devicehandle As Integer, ByVal fCallBack As RSRawCaptureCallback) As Integer

    Public Declare Function RS_GetImageSize Lib "RS_SDK.dll" (ByVal devicehandle As Integer, ByRef imageWidth As Integer, ByRef imageHeight As Integer) As Integer
    Public Declare Function RS_StartCapture Lib "RS_SDK.dll" (ByVal deviceHandle As Integer, ByVal autoCapture As Boolean, ByVal timeout As Integer) As Integer
    Public Declare Function RS_AbortCapture Lib "RS_SDK.dll" (ByVal deviceHandle As Integer) As Integer

    Public Declare Function RS_TakeImageData Lib "RS_SDK.dll" (ByVal devicehandle As Integer, ByVal timeout As Integer, ByRef imageData As Long, ByRef imageWidth As Integer, ByRef imageHeight As Integer) As Integer

    Public Declare Function RS_TakeCurrentImageData Lib "RS_SDK.dll" (ByVal deviceHandle As Integer, ByVal timeout As Integer, ByRef imageData As Long, ByRef imageWidth As Integer, ByRef imageHeight As Integer) As Integer

    ' VIEW APIs
    Public Declare Function RS_StopViewWindow Lib "RS_SDK.dll" (ByVal devicehandle As Integer) As Integer
    Public Declare Function RS_SetViewWindow2 Lib "RS_SDK.dll" (ByVal devicehandle As Integer, ByVal windowHandle As IntPtr, ByRef drawRectangle As RECT, ByVal autoContrast As Boolean) As Integer

    ' Misc.
    Public Declare Function RS_GetSDKInfo Lib "RS_SDK.dll" (ByRef sdkInfo As RSSDKInfo) As Integer
    Public Declare Function RS_GetErrString Lib "RS_SDK.dll" (ByVal errorCode As Integer, ByRef errorMsg As String) As Integer
    Public Declare Sub RS_FreeImageData Lib "RS_SDK.dll" (ByVal imageData As Long)
    Public Declare Function RS_SaveBitmap Lib "RS_SDK.dll" (ByRef imageData As Byte, ByVal imageWidth As Integer, ByVal imageHeight As Integer, ByVal filename As String) As Integer

    Public Declare Function RS_SaveBitmapMem Lib "RS_SDK.dll" (ByRef bypImgRawData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer, ByRef pbyBitmapImgData As Byte) As Integer

    Public Declare Function RS_Beep Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nBeepPattern As Integer) As Integer

    'Key
    Public Declare Function RS_SetActiveKey Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal KeyMask As UInteger) As Integer
    Public Declare Function RS_GetKeyStatus Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef KeyMask As UInteger) As Integer
    Public Declare Function RS_RegisterKeypadCallback Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal callback As RSKeypadCallback) As Integer

    Public Declare Function RS_GetRollFingerOption Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef nRollDirection As Integer, ByRef nRollTime As Integer, ByRef nRollProfile As Integer) As Integer
    Public Declare Function RS_SetRollFingerOption Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nRollDirection As Integer, ByVal nRollTime As Integer, ByVal nRollProfile As Integer) As Integer

    Public Declare Function RS_GetCaptureMode Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef nMode As Integer, ByRef nOption As Integer) As Integer

    Public Declare Function RS_GetAutomaticCalibrate Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef bMode As Boolean) As Integer
    Public Declare Function RS_SetAutomaticCalibrate Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal bMode As Boolean) As Integer

    Public Declare Function RS_GetAutomaticContrast Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef bMode As Boolean) As Integer
    Public Declare Function RS_SetAutomaticContrast Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal bMode As Boolean) As Integer

    Public Declare Function RS_GetManualContrast Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef nMode As Integer) As Integer
    Public Declare Function RS_SetManualContrast Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nMode As Integer) As Integer

    Public Declare Function RS_GetAdvancedContrastEnhancement Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef nMode As Boolean) As Integer
    Public Declare Function RS_SetAdvancedContrastEnhancement Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nMode As Boolean) As Integer

    Public Declare Function RS_GetPostProcessingEx Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef bContrastEnhancement As Boolean, ByRef bNoiseReduction As Boolean, ByRef nReductionLevel As Integer) As Integer
    Public Declare Function RS_SetPostProcessingEx Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal bContrastEnhancement As Boolean, ByVal bNoiseReduction As Boolean, ByVal nReductionLevel As Integer) As Integer

    Public Declare Function RS_SetModeLED Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nLEDIdx As Integer, ByVal bIsOn As Boolean) As Integer
    Public Declare Function RS_SetFingerLED Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nFingerIdx As Integer, ByVal nLEDColor As Integer) As Integer
    Public Declare Function RS_SetStatusLED Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal nLEDColor As Integer) As Integer

    Public Declare Function RS_PlayWav Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByVal strWaveFile As String) As Integer

    Public Declare Function RS_ResetLCD Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer) As Integer
    Public Declare Function RS_DisplayLCD Lib "RS_SDK.dll" (ByVal nDeviceHandle As Integer, ByRef pbyData As Byte, ByVal nDataLen As Integer, ByVal nSX As Integer, ByVal nSY As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer) As Integer

    Public Declare Function RS_MakeLCDData Lib "RS_SDK.dll" (ByRef pbyRData As Byte, ByRef pbyGData As Byte, ByRef pbyBData As Byte, ByVal nWidth As Integer, ByVal nHeight As Integer, ByRef ppbyData As Byte) As Integer

End Module
