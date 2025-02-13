Imports System.Runtime.InteropServices
Imports APPControlHuellaVisita.Lector.Futronic.LoadDll.WSQ

Namespace Huellero.DLL.FS88H

    Public Structure FTRSCAN_IMAGE_SIZE
        Public nWidth As Integer
        Public nHeight As Integer
        Public nImageSize As Integer
    End Structure

    Class ftrNativeLib
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


        <DllImport("ftrWSQ.dll", SetLastError:=True)>
        Public Shared Function ftrWSQ_FromRawImage(ByVal hDevice As IntPtr, ByVal ftrRawBuf As Byte(), ByVal ftrImpar As FTRIMGPARMS, ByVal ftrWSQBuf As Byte()) As Boolean

        End Function

        '<DllImport("LibFutronicFS88H\\ftrScanAPI.dll", SetLastError:=True)>
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Function ftrScanOpenDevice() As IntPtr

        End Function
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Sub ftrScanCloseDevice(ByVal hDevice As IntPtr)

        End Sub
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Function ftrScanGetImageSize(ByVal hDevice As IntPtr, ByRef pImageSize As FTRSCAN_IMAGE_SIZE) As Boolean

        End Function
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Function ftrScanGetImage2(ByVal ftrHandle As Integer, ByVal NDose As Integer, ByVal pBuffer As Byte()) As Boolean

        End Function
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Function ftrScanGetDarkImage(ByVal ftrHandle As Integer, ByVal pBuffer As Byte()) As Boolean

        End Function
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Function ftrScanSetOptions(ByVal ftrHandle As Integer, ByVal options As UInteger, ByValdwFlags As Integer) As Boolean

        End Function
        <DllImport("ftrScanAPI.dll", SetLastError:=True)>
        Public Shared Function ftrScanSetDiodesStatus(ByVal hDevice As IntPtr, greenDiodeStatus As Byte, reedDiodeStatus As Byte) As Boolean

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
        Public Shared Function ftrAnsiSdkCreateTemplateFromBuffer(ByVal hDevice As IntPtr, ByVal byFingerPosition As Byte, ByVal pImageBuffer As Byte(), ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal pOutTemplate As Byte(), ByRef pnOutTemplateSize As Integer) As Boolean

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

        Public Shared Function GetErrorMessage(ByVal nError As Integer) As String
            Dim stError As String = Nothing

            Select Case nError
                Case FTR_ERROR_SUCCESS
                    stError = "OK"
                Case FTR_ERROR_EMPTY_FRAME
                    stError = "- Empty frame -"
                Case FTR_ERROR_MOVABLE_FINGER
                    stError = "- Movable finger -"
                Case FTR_ERROR_NO_FRAME
                    stError = "- No frame -"
                Case FTR_ERROR_USER_CANCELED
                    stError = "- User canceled -"
                Case FTR_ERROR_HARDWARE_INCOMPATIBLE
                    stError = "- Incompatible hardware -"
                Case FTR_ERROR_FIRMWARE_INCOMPATIBLE
                    stError = "- Incompatible firmware -"
                Case FTR_ERROR_INVALID_AUTHORIZATION_CODE
                    stError = "- Invalid authorization code -"
                Case FTR_ANSISDK_ERROR_IMAGE_SIZE_NOT_SUP
                    stError = "- Image size is not supported -"
                Case FTR_ANSISDK_ERROR_EXTRACTION_UNSPEC
                    stError = "- Unspecified extraction error -"
                Case FTR_ANSISDK_ERROR_EXTRACTION_BAD_IMP
                    stError = "- Incorrect impression type -"
                Case FTR_ANSISDK_ERROR_MATCH_NULL, FTR_ANSISDK_ERROR_MATCH_PARSE_PROBE, FTR_ANSISDK_ERROR_MATCH_PARSE_GALLERY
                    stError = "- Incorrect parameter -"
                Case Else
                    stError = String.Format("Unknown return code - %d", nError)
            End Select

            Return stError
        End Function
    End Class

End Namespace
