Public Module RSE_Error

    Public Const RSE_SUCCESS As Long = 0

    Public Const RSE_ERR_NO_DEVICE As Long = -100
    Public Const RSE_ERR_INVALID_PARAM As Long = -101
    Public Const RSE_ERR_CANNOT_READ_FILE As Long = -102
    Public Const RSE_ERR_CANNOT_WRITE_FILE As Long = -103
    Public Const RSE_ERR_UNSUPPORTED_FILE As Long = -104
    Public Const RSE_ERR_MEM_FULL As Long = -105

    Public Const RSE_ERR_CANNOT_SEGMENT As Long = -200
    Public Const RSE_ERR_CANNOT_GET_QUALITY As Long = -201
    Public Const RSE_ERR_NO_MATCH As Long = -202
    Public Const RSE_ERR_CANNOT_EXTRACT_TEMPLATE As Long = -203
    Public Const RSE_ERR_SEGMENT_WRONG_HAND As Long = -204
    Public Const RSE_ERR_SEGMENT_FEWER_FINGER As Long = -205

    Public Const RSE_ERR_CANNOT_GET_CONTRAST As Long = -280
    Public Const RSE_ERR_CANNOT_COMPRESS_WSQ As Long = -300
    Public Const RSE_ERR_CANNOT_DECOMPRESS_WSQ As Long = -301
    Public Const RSE_ERR_CANNOT_WRITE_WSQ_FILE As Long = -302
    Public Const RSE_ERR_WSQ_SIZE_LIMIT As Long = -303

    Public Const RSE_ERR_CANNOT_CREATE_ANSI_FILE As Long = -400
    Public Const RSE_ERR_CANNOT_READ_ANSI_FILE As Long = -401
    Public Const RSE_ERR_CANNOT_WRITE_ANSI_FILE As Long = -402

    Public Const RSE_ERR_CANNOT_CREATE_RECORD As Long = -403
    Public Const RSE_ERR_CANNOT_READ_RECORD As Long = -404
    Public Const RSE_ERR_CANNOT_WRITE_RECORD As Long = -405
    Public Const RSE_ERR_CANNOT_INSERT_RECORD As Long = -406
    Public Const RSE_ERR_CANNOT_DELETE_RECORD As Long = -407
    Public Const RSE_ERR_CANNOT_UPDATE_RECORD As Long = -408

    Public Const RSE_ERR_CANNOT_CREATE_FIELD As Long = -409
    Public Const RSE_ERR_CANNOT_APPEND_FIELD As Long = -410
    Public Const RSE_ERR_CANNOT_CREATE_SUBFIELD As Long = -411
    Public Const RSE_ERR_CANNOT_APPEND_SUBFIELD As Long = -412
    Public Const RSE_ERR_CANNOT_CREATE_ITEM As Long = -413
    Public Const RSE_ERR_CANNOT_APPEND_ITEM As Long = -414

End Module
