Public Module RS_Error

    Public Const RS_SUCCESS As Long = 0

    ' Generic errors
    Public Const RS_ERR_SDK_UNINITIALIZED As Long = -10
    Public Const RS_ERR_SDK_ALREADY_INITIALIZED As Long = -11
    Public Const RS_ERR_INSUFFICIENT_HARDWARE As Long = -12
    Public Const RS_ERR_INVALID_PARAM As Long = -13
    Public Const RS_ERR_MEM_FULL As Long = -14
    Public Const RS_ERR_NOT_YET_SUPPORTED As Long = -15
    Public Const RS_ERR_CANNOT_OPEN_FILE As Long = -16
    Public Const RS_ERR_CANNOT_READ_FILE As Long = -17
    Public Const RS_ERR_CANNOT_WRITE_FILE As Long = -18

    ' Device related errors
    Public Const RS_ERR_NO_DEVICE As Long = -100
    Public Const RS_ERR_INVALID_DEVICE_INDEX As Long = -101
    Public Const RS_ERR_INVALID_HANDLE As Long = -102
    Public Const RS_ERR_CANNOT_INIT_DEVICE As Long = -103
    Public Const RS_ERR_UNSUPPORTED_DEVICE As Long = -104
    Public Const RS_ERR_CANNOT_GET_USB_DEVICE As Long = -105
    Public Const RS_ERR_DEVICE_ALREADY_INITIALIZED As Long = -106
    Public Const RS_ERR_CANNOT_OPEN_DEVICE As Long = -107
    Public Const RS_ERR_CANNOT_WRITE_USB As Long = -108
    Public Const RS_ERR_WRITE_USB_TIMEOUT As Long = -109
    Public Const RS_ERR_CANNOT_READ_USB As Long = -110
    Public Const RS_ERR_READ_USB_TIMEOUT As Long = -111
    Public Const RS_ERR_INVALID_CAMERA_MODE As Long = -112
    Public Const RS_ERR_UNSUPPORTED_WAV_FORMAT As Long = -113
    Public Const RS_ERR_UNSUPPORTED_COMMAND As Long = -114
    Public Const RS_ERR_SENSOR_DIRTY As Long = -115
    Public Const RS_ERR_FINGER_EXIST As Long = -116
    Public Const RS_ERR_TOO_STRONG_LIGHT As Long = -117

    ' Capture related errors
    Public Const RS_ERR_INVALID_CAPTURE_MODE As Long = -200
    Public Const RS_ERR_CAPTURE_DISABLED As Long = -201
    Public Const RS_ERR_CAPTURE_TIMEOUT As Long = -202
    Public Const RS_ERR_CAPTURE_ABORTED As Long = -203
    Public Const RS_ERR_CAPTURE_CAMERA As Long = -204
    Public Const RS_ERR_CAPTURE_NO_PREVIEW As Long = -205
    Public Const RS_ERR_ROLL_PART_LIFT As Long = -206
    Public Const RS_ERR_ROLL_DIRTY As Long = -207
    Public Const RS_ERR_ROLL_TOO_FAST As Long = -208
    Public Const RS_ERR_ROLL_SHIFTED As Long = -209
    Public Const RS_ERR_ROLL_DRY As Long = -210
    Public Const RS_ERR_ROLL_WRONG_DIR As Long = -211
    Public Const RS_ERR_CAPTURE_IS_RUNNING As Long = -212
    Public Const RS_ERR_CAPTURE_IS_NOT_RUNNING As Long = -213
    Public Const RS_ERR_ROLL_TOO_SHORT As Long = -214
    Public Const RS_ERR_CANNOT_SEGMENT As Long = -215
    Public Const RS_ERR_CANNOT_GET_QUALITY As Long = -216
    Public Const RS_ERR_SEGMENT_FEWER_FINGER As Long = -217
    Public Const RS_ERR_SEGMENT_WRONG_HAND As Long = -218
    Public Const RS_ERR_CANNOT_EXTRACT_TEMPLATE As Long = -219
    Public Const RS_ERR_NO_MATCH As Long = -220


    ' Viewer related errors
    Public Const RS_ERR_CANNOT_SET_VIEW_WINDOW As Long = -300
    Public Const RS_ERR_NO_MORE_OVERLAY As Long = -301
    Public Const RS_ERR_INVALID_OVERLAY_HANDLE As Long = -302
    Public Const RS_ERR_CANNOT_SHOW_OVERLAY As Long = -303
    Public Const RS_ERR_CANNOT_SHOW_PREVIEW As Long = -304

    ' IO related errors
    Public Const RS_ERR_CANNOT_SET_KEYPAD_CALLBACK As Long = -400

End Module
