Imports System.Runtime.InteropServices

Public Module RSE_SDK
    'Tipos de Templates
    Public Const RSE_TEMP_ORIGINAL As Integer = 0
    Public Const RSE_TEMP_ISO19794_2 As Integer = 1
    Public Const RSE_TEMP_ANSI378 As Integer = 2
    'Security level
    Public Const RSE_SECURITY_1_TO_100 As Integer = 1
    Public Const RSE_SECURITY_1_TO_1000 As Integer = 2
    Public Const RSE_SECURITY_1_TO_10000 As Integer = 3
    Public Const RSE_SECURITY_1_TO_100000 As Integer = 4
    Public Const RSE_SECURITY_1_TO_1000000 As Integer = 5
    Public Const RSE_SECURITY_1_TO_10000000 As Integer = 6
    Public Const RSE_SECURITY_1_TO_100000000 As Integer = 7


    '==============================================================================================
    ' Estructuras de Datos
    '==============================================================================================
    ' información del SDK 
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSESSDKInfo
        Dim deviceType As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim product() As Byte          ' 32
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim version() As Byte          ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim buildDate() As Byte        ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim reserved() As Integer      ' 16
    End Structure

    ' información del dispositivo

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSEDeviceInfo
        Dim deviceType As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim productName() As Byte      ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim deviceID() As Byte         ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim firmwareVersion() As Byte  ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=16)> Dim hardwareVersion() As Byte  ' 16
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=32)> Dim reserved() As Integer      ' 32
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSEPoint
        Dim x As Integer
        Dim y As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSESlapInfo
        Dim fingerType As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=4)> Dim fingerPosition() As RSEPoint
        Dim imageQuality As Integer
        Dim rotation As Integer
        <MarshalAs(UnmanagedType.ByValArray, SizeConst:=3)> Dim reserved() As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure RSESlapInfoArray
        Dim RSSlapInfoA As RSESlapInfo()
    End Structure


    '==============================================================================================
    ' RSE_SDK API declaraciones
    '==============================================================================================
    'API General
    Public Declare Function RSE_InitSDK Lib "RSE_SDK.dll" () As Integer
    Public Declare Function RSE_GetSDKInfo Lib "RSE_SDK.dll" (ByRef sdkInfo As RSESSDKInfo) As Integer
    Public Declare Sub RSE_FreeMemory Lib "RSE_SDK.dll" (ByVal dataPtr As Long)
    'API de Segmentación
    Public Declare Function RSE_SegmentSlapMem Lib "RSE_SDK.dll" (ByVal slapImageBuffer As Byte(), ByVal bufferLen As Integer,
                                                                  ByVal slapType As Integer, ByRef numOfFinger As Integer,
                                                                  ByRef slapInfoArray As IntPtr, ByVal extractImage As Boolean,
                                                                  ByRef fingerImageBuffer As Long,
                                                                  ByRef fingerImageBufferLen As Long) As Integer
    Public Declare Function RSE_SequenceCheck Lib "RSE_SDK.dll" (ByVal numOfFinger As Integer, ByVal fingerImageFile As String(), ByVal slapImageFile As String, ByVal slapType As Integer, ByVal fingerSequenceInSlap As Integer()) As Integer
    Public Declare Function RSE_GetQualityScore Lib "RSE_SDK.dll" (ByVal fileName As String, ByRef qualityScore As Integer) As Integer
    Public Declare Function RSE_GetQualityScoreMem Lib "RSE_SDK.dll" (ByVal imageBuffer As Byte(), ByVal bufferLen As Integer, ByRef qualityScore As Integer) As Integer
    'API verificación, extracción de templates
    Public Declare Function RSE_VerifyImageEx Lib "RSE_SDK.dll" (ByVal targetImageFile As String, ByVal referenceImageFile As String, ByVal securityLevel As Integer) As Integer
    Public Declare Function RSE_VerifyImageDataEx Lib "RSE_SDK.dll" (ByVal targetImageData As Byte(), ByVal targetImageWidth As Integer, ByVal targetImageHeight As Integer, ByVal refImageData As Byte(), ByVal refImageWidth As Integer, ByVal refImageHeight As Integer, ByVal securityLevel As Integer) As Integer
    Public Declare Function RSE_VerifyTemplateEx Lib "RSE_SDK.dll" (ByVal targetTemplateBuffer As Byte(), ByVal targetTemplateLen As Integer, ByVal refTemplateBuffer As Byte(), ByVal refTemplateLen As Integer, ByVal templateType As Integer, ByVal securityLevel As Integer) As Integer
    Public Declare Function RSE_ExtractTemplateEx Lib "RSE_SDK.dll" (ByVal inImageDate As Byte(), ByVal inImageWidth As Integer, ByVal inImageHeigh As Integer, ByVal fingerPosition As Integer, ByVal templateType As Integer, ByRef templateBuffer As Long, ByRef templateLen As Integer) As Integer
    'API de Imágenes
    Public Declare Function RSE_CompressWSQ Lib "RSE_SDK.dll" (ByVal imageFile As String, ByVal comment As String, ByVal ratio As Single, ByVal wsqFile As String) As Integer
    Public Declare Function RSE_CompressWSQMem Lib "RSE_SDK.dll" (ByVal imageBuffer As Byte(), ByVal imageBufferLen As Integer, ByVal comment As String, ByVal ratio As Single, ByRef wsqData As Long, ByRef wsqDataLen As Integer) As Integer
    Public Declare Function RSE_DecompressWSQBMP Lib "RSE_SDK.dll" (ByVal wsqFile As String, ByVal bmpFile As String) As Integer
    Public Declare Function RSE_CompressWSQBuffer Lib "RSE_SDK.dll" (ByVal imageFile As String, ByVal comment As String, ByVal ratio As Integer, ByRef wsqData As Long, ByRef wsqDataLen As Integer) As Integer
    Public Declare Function RSE_ReadImageData Lib "RSE_SDK.dll" (ByVal strFilename As String, ByRef ptrRawImgData As Long, ByRef iRawImgWidth As Integer, ByRef iRawImgHeight As Integer) As Integer

End Module
