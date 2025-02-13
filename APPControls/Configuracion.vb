Public Class Configuracion
    Public Class Aplication
        Public Shared ReadOnly Property GrillaSelectionBackColor() As Color
            Get
                Return Color.LemonChiffon
            End Get
        End Property
        Public Shared ReadOnly Property GrillaSelectionForeColor() As Color
            Get
                Return Color.Black
            End Get
        End Property
        Public Shared ReadOnly Property GrillaSelectionBackColor_Visita() As Color
            Get
                Return Color.PaleGreen
            End Get
        End Property
        Public Shared ReadOnly Property GrillaSelectionBackColor_Red() As Color
            Get
                Return Color.LightCoral
            End Get
        End Property
    End Class
    'Public Class Licencia
    '    Private Shared intCodigo As Integer = -1
    '    Public Shared Property Codigo() As Integer
    '        Get
    '            Return intCodigo
    '        End Get
    '        Set(ByVal value As Integer)
    '            intCodigo = value
    '        End Set
    '    End Property
    'End Class
    Public Class WebService
#Region "Enum"
        Public Enum enmDirectotioTipo
            Interno = 1
            Personal = 2
            Visitante = 3
            Reniec = 4
            ReniecSybase = 5
        End Enum
#End Region
#Region "Propiedades"        
        Public Shared Property Foto() As String = ""
#End Region

#Region "Functions"
        Public Shared Function SubirFoto(ByVal NameFileConExtension As String, ByVal PathFile As String, _
                                         ByVal Directorio As enmDirectotioTipo) As Boolean

            Dim blnValue As Boolean = False

            If PathFile Is Nothing OrElse PathFile.Trim = "" Then
                Return blnValue
            End If

            Dim objByte As Byte()
            Dim strNameImagen As String = NameFileConExtension 'Legolas.Components.Archivo.FileNombre(PathFotoName)

            Dim objWebService As New APPWebService.ws_foto.PopeLocal
            objWebService.Url = APPWebService.PathURL.WSPopeLocal

            objByte = Legolas.Components.Archivo.FileConvertByte(PathFile)

            Try
                blnValue = objWebService.UploadImageJpg(objByte, strNameImagen, Directorio) 'interno
                'Dim _Str As String = objWebService.UploadImageJpg_str(objByte, strNameImagen, Directorio) 'interno

            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.MensajeError(ex.Message)
            End Try

            Return blnValue

        End Function
        Public Shared Function SubirFoto2(ByVal NameFileConExtension As String, ByVal Imagen As System.Drawing.Image, _
                                         ByVal Directorio As enmDirectotioTipo) As Boolean

            Dim blnValue As Boolean = False

            If Imagen Is Nothing Then
                Return blnValue
            End If

            Dim objByte As Byte()
            Dim strNameImagen As String = NameFileConExtension

            Dim objWebService As New APPWebService.ws_foto.PopeLocal
            objWebService.Url = APPWebService.PathURL.WSPopeLocal

            'MessageBox.Show(objWebService.Url)

            objByte = Legolas.Components.Archivo.FileImagenConvertByte(Imagen)

            'MessageBox.Show(objByte.Length.ToString)

            'Try
            blnValue = objWebService.UploadImageJpg(objByte, strNameImagen, Directorio) 'interno
            ' Dim _Str As String = objmultimedia.UploadImageJpg_str(objByte, strNameImagen, Directorio) 'interno
            '   _Str = _Str
            'Catch ex As Exception
            'Legolas.Configuration.Aplication.MessageBox.MensajeError(ex.Message)
            'End Try

            Return blnValue

        End Function
        Public Shared Function SubirFoto3(Region As Short, Penal As Short, Anio As Short, MesCorrelativo As String, _
                                         ByVal Imagen As System.Drawing.Image, ByVal NameFileConExtension As String, _
                                         ByVal Directorio As enmDirectotioTipo) As Boolean
            Dim blnValue As Boolean = False

            If Imagen Is Nothing Then
                Return blnValue
            End If

            Dim objByte As Byte()
            Dim strNameImagen As String = NameFileConExtension

            Dim objWebService As New APPWebService.ws_foto.PopeLocal
            objWebService.Url = APPWebService.PathURL.WSPopeLocal

            objByte = Legolas.Components.Archivo.FileImagenConvertByte(Imagen)


            Try
                blnValue = objWebService.SubirArchivoByte(Region, Penal, Anio, MesCorrelativo, _
                                                      objByte, strNameImagen, Directorio) 'reniec                
            Catch ex As Exception
                Legolas.Configuration.Aplication.MessageBox.MensajeError(ex.Message)
            End Try

            Return blnValue


        End Function
#End Region        
    End Class
    Public Class ConexionBD
        Public Shared Property CN_BD_HuellaVisita() As String = ""
        Public Shared Property CN_BD_HuellaInterno As String = ""
    End Class
End Class
