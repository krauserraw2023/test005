Imports System.Runtime.InteropServices

Namespace Huellero.DLL.FS88H
    Public Class BITMAPFILEHEADER
        Private _bfType As UShort
        Private _bfSize As UInteger
        Private _bfReserved1 As UShort
        Private _bfReserved2 As UShort
        Private _bfOffBits As UInteger

        Public Sub New()
            _bfType = CShort(AscW("B")) + CShort(AscW("M")) * &H100
            _bfReserved1 = 0
            _bfReserved2 = 0
        End Sub

        Public ReadOnly Property SizeOfBFH As Integer
            Get
                Return (Marshal.SizeOf(_bfType) + Marshal.SizeOf(_bfSize) + Marshal.SizeOf(_bfReserved1) + Marshal.SizeOf(_bfReserved2) + Marshal.SizeOf(_bfOffBits))
            End Get
        End Property

        Public WriteOnly Property BfSize As UInteger
            Set(ByVal value As UInteger)
                _bfSize = value
            End Set
        End Property

        Public WriteOnly Property BfOffBits As UInteger
            Set(ByVal value As UInteger)
                _bfOffBits = value
            End Set
        End Property

        Public Function GetByteData() As Byte()
            Dim m_Data As Byte() = New Byte(SizeOfBFH - 1) {}
            Dim temp As Byte() = System.BitConverter.GetBytes(_bfType)
            Dim offset As Integer = 0
            Array.Copy(temp, 0, m_Data, 0, temp.Length)
            offset = temp.Length
            temp = System.BitConverter.GetBytes(_bfSize)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_bfReserved1)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_bfReserved2)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_bfOffBits)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            Return m_Data
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class RGBQUAD
        Private _rgbBlue As Byte
        Private _rgbGreen As Byte
        Private _rgbRed As Byte
        Private _rgbReserved As Byte

        Public Sub New()
            _rgbReserved = 0
        End Sub

        Public ReadOnly Property SizeOfRgbquad As Integer
            Get
                Return (Marshal.SizeOf(_rgbBlue) + Marshal.SizeOf(_rgbGreen) + Marshal.SizeOf(_rgbRed) + Marshal.SizeOf(_rgbReserved))
            End Get
        End Property

        Public WriteOnly Property RGBBlue As Byte
            Set(ByVal value As Byte)
                _rgbBlue = value
            End Set
        End Property

        Public WriteOnly Property RGBGreen As Byte
            Set(ByVal value As Byte)
                _rgbGreen = value
            End Set
        End Property

        Public WriteOnly Property RGBRed As Byte
            Set(ByVal value As Byte)
                _rgbRed = value
            End Set
        End Property

        Public Function GetGRBTableByteData() As Byte()
            Dim m_Data As Byte() = New Byte(256 * SizeOfRgbquad - 1) {}
            Dim nOffset As Integer = 0

            For i As Integer = 0 To 256 - 1
                m_Data(nOffset) = CByte(i)
                m_Data(nOffset + 1) = CByte(i)
                m_Data(nOffset + 2) = CByte(i)
                m_Data(nOffset + 3) = 0
                nOffset += 4
            Next

            Return m_Data
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class BITMAPINFOHEADER
        Private _biSize As UInteger
        Private _biWidth As Integer
        Private _biHeight As Integer
        Private _biPlanes As UShort
        Private _biBitCount As UShort
        Private _biCompression As UInteger
        Private _biSizeImage As UInteger
        Private _biXPelsPerMeter As Integer
        Private _biYPelsPerMeter As Integer
        Private _biClrUsed As UInteger
        Private _biClrImportant As UInteger

        Public Sub New()
            _biPlanes = 1
            _biBitCount = 8
            _biCompression = 0
            _biSizeImage = 0
            _biClrUsed = 0
            _biClrImportant = 0
            _biXPelsPerMeter = &H4CE6
            _biYPelsPerMeter = &H4CE6
            _biSize = CUInt(SizeOfBIH)
        End Sub

        Public ReadOnly Property SizeOfBIH As Integer
            Get
                Return (Marshal.SizeOf(_biSize) + Marshal.SizeOf(_biWidth) + Marshal.SizeOf(_biHeight) + Marshal.SizeOf(_biPlanes) + Marshal.SizeOf(_biBitCount) + Marshal.SizeOf(_biCompression) + Marshal.SizeOf(_biSizeImage) + Marshal.SizeOf(_biXPelsPerMeter) + Marshal.SizeOf(_biYPelsPerMeter) + Marshal.SizeOf(_biClrUsed) + Marshal.SizeOf(_biClrImportant))
            End Get
        End Property

        Public Property BiSize As UInteger
            Get
                Return _biSize
            End Get
            Set(ByVal value As UInteger)
                _biSize = value
            End Set
        End Property

        Public WriteOnly Property BiWidth As Integer
            Set(ByVal value As Integer)
                _biWidth = value
            End Set
        End Property

        Public WriteOnly Property BiHeight As Integer
            Set(ByVal value As Integer)
                _biHeight = value
            End Set
        End Property

        Public WriteOnly Property BiXPelsPerMeter As Integer
            Set(ByVal value As Integer)
                _biXPelsPerMeter = value
            End Set
        End Property

        Public WriteOnly Property BiYPelsPerMeter As Integer
            Set(ByVal value As Integer)
                _biYPelsPerMeter = value
            End Set
        End Property

        Public Function GetByteData() As Byte()
            Dim m_Data As Byte() = New Byte(SizeOfBIH - 1) {}
            Dim temp As Byte() = System.BitConverter.GetBytes(_biSize)
            Dim offset As Integer = 0
            Array.Copy(temp, 0, m_Data, 0, temp.Length)
            offset = temp.Length
            temp = System.BitConverter.GetBytes(_biWidth)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biHeight)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biPlanes)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biBitCount)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biCompression)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biSizeImage)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biXPelsPerMeter)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biYPelsPerMeter)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biClrUsed)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            offset += temp.Length
            temp = System.BitConverter.GetBytes(_biClrImportant)
            Array.Copy(temp, 0, m_Data, offset, temp.Length)
            Return m_Data
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class BITMAPINFO
        Public bmiHeader As BITMAPINFOHEADER
        Public bmiColors As RGBQUAD

        Public Sub New()
            bmiHeader = New BITMAPINFOHEADER()
            bmiColors = New RGBQUAD()
        End Sub

        Protected Overrides Sub Finalize()
            bmiHeader = Nothing
            bmiColors = Nothing
        End Sub

        Public ReadOnly Property SizeOfBI As Integer
            Get
                Return (bmiHeader.SizeOfBIH + bmiColors.SizeOfRgbquad * 256)
            End Get
        End Property

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class

    Public Class MyBitmapFile
        Private m_fileHeaderBitmap As BITMAPFILEHEADER
        Private m_infoBitmap As BITMAPINFO
        Private m_BmpData As Byte()

        Public Sub New()
            m_fileHeaderBitmap = New BITMAPFILEHEADER()
            m_infoBitmap = New BITMAPINFO()
        End Sub

        Protected Overrides Sub Finalize()
            m_BmpData = Nothing
            m_fileHeaderBitmap = Nothing
            m_infoBitmap = Nothing
            GC.Collect()
        End Sub

        Public Sub New(ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal pImage As Byte())
            m_fileHeaderBitmap = New BITMAPFILEHEADER()
            m_infoBitmap = New BITMAPINFO()
            Dim length As Integer = m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI + nWidth * nHeight
            m_fileHeaderBitmap.BfSize = CUInt(length)
            m_fileHeaderBitmap.BfOffBits = CUInt((m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI))
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

        Public Sub New(ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal pImage As IntPtr)
            m_fileHeaderBitmap = New BITMAPFILEHEADER()
            m_infoBitmap = New BITMAPINFO()
            Dim length As Integer = m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI + nWidth * nHeight
            m_fileHeaderBitmap.BfSize = CUInt(length)
            m_fileHeaderBitmap.BfOffBits = CUInt((m_fileHeaderBitmap.SizeOfBFH + m_infoBitmap.SizeOfBI))
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
            Dim pRotateImage As Byte() = New Byte(nWidth * nHeight - 1) {}
            Dim nImgOffset As Integer = 0
            Dim pPtr As IntPtr

            For iCyc As Integer = 0 To nHeight - 1
                pPtr = CType((pImage.ToInt32() + (nHeight - iCyc - 1) * nWidth), IntPtr)
                Marshal.Copy(pPtr, pRotateImage, nImgOffset, nWidth)
                nImgOffset += nWidth
            Next

            Array.Copy(pRotateImage, 0, m_BmpData, offset, pRotateImage.Length)
            TempData = Nothing
            pRotateImage = Nothing
        End Sub

        Public ReadOnly Property BitmatFileData As Byte()
            Get
                Return m_BmpData
            End Get
        End Property

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
