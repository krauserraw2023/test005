Public Class Fotografia
    Private Shared Function ImagenComprimir(ByVal Image As Image, ByVal PathFileName As String, _
       Optional ByVal Porcentaje As Integer = 50) As Boolean

        Dim blnValue As Boolean = False

        If Image Is Nothing Or PathFileName.Trim = "" Or PathFileName.Length < 4 Then
            blnValue = False
            Return blnValue
        End If

        Legolas.Components.Archivo.SaveJPGWithCompressionSetting(Image, PathFileName, Porcentaje)
        blnValue = True

        Return blnValue
    End Function
    Private Shared Function ImagenRecortada(ByVal PathFileName As String, ByVal FileNameOriginal As String, _
                                         ByVal AnchoImagen As Integer, _
                                         ByVal AnchoDefault As Integer, ByVal AltoDefault As Integer) As String

        Dim value As String = ""

        Dim intX As Integer = 0
        Dim intY As Integer = 0
        Dim objImage As Image = Nothing
        Dim PathFileNameRecortada As String = Legolas.Configuration.Path.FotoInterno

        objImage = Image.FromFile(PathFileName)
        PathFileNameRecortada = PathFileNameRecortada & FileNameOriginal & "cr_" & Now.ToFileTime.ToString & ".jpg"

        intX = (AnchoImagen - AnchoDefault) / 2

        Dim imagen2 As New Bitmap(AnchoDefault, AltoDefault)
        Dim lienzo As Graphics = Graphics.FromImage(imagen2)
        Dim recorte As Rectangle = New Rectangle(intX, intY, AnchoDefault, AltoDefault)

        lienzo.DrawImage(objImage, 0, 0, recorte, GraphicsUnit.Pixel)

        imagen2.Save(PathFileNameRecortada, Imaging.ImageFormat.Jpeg)

        value = PathFileNameRecortada

        Return value

    End Function
    Public Shared Function ImagenRedimensionar(ByVal PathFile As String, ByVal PesoDefault As Integer, _
                                         ByVal AnchoDefault As Integer, ByVal AltoDefault As Integer) As String

        Dim value As String = ""

        If PathFile.Trim = "" Then
            Return value
        End If

        Dim blnCopio As Boolean = False
        Dim decFilePeso As Decimal = 0

        Dim strNombreOriginal As String = Legolas.Components.Archivo.FileNombre(PathFile, False)

        If strNombreOriginal.Trim = "" Or strNombreOriginal.Length < 1 Then
            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
            "El archivo seleccionado no tiene un formato correcto, intente con otro archivo." _
            & Chr(13) & "Ruta: " & PathFile)
            Return value
        End If

        Dim objImagenOrg As New Bitmap(PathFile)
        Dim intAnchoIma As Integer = objImagenOrg.Width
        Dim intAltoIma As Integer = objImagenOrg.Height
        decFilePeso = Legolas.Components.Archivo.FilePeso(PathFile, _
                                                           Legolas.Components.Archivo.enmPesoTipo.Kilobytes)

        Dim strPathCopia As String = ""

        Select Case decFilePeso
            Case Is > PesoDefault  'si el peso del archivo original es mayor a 100kb

                'si el tamaño de la imagen es mayor a los parametros establecidos
                If intAnchoIma > AnchoDefault Or intAltoIma > AltoDefault Then

                    'copiar la foto original a la carpeta de trabajo
                    strPathCopia = strNombreOriginal & "c1c_" & Now.ToFileTime.ToString
                    strPathCopia = Legolas.Configuration.Path.FotoInterno & strPathCopia & ".jpg"

                    If Legolas.Components.Archivo.FileExiste(strPathCopia) = True Then
                        Legolas.Components.Archivo.FileDelete(strPathCopia)
                    End If

                    blnCopio = Legolas.Components.Archivo.FileCopy(PathFile, strPathCopia, True)

                    Dim blnFotoHorizontal As Boolean = False
                    Dim intAncho As Integer = 0
                    Dim intAlto As Integer = 0

                    If intAnchoIma > intAltoIma Then
                        blnFotoHorizontal = True
                    Else
                        blnFotoHorizontal = False
                    End If

                    If blnFotoHorizontal = True Then
                        intAlto = AltoDefault
                        intAncho = intAnchoIma * AltoDefault / intAltoIma
                    Else
                        intAlto = intAltoIma * AnchoDefault / intAnchoIma
                        intAncho = AnchoDefault
                    End If

                    Dim strPathFotoActual As String = Legolas.Configuration.Path.FotoInterno & _
                    strNombreOriginal & "c1o_" & Now.ToFileTime.ToString & ".jpg"

                    Dim objImagenReducida As New Bitmap(New Bitmap(strPathCopia), intAncho, intAlto)

                    Try
                        objImagenReducida.Save(strPathFotoActual, System.Drawing.Imaging.ImageFormat.Jpeg)
                        value = strPathFotoActual
                    Catch ex As Exception
                        value = ""
                    End Try

                    '/*preguntamos si el ancho es mayor al predetermidado*/
                    If intAncho > AnchoDefault Then
                        value = ImagenRecortada(strPathFotoActual, strNombreOriginal, intAncho, _
                                                AnchoDefault, AltoDefault)
                    End If
                    '**********/

                    'calculamos el peso del archivo
                    decFilePeso = Legolas.Components.Archivo.FilePeso(value, _
                                                          Legolas.Components.Archivo.enmPesoTipo.Kilobytes)

                    If decFilePeso > PesoDefault Then
                        'bajar el 40% de calidad al archivo

                        Dim objImage As Image = Nothing
                        Dim blnComprimir As Boolean = False

                        objImage = Image.FromFile(value)
                        blnComprimir = ImagenComprimir(objImage, value, 40)

                        'calculamos otra vez el peso del archivo
                        decFilePeso = Legolas.Components.Archivo.FilePeso(value, _
                                                         Legolas.Components.Archivo.enmPesoTipo.Kilobytes)

                        If decFilePeso > PesoDefault Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "El archivo supera el peso establecido, intente con otro archivo")

                            value = ""
                            Return value
                        Else
                            'archivo ok
                            Return value
                        End If
                    Else
                        'archivo ok
                        Return value
                    End If

                Else

                    'copiar la foto original a la carpeta de trabajo
                    strPathCopia = strNombreOriginal & "c2c_" & Now.ToFileTime.ToString
                    strPathCopia = Legolas.Configuration.Path.FotoInterno & strPathCopia & ".jpg"

                    If Legolas.Components.Archivo.FileExiste(strPathCopia) = True Then
                        Legolas.Components.Archivo.FileDelete(strPathCopia)
                    End If

                    blnCopio = Legolas.Components.Archivo.FileCopy(PathFile, strPathCopia, True)

                    Dim strPathFotoActual As String = Legolas.Configuration.Path.FotoInterno & _
                    strNombreOriginal & "c2o_" & Now.ToFileTime.ToString & ".jpg"

                    'bajar el 50% de calidad al archivo
                    Dim objImage As System.Drawing.Image = Nothing
                    Dim blnComprimir As Boolean = False

                    objImage = Image.FromFile(strPathCopia)
                    blnComprimir = ImagenComprimir(objImage, strPathFotoActual, 50)

                    'calculamos otra vez el peso del archivo
                    decFilePeso = Legolas.Components.Archivo.FilePeso(strPathFotoActual, _
                                                     Legolas.Components.Archivo.enmPesoTipo.Kilobytes)

                    If decFilePeso > PesoDefault Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "El archivo supera el peso establecido, intente con otro archivo")

                        value = ""
                        Return value
                    Else
                        'archivo ok
                        value = strPathFotoActual
                        Return value
                    End If

                End If

            Case Else
                'menor a 100bk

                'mayor a la resolucion establecida
                If intAnchoIma > AnchoDefault Or intAltoIma > AltoDefault Then

                    strPathCopia = strNombreOriginal & "c3c_" & Now.ToFileTime.ToString
                    strPathCopia = Legolas.Configuration.Path.FotoInterno & strPathCopia & ".jpg"

                    If Legolas.Components.Archivo.FileExiste(strPathCopia) = True Then
                        Legolas.Components.Archivo.FileDelete(strPathCopia)
                    End If

                    blnCopio = Legolas.Components.Archivo.FileCopy(PathFile, strPathCopia, True)

                    Dim blnFotoHorizontal As Boolean = False
                    Dim intAncho As Integer = 0
                    Dim intAlto As Integer = 0

                    If intAnchoIma > intAltoIma Then
                        blnFotoHorizontal = True
                    Else
                        blnFotoHorizontal = False
                    End If

                    If blnFotoHorizontal = True Then
                        intAlto = AltoDefault
                        intAncho = intAnchoIma * AltoDefault / intAltoIma
                    Else
                        intAlto = intAltoIma * AnchoDefault / intAnchoIma
                        intAncho = AnchoDefault
                    End If

                    Dim strPathFotoActual As String = Legolas.Configuration.Path.FotoInterno & _
                    strNombreOriginal & "c3o_" & Now.ToFileTime.ToString & ".jpg"

                    Dim objImagenReducida As New Bitmap(New Bitmap(strPathCopia), intAncho, intAlto)

                    Try
                        objImagenReducida.Save(strPathFotoActual, System.Drawing.Imaging.ImageFormat.Jpeg)
                        value = strPathFotoActual
                    Catch ex As Exception
                        value = ""
                    End Try

                    '/*preguntamos si el ancho es mayor al predetermidado*/
                    If intAncho > AnchoDefault Then
                        value = ImagenRecortada(strPathFotoActual, strNombreOriginal, intAncho, _
                                                AnchoDefault, AltoDefault)
                    End If
                    '**********/

                Else
                    'menor a la resolucion establecida, queda

                    strPathCopia = Now.ToFileTime.ToString
                    strPathCopia = strNombreOriginal & "c4c_" & strPathCopia

                    strPathCopia = Legolas.Configuration.Path.FotoInterno & strPathCopia & ".jpg"

                    If Legolas.Components.Archivo.FileExiste(strPathCopia) = True Then
                        Legolas.Components.Archivo.FileDelete(strPathCopia)
                    End If

                    blnCopio = Legolas.Components.Archivo.FileCopy(PathFile, strPathCopia, True)

                    value = strPathCopia

                    Return value
                End If

        End Select

        Return value

    End Function
End Class
