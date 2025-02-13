﻿Public Class Utilidad
    Public Enum enmError
        kNO_ERROR = 0
        kNOT_CONNECTED_DEVICE = 2
        kNOT_ENOUGH_MEMORY = 8
        kWRITE_PROTECT = 19
        kNOT_READY = 21
        kNOT_SUPPORTED = 50
        kINVALID_PARAMETER = 87
        kCALL_NOT_IMPLEMENTED = 120
        kNO_MORE_ITEMS = 259
        kNO_SYSTEM_RESOURCES = 1450
        kTIMEOUT = 1460
        kBAD_CONFIGURATION = 1610
        kEMPTY_FRAME = 4306
        kMESSAGE_EXCEEDS_MAX_SIZE = 4336
        kMOVABLE_FINGER = 536870913
        kNO_FRAME = 536870914
        kUSER_CANCELED = 536870915
        kHARDWARE_INCOMPATIBLE = 536870916
        kFIRMWARE_INCOMPATIBLE = 536870917
        kINVALID_AUTHORIZATION_CODE = 536870918
        kROLL_NOT_STARTED = 536870919
        kROLL_PROGRESS_DATA = 536870920
        kROLL_TIMEOUT = 536870921
        kROLL_ABORTED = 536870922
        kROLL_ALREADY_STARTED = 536870923
        kROLL_PROGRESS_REMOVE_FINGER = 536870924
        kROLL_PROGRESS_PUT_FINGER = 536870925
        kROLL_PROGRESS_POST_PROCESSING = 536870926
    End Enum

    Public Enum enmDispositivoCompatibilidad
        FTR_DEVICE_UNKNOWN_TYPE = 0
        FTR_DEVICE_USB_2_0_TYPE_FS1 = 1
        FTR_DEVICE_USB_2_0_TYPE_FS2 = 4
        FTR_DEVICE_USB_2_0_TYPE_FS3 = 5
        FTR_DEVICE_USB_2_0_TYPE_FS50 = 7
        FTR_DEVICE_USB_2_0_TYPE_FS60 = 8
        FTR_DEVICE_USB_2_0_TYPE_FS25 = 9
        FTR_DEVICE_USB_2_0_TYPE_FS10 = 10
        FTR_DEVICE_USB_2_0_TYPE_FS80W = 11
        FTR_DEVICE_USB_2_0_TYPE_FS80H = 13
        FTR_DEVICE_USB_2_0_TYPE_FS88H = 14
        FTR_DEVICE_USB_2_0_TYPE_FS64 = 15
    End Enum



End Class
