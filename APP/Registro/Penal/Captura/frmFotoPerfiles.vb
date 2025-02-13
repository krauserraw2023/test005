Imports System.IO
Imports Type.Enumeracion.Licencia

Namespace Registro.Captura
    Public Class frmFotoPerfiles
        Private objBssFoto As Bussines.Registro.InternoFoto

        Private EsFotoHistorico As Boolean = False
#Region "Constantes predeterminados foto"
        Private Const IMG_ANCHO_PREDET As Integer = 480
        Private Const IMG_ALTO_PREDET As Integer = 640
        Private Const IMG_PESO_PREDET As Decimal = 100
        Private blnBotonCentral As Boolean = False
#End Region
#Region "Propiedades Publicas"
        Public Property _InternoID() As Integer = -1
        Public Property Codigo() As Integer = -1
        Public Property RegionID() As Integer = -1
        Public Property PenalID() As Integer = -1
        Public Property InternoIngresoId As Integer = -1
        Public Property _InternoIngresoInpeId As Integer = -1
        Public Property TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property InternoIngresoNro As Integer = -1
        Public Property RestringirEdicion() As Boolean = False

#End Region
#Region "Propiedades_Imagen"
        Private Property ImagenPI_Id() As Integer = -1
        Private Property ImagenPF_Id() As Integer = -1
        Private Property ImagenPD_Id() As Integer = -1

        Private Property ImagenNamePI() As String = ""
        Private Property ImagenNamePF() As String = ""
        Private Property ImagenNamePD() As String = ""

        Private Property ImagenRutaLocalPI() As String = ""
        Private Property ImagenRutaLocalPF() As String = ""
        Private Property ImagenRutaLocalPD() As String = ""

        Private Property ImagenServerRutaPI() As String = ""
        Private Property ImagenServerPathPF() As String = ""
        Private Property ImagenServerPathPD() As String = ""

        Private Property ImagenChangePI() As Boolean = False
        Private Property ImagenChangePF() As Boolean = False
        Private Property ImagenChangePD() As Boolean = False

        Private Property ImagenFecha() As Long = 0

        Private ReadOnly Property ImagenTipo() As Integer
            Get
                Return Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
            End Get
        End Property
#End Region
#Region "Listar"

        Private Sub MuestraImagen(ByVal ImagenPerfil As Integer, ByVal ArchivoDigitalID As Integer)
            Dim intTipoLocal As Integer = 3 'sede central
            Dim objImagen As Image = My.Resources.sin_fotografia
            Dim bssArchDig As New Bussines.Globall.ArchivoDigital

            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.Listar(Legolas.LBusiness.Globall.WinApp.LicenciaApp).Tipo
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            If ArchivoDigitalID < 1 Then
                objImagen = My.Resources.sin_fotografia
            Else
                Dim entAD As Entity.Globall.ArchivoDigital
                Try
                    entAD = bssArchDig.ListarArchivoDigital(ArchivoDigitalID, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                Catch ex As Exception
                    objImagen = My.Resources.ws_config
                    ShowImagenInterno(ImagenPerfil, objImagen)
                    Exit Sub
                End Try

                Dim objImagenByte As Byte()

                objImagenByte = If(entAD Is Nothing, Nothing, entAD.ArchivoByte)

                If objImagenByte Is Nothing Then
                    Select Case intTipoLocal
                        Case 3, 2
                            objImagen = My.Resources.fotografia_por_transferir
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select
                Else
                    Dim objImagenStream As New MemoryStream
                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                End If

            End If
            ShowImagenInterno(ImagenPerfil, objImagen)
        End Sub

        Private Sub listarFotos()
            If Me.Codigo < 0 Then 'nuevo
                EsFotoHistorico = False
                LimpiarImagenes()
                Exit Sub
            End If
            Dim objEnt As New Entity.Registro.InternoFoto

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                    objEnt = objBssFoto.ListarGrilla_LM(Me.Codigo)
                Case Else
                    objEnt = objBssFoto.ListarGrilla(Me.Codigo)
            End Select

            With objEnt
                Me.ImagenPI_Id = .PIzquierdoID
                Me.ImagenNamePI = .PIzquierdoName
                Me.ImagenServerRutaPI = .PIzquierdoServerPath

                Me.ImagenPF_Id = .PFrenteID
                Me.ImagenNamePF = .PFrenteName
                Me.ImagenServerPathPF = .PFrenteServerPath

                Me.ImagenPD_Id = .PDerechoID
                Me.ImagenNamePD = .PDerechoName
                Me.ImagenServerPathPD = .PDerechoServerPath

                Me.ImagenFecha = .Fecha

                Me.InternoIngresoId = .InternoIngresoId
                Me._InternoIngresoInpeId = .IngresoInpeId
                Me.EsFotoHistorico = If(.FotoVersionNueva = True, False, True)
            End With

            MuestraImagen(1, Me.ImagenPI_Id)
            MuestraImagen(2, Me.ImagenPF_Id)
            MuestraImagen(3, Me.ImagenPD_Id)

            If Me.RestringirEdicion = True Then
                btnWebCamIzq.Enabled = False
                btnCapurarIzq.Enabled = False
                btnWebCamCen.Enabled = False
                btnCapurarCen.Enabled = False
                btnWebCamDer.Enabled = False
                btnCapurarDer.Enabled = False
            End If
        End Sub
        Private Sub ShowImagenInterno(ByVal ImagenPerfil As Integer, objImagen As Image)
            Select Case ImagenPerfil
                Case 1
                    Me.pbIzquierdo.Image = objImagen
                Case 2
                    Me.pbFrente.Image = objImagen
                Case 3
                    Me.pbDerecho.Image = objImagen
            End Select
        End Sub
#End Region
#Region "Accion"
        Private Function ValidarImagen() As Boolean
            If Me.ImagenRutaLocalPI = "" And ImagenRutaLocalPF = "" And ImagenRutaLocalPD = "" Then
                Me.ImagenFecha = 0
                Return False
            End If
            Return True
        End Function

        Private Function AGrabarImagen_Regularizar() As Boolean
            Dim blnValue As Boolean
            Dim outErrSms As String = ""

            Dim blnImgPI_Upload As Boolean = False
            Dim blnImgPF_Upload As Boolean = False
            Dim blnImgPD_Upload As Boolean = False

            Dim intImgPI_Id_tmp As Integer = -1
            Dim intImgPD_Id_tmp As Integer = -1
            Dim intImgPF_Id_tmp As Integer = -1

            Dim flgVal As Boolean = False

            Dim bssArchDig As New Bussines.Globall.ArchivoDigital

            Dim strRutaDIR As String = ""

            strRutaDIR = My.Computer.FileSystem.CurrentDirectory & "\tmp"

            If System.IO.Directory.Exists(strRutaDIR) = False Then System.IO.Directory.CreateDirectory(strRutaDIR)

            Dim objBssImag As New Bussines.Globall.ArchivoDigital

            'descargar fotos a temporal
            If Me.ImagenPI_Id > 0 Then
                intImgPI_Id_tmp = Me.ImagenPI_Id
                flgVal = False
                Dim entAD As Entity.Globall.ArchivoDigital

                Try
                    entAD = bssArchDig.ListarArchivoDigital(intImgPI_Id_tmp, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                Catch ex As Exception
                    entAD = bssArchDig.ListarArchivoDigital(intImgPI_Id_tmp, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "") 'segundo intento
                End Try

                If IsNothing(entAD.ArchivoByte) = False Then
                    Me.ImagenRutaLocalPI = strRutaDIR & "\" & entAD.NombreFisico & "." & entAD.Extension
                    Legolas.Components.Archivo.FileByteConvertImagen(entAD.ArchivoByte).Save(Me.ImagenRutaLocalPI, Drawing.Imaging.ImageFormat.Jpeg)
                    flgVal = True
                Else
                    If Me.ImagenRutaLocalPI = "" Then
                        intImgPI_Id_tmp = -1
                    Else
                        flgVal = True
                        If File.Exists(Me.ImagenRutaLocalPI) Then entAD.ArchivoByte = System.IO.File.ReadAllBytes(Me.ImagenRutaLocalPI)
                    End If
                End If

                If flgVal = True Then
                    With entAD
                        .PC = Legolas.Components.PC.PCNombre
                        .IP = Legolas.Components.PC.GetIP
                        .Extension = If(Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPI).IndexOf(".") > -1, Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPI).Replace(".", ""), Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPI))
                        .Peso = Legolas.Components.Archivo.FilePeso(Me.ImagenRutaLocalPI)
                        .MAC = Legolas.Components.PC.GetMAC
                        .Region = Me._RegionID
                        .Penal = Me._PenalID
                        .Tipo = 1 'fotos de interno
                        .ImagenUploadWeb = 1
                        .CodigoExt_id = Me._InternoID
                    End With

                    Me.ImagenPI_Id = objBssImag.Grabar_v2(entAD, outErrSms)

                    If File.Exists(Me.ImagenRutaLocalPI) Then System.IO.File.Delete(Me.ImagenRutaLocalPI)

                    blnImgPI_Upload = True
                End If
            End If

            If Me.ImagenPD_Id > 0 Then
                intImgPD_Id_tmp = Me.ImagenPD_Id
                flgVal = False
                Dim entAD As Entity.Globall.ArchivoDigital

                Try
                    entAD = bssArchDig.ListarArchivoDigital(intImgPD_Id_tmp, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                Catch ex As Exception
                    entAD = bssArchDig.ListarArchivoDigital(intImgPD_Id_tmp, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "") 'segundo intento
                End Try

                If IsNothing(entAD.ArchivoByte) = False Then
                    Me.ImagenRutaLocalPD = strRutaDIR & "\" & entAD.NombreFisico & "." & entAD.Extension
                    Legolas.Components.Archivo.FileByteConvertImagen(entAD.ArchivoByte).Save(Me.ImagenRutaLocalPD, Drawing.Imaging.ImageFormat.Jpeg)
                    flgVal = True
                Else
                    If Me.ImagenRutaLocalPD = "" Then
                        intImgPD_Id_tmp = -1
                    Else
                        flgVal = True
                        If File.Exists(Me.ImagenRutaLocalPD) Then entAD.ArchivoByte = System.IO.File.ReadAllBytes(Me.ImagenRutaLocalPD)
                    End If
                End If

                If flgVal = True Then
                    With entAD
                        .PC = Legolas.Components.PC.PCNombre
                        .IP = Legolas.Components.PC.GetIP
                        .Extension = If(Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPD).IndexOf(".") > -1, Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPD).Replace(".", ""), Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPD)) 'Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPD)
                        .Peso = Legolas.Components.Archivo.FilePeso(Me.ImagenRutaLocalPD)
                        .MAC = Legolas.Components.PC.GetMAC
                        .Region = Me._RegionID
                        .Penal = Me._PenalID
                        .Tipo = 1 'fotos de interno
                        .ImagenUploadWeb = 1
                        .CodigoExt_id = Me._InternoID
                    End With
                    Me.ImagenPD_Id = objBssImag.Grabar_v2(entAD, outErrSms)

                    If File.Exists(Me.ImagenRutaLocalPD) Then System.IO.File.Delete(Me.ImagenRutaLocalPD)

                    blnImgPD_Upload = True
                End If
            End If

            If Me.ImagenPF_Id > 0 Then
                intImgPF_Id_tmp = Me.ImagenPF_Id
                flgVal = False
                Dim entAD As Entity.Globall.ArchivoDigital

                Try
                    entAD = bssArchDig.ListarArchivoDigital(intImgPF_Id_tmp, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "")
                Catch ex As Exception
                    entAD = bssArchDig.ListarArchivoDigital(intImgPF_Id_tmp, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno, "") 'segundo intento
                End Try

                If IsNothing(entAD.ArchivoByte) = False Then
                    Me.ImagenRutaLocalPF = strRutaDIR & "\" & Me.ImagenNamePF & ".jpg"
                    Legolas.Components.Archivo.FileByteConvertImagen(entAD.ArchivoByte).Save(Me.ImagenRutaLocalPF, Drawing.Imaging.ImageFormat.Jpeg)
                    flgVal = True
                Else
                    If Me.ImagenRutaLocalPF = "" Then
                        intImgPF_Id_tmp = -1
                    Else
                        flgVal = True
                        If File.Exists(Me.ImagenRutaLocalPF) Then entAD.ArchivoByte = System.IO.File.ReadAllBytes(Me.ImagenRutaLocalPF)
                    End If
                End If

                If flgVal = True Then
                    With entAD
                        .PC = Legolas.Components.PC.PCNombre
                        .IP = Legolas.Components.PC.GetIP
                        .Extension = If(Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPF).IndexOf(".") > -1, Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPF).Replace(".", ""), Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPF)) 'Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPD)
                        .Peso = Legolas.Components.Archivo.FilePeso(Me.ImagenRutaLocalPF)
                        .MAC = Legolas.Components.PC.GetMAC
                        .Region = Me._RegionID
                        .Penal = Me._PenalID
                        .Tipo = 1 'fotos de interno
                        .ImagenUploadWeb = 1
                        .CodigoExt_id = Me._InternoID
                    End With

                    Me.ImagenPF_Id = objBssImag.Grabar_v2(entAD, outErrSms)
                    blnImgPF_Upload = True
                End If
            End If

            If blnImgPD_Upload = False And blnImgPF_Upload = False And blnImgPI_Upload = False Then Return False

            Dim intCodigo As Integer = -1
            Dim entIntFot As New Entity.Registro.InternoFoto

            entIntFot = objBssFoto.ListarGrilla(Me.Codigo)
            With entIntFot
                .InternoID = Me._InternoID
                .RegionId = Me.RegionID
                .PenalId = Me.PenalID
                .FotoTipo = -1 'foto de interno
                .PIzquierdoID = IIf(intImgPI_Id_tmp = -1, Me.ImagenPI_Id, intImgPI_Id_tmp)
                .PFrenteID = IIf(intImgPF_Id_tmp = -1, Me.ImagenPF_Id, intImgPF_Id_tmp)
                .PDerechoID = IIf(intImgPD_Id_tmp = -1, Me.ImagenPD_Id, intImgPD_Id_tmp)
                .InternoIngresoId = Me.InternoIngresoId
                .IngresoInpeId = Me._InternoIngresoInpeId
                .FotoVersionNueva = True
            End With

            If Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana _
                Or Me.TipoLicencia = enmTipoLicencia.Carceleta Then
                entIntFot.InternoIngresoId = -1 'lima metropolitana no es necesario
                intCodigo = objBssFoto.Grabar_LM(entIntFot)
            Else
                intCodigo = objBssFoto.Grabar_v2(entIntFot)
            End If


            If intCodigo > 0 Then
                Me.ImagenFecha = 0
                Me.Codigo = intCodigo
                Me.ImagenChangePI = False
                Me.ImagenChangePF = False
                Me.ImagenChangePD = False
                blnValue = True
                Me.ImagenRutaLocalPI = ""
                Me.ImagenRutaLocalPF = ""
                Me.ImagenRutaLocalPD = ""

                EsFotoHistorico = False
            End If

            Return blnValue
        End Function


        Private Function AGrabarImagen() As Boolean
            Dim objEntArchivoDig As Entity.Globall.ArchivoDigital = Nothing
            Dim entIntFot As Entity.Registro.InternoFoto
            Dim outErrSms As String = ""
            Dim intCodigo As Integer = -1

            If Me.Codigo > 0 And Me.EsFotoHistorico = True Then 'si InternoFoto no es nuevo y es regularizacion
                ''regularizar foto historico
                If AGrabarImagen_Regularizar() = True Then
                    Return True
                Else
                    MessageBox.Show("No se pudo guardar las fotos", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If

            If ValidarImagen() = False Then
                If Me.Codigo > 0 Then 'para actualizar numero de ingreso en caso no se cargue ninguna foto
                    entIntFot = New Entity.Registro.InternoFoto

                    entIntFot.Codigo = Me.Codigo
                    entIntFot.InternoID = Me._InternoID
                    entIntFot.RegionId = Me.RegionID
                    entIntFot.PenalId = Me.PenalID
                    entIntFot.FotoTipo = Me.ImagenTipo
                    entIntFot.PIzquierdoID = Me.ImagenPI_Id
                    entIntFot.PFrenteID = Me.ImagenPF_Id
                    entIntFot.PDerechoID = Me.ImagenPD_Id
                    entIntFot.Fecha = Me.ImagenFecha
                    entIntFot.InternoIngresoId = Me.InternoIngresoId
                    entIntFot.IngresoInpeId = Me._InternoIngresoInpeId
                    entIntFot.FotoVersionNueva = True

                    Select Case Me.TipoLicencia
                        Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                            entIntFot.IngresoInpeId = Me._InternoIngresoInpeId
                            entIntFot.InternoIngresoId = -1
                            intCodigo = objBssFoto.Grabar_LM(entIntFot)
                        Case Else
                            intCodigo = objBssFoto.Grabar_v2(entIntFot)
                    End Select

                    Return True
                Else
                    MessageBox.Show("No se cargaron imagenes en ninguno de los perfiles ", Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return False
                End If
            End If

            Dim objBssImag As New Bussines.Globall.ArchivoDigital

            If Me.ImagenChangePI = True Then 'perfil izquierdo
                Me.ImagenPI_Id = -1
                objEntArchivoDig = New Entity.Globall.ArchivoDigital
                With objEntArchivoDig
                    .PC = Legolas.Components.PC.PCNombre
                    .IP = Legolas.Components.PC.GetIP
                    .Extension = Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPI)
                    .Peso = Legolas.Components.Archivo.FilePeso(Me.ImagenRutaLocalPI)
                    .MAC = Legolas.Components.PC.GetMAC
                    .Extension = .Extension
                    .Region = Me._RegionID
                    .Penal = Me._PenalID
                    .Tipo = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno  'fotos de interno
                    .ImagenUploadWeb = 0
                    .CodigoExt_id = Me._InternoID
                    .ArchivoByte = Legolas.Components.Archivo.FileImagenConvertByte(Me.pbIzquierdo.Image)
                End With

                Me.ImagenPI_Id = objBssImag.Grabar_v2(objEntArchivoDig, outErrSms)
                If Me.ImagenPI_Id < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outErrSms & " La foto del perfil izquierdo, no se ha podido subir en el servidor, vuelva ha intentarlo")
                    Return False
                End If
            End If

            If Me.ImagenChangePF = True Then 'perfil frente
                Me.ImagenPF_Id = -1
                objEntArchivoDig = New Entity.Globall.ArchivoDigital
                With objEntArchivoDig
                    .PC = Legolas.Components.PC.PCNombre
                    .IP = Legolas.Components.PC.GetIP
                    .Extension = Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPF)
                    .Peso = Legolas.Components.Archivo.FilePeso(Me.ImagenRutaLocalPF)
                    .MAC = Legolas.Components.PC.GetMAC
                    .Region = Me._RegionID
                    .Penal = Me._PenalID
                    .Tipo = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno  'fotos de interno
                    .ImagenUploadWeb = 0
                    .CodigoExt_id = Me._InternoID
                    .ArchivoByte = Legolas.Components.Archivo.FileImagenConvertByte(Me.pbFrente.Image)
                End With
                Me.ImagenPF_Id = objBssImag.Grabar_v2(objEntArchivoDig, outErrSms)
                If Me.ImagenPF_Id < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outErrSms & " La foto del perfil frontal no se ha podido subir al servidor, vuelva ha intentarlo")
                    Return False
                End If
            End If

            If Me.ImagenChangePD = True Then 'perfil derecho
                Me.ImagenPD_Id = -1
                objEntArchivoDig = New Entity.Globall.ArchivoDigital
                With objEntArchivoDig
                    .PC = Legolas.Components.PC.PCNombre
                    .IP = Legolas.Components.PC.GetIP
                    .NombreFisico = Me.ImagenName(3)
                    .Extension = Legolas.Components.Archivo.FileExtension(Me.ImagenRutaLocalPD)
                    .Peso = Legolas.Components.Archivo.FilePeso(Me.ImagenRutaLocalPD)
                    .MAC = Legolas.Components.PC.GetMAC
                    .Region = Me._RegionID
                    .Penal = Me._PenalID
                    .Tipo = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno  'fotos de interno
                    .ImagenUploadWeb = 0
                    .CodigoExt_id = Me._InternoID
                    .ArchivoByte = Legolas.Components.Archivo.FileImagenConvertByte(Me.pbDerecho.Image)
                End With

                Me.ImagenPD_Id = objBssImag.Grabar_v2(objEntArchivoDig, outErrSms) 'objBssImag.GrabarImage(Me.ImagenPD_Id, strNomImgPD, Me.ImagenRutaLocalPD, Me._InternoID, _
                If Me.ImagenPD_Id < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(outErrSms & " La foto del perfil derecho, no se ha podido subir en el servidor, vuelva ha intentarlo")
                    Return False
                End If
            End If

            entIntFot = New Entity.Registro.InternoFoto

            entIntFot.Codigo = Me.Codigo
            entIntFot.InternoID = Me._InternoID
            entIntFot.RegionId = Me.RegionID
            entIntFot.PenalId = Me.PenalID
            entIntFot.FotoTipo = Me.ImagenTipo
            entIntFot.PIzquierdoID = Me.ImagenPI_Id
            entIntFot.PFrenteID = Me.ImagenPF_Id
            entIntFot.PDerechoID = Me.ImagenPD_Id
            entIntFot.Fecha = Me.ImagenFecha
            entIntFot.InternoIngresoId = Me.InternoIngresoId
            entIntFot.IngresoInpeId = Me._InternoIngresoInpeId
            entIntFot.FotoVersionNueva = True

            Select Case Me.TipoLicencia
                Case enmTipoLicencia.Carceleta, enmTipoLicencia.RegionLimaMetropolitana, enmTipoLicencia.PenalLimaMetropolitana
                    entIntFot.InternoIngresoId = -1
                    intCodigo = objBssFoto.Grabar_LM(entIntFot)
                Case Else
                    intCodigo = objBssFoto.Grabar_v2(entIntFot)
            End Select

            If intCodigo > 0 Then
                Try
                    If Legolas.Components.Archivo.FileExiste(Me.ImagenRutaLocalPI) = True Then Legolas.Components.Archivo.FileDelete(Me.ImagenRutaLocalPI)
                    If Legolas.Components.Archivo.FileExiste(Me.ImagenRutaLocalPD) = True Then Legolas.Components.Archivo.FileDelete(Me.ImagenRutaLocalPD)
                    If Legolas.Components.Archivo.FileExiste(Me.ImagenRutaLocalPF) = True Then Legolas.Components.Archivo.FileDelete(Me.ImagenRutaLocalPF)
                Catch ex As Exception
                    'NADA
                End Try

                Me.ImagenFecha = 0
                Me.Codigo = intCodigo
                Me.ImagenChangePI = False
                Me.ImagenChangePF = False
                Me.ImagenChangePD = False
                Me.ImagenRutaLocalPI = ""
                Me.ImagenRutaLocalPF = ""
                Me.ImagenRutaLocalPD = ""
            End If

            Return True
        End Function
        Private Function AGrabar() As Boolean
            Dim blnValue As Boolean = False

            If Me.TipoLicencia = enmTipoLicencia.Carceleta Or Me.TipoLicencia = enmTipoLicencia.RegionLimaMetropolitana Or Me.TipoLicencia = enmTipoLicencia.PenalLimaMetropolitana Then
                If Me._InternoIngresoInpeId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Número de ingreso erroneo")
                    Exit Function
                End If
            Else
                If Me.InternoIngresoId < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Número de ingreso erroneo")
                    Exit Function
                End If
            End If

            blnValue = AGrabarImagen()

            If blnValue = True Then Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

            Return blnValue
        End Function
#End Region

#Region "Pemrmisos_Usuarios"
        Private Sub Usuario_Permiso()
            Me.btnOk.Visible = Me._FormEscritura
        End Sub
#End Region
#Region "Forms"
        Private Sub FRM_Zoom(ByVal Perfil As Integer)

            Dim frm As New APPControls.Registro.frmFotoZoomPopup
            With frm

                Select Case Perfil
                    Case 1
                        ._pImagen = Me.pbIzquierdo.Image
                    Case 2
                        ._pImagen = Me.pbFrente.Image
                    Case 3
                        ._pImagen = Me.pbDerecho.Image
                End Select

                '._pFileName = FileName
                If .ShowDialog = DialogResult.OK Then

                End If
            End With

        End Sub

        Private Function FRM_CapturarFoto(ByVal strPathFoto As String) As Boolean

            If blnBotonCentral = True Then
                Dim objBss As New Bussines.Registro.InternoReniec
                Dim objEnt As New Entity.Registro.InternoReniec
                objEnt.Codigo = ImagenPF_Id
                Dim intValue As Integer = objBss.ValidarFotoReniec(objEnt)
                If intValue > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La foto no puede ser modificada porque ha sido referenciado en una validacion RENIEC")
                    Return False
                End If
            End If

            strPathFoto = Legolas.Components.Cadena.Left(strPathFoto, strPathFoto.Length - 4)
            strPathFoto = Legolas.Configuration.Path.FotoInterno & strPathFoto & ".jpg"

            '/*capturar foto de la webcam, version02.1*/
            Dim blnCopio As Boolean = False
            Dim strNombreCamara As String = "cw_default"
            'Dim strRutaW As String = Legolas.Configuration.Path.Directorio & "windows81.ini".ToUpper.ToString
            Dim blnValue As Boolean = False

            For Each str As String In IO.Directory.GetFiles(Legolas.Configuration.Path.Directorio, "*.ini")

                Dim strNombreArchivo As String = Legolas.Components.Archivo.FileNombre(str, False).ToUpper

                Select Case strNombreArchivo.ToUpper
                    Case "cw_aforge_net".ToUpper, "windows81".ToUpper
                        strNombreCamara = "cw_aforge_net"

                    Case "cw_avicap32".ToUpper
                        strNombreCamara = "cw_avicap32"
                End Select
            Next

            Select Case strNombreCamara.ToUpper

                Case "cw_default".ToUpper
                    Dim frm As New APPCamaraWeb.frmFoto
                    With frm
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                            ._EliminarArchivo(._PathImagenTemporal)
                            blnValue = True
                        End If
                    End With

                Case "cw_aforge_net".ToUpper
                    Dim frm As New APPCamaraWeb.frmFotov3
                    With frm
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                            ._EliminarArchivo(._PathImagenTemporal)
                            blnValue = True
                        End If
                    End With

                Case "cw_avicap32".ToUpper
                    Dim frm As New APPCamaraWeb.frmWebCam_avicap32
                    With frm
                        If .ShowDialog = Windows.Forms.DialogResult.OK Then
                            blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                            ._EliminarArchivo(._PathImagenTemporal)
                            blnValue = True
                        End If
                    End With

            End Select

            Return blnValue
        End Function


#End Region
#Region "OTROS"
        Private Function ImagenName(ByVal Perfil As Integer) As String
            Return Me.RegionID & "_" & Me.PenalID
        End Function

        Private Sub LimpiarImagenes()
            Me.pbIzquierdo.Image = My.Resources.sin_fotografia
            Me.pbFrente.Image = My.Resources.sin_fotografia
            Me.pbDerecho.Image = My.Resources.sin_fotografia
        End Sub

        Private Sub LimpiarImagenVariables()

            Me.ImagenPI_Id = -1
            Me.ImagenRutaLocalPI = ""
            Me.ImagenPF_Id = -1
            Me.ImagenRutaLocalPF = ""
            Me.ImagenPD_Id = -1
            Me.ImagenRutaLocalPD = ""

        End Sub

        Private Function FotoSeleccionada() As String
            Dim objBss As New Bussines.Registro.InternoReniec
            Dim value As String = ""
            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de subir las fotos del interno, haga click en guardar los datos personales")
                Return value
            End If
            If blnBotonCentral = True Then
                Dim out_msg As String = ""
                Dim objEnt As New Entity.Registro.InternoReniec
                objEnt.Codigo = ImagenPF_Id
                Dim intValue As Integer = objBss.ValidarFotoReniec(objEnt)
                If intValue > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La foto no puede ser modificada porque ha sido referenciado en una validacion RENIEC")
                    Return value
                End If
            End If

            Dim strPath As String = ""

            With Me.OpenFileDialog1
                .FileName = ""
                .Filter = "Imagen JPEG (*.jpg)|*.jpg"
                If .ShowDialog = DialogResult.OK Then strPath = OpenFileDialog1.FileName
            End With

            Me.Cursor = Cursors.WaitCursor

            If strPath.Trim <> "" Or strPath.Length > 0 Then
                strPath = APPControls.Fotografia.ImagenRedimensionar(strPath, IMG_PESO_PREDET, IMG_ANCHO_PREDET, IMG_ALTO_PREDET)
            Else
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se ha seleccionado ninguna foto, intentelo nuevamente")
                Me.Cursor = Cursors.Default
                Return value
            End If

            Me.Cursor = Cursors.Default

            Return strPath

        End Function

        Public Sub LoadUsc()
            objBssFoto = New Bussines.Registro.InternoFoto
            listarFotos()
        End Sub

        Private Sub Mostrar_Auditoria()
            UscAuditUser1.LoadAudit(Me._Codigo, Type.Enumeracion.TipoTabla.EnumTipTabla.INT_InternoFoto)
        End Sub

#End Region

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub

        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
            If RestringirEdicion = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Solo se permite realizar operaciones sobre último registro de fotografia.")
            Else
                If AGrabar() = False Then Exit Sub

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End Sub

        Private Sub btnCapurarIzq_Click(sender As System.Object, e As System.EventArgs) Handles btnCapurarIzq.Click
            blnBotonCentral = False
            Dim strPath As String = FotoSeleccionada()

            If strPath.Trim <> "" Or strPath.Length > 0 Then
                Me.pbIzquierdo.ImageLocation = strPath
                Me.ImagenRutaLocalPI = strPath 'interno
                Me.ImagenChangePI = True
            End If
        End Sub

        Private Sub btnWebCamIzq_Click(sender As System.Object, e As System.EventArgs) Handles btnWebCamIzq.Click
            Dim blnFoto As Boolean = False
            blnFoto = FRM_CapturarFoto(Me.ImagenName(1) & "_PI_tmp")

            If blnFoto = True Then
                Dim strPath As String = Legolas.Configuration.Path.FotoInterno & Me.ImagenName(1) & "_PI.jpg"

                Me.pbIzquierdo.ImageLocation = strPath
                Me.ImagenRutaLocalPI = strPath 'interno
                Me.ImagenChangePI = True
            End If
        End Sub

        Private Sub btnCapurarCen_Click(sender As System.Object, e As System.EventArgs) Handles btnCapurarCen.Click
            blnBotonCentral = True
            Dim strPath As String = FotoSeleccionada()

            If strPath.Trim <> "" Or strPath.Length > 0 Then
                Me.pbFrente.ImageLocation = strPath
                Me.ImagenRutaLocalPF = strPath 'interno
                Me.ImagenChangePF = True
            End If
        End Sub

        Private Sub btnWebCamCen_Click(sender As System.Object, e As System.EventArgs) Handles btnWebCamCen.Click
            blnBotonCentral = True
            Dim blnFoto As Boolean = False
            blnFoto = FRM_CapturarFoto(Me.ImagenName(2) & "_PF_tmp")

            If blnFoto = True Then
                Dim strPath As String = Legolas.Configuration.Path.FotoInterno & Me.ImagenName(2) & "_PF.jpg"

                Me.pbFrente.ImageLocation = strPath
                Me.ImagenRutaLocalPF = strPath 'interno
                Me.ImagenChangePF = True
            End If
        End Sub

        Private Sub btnCapurarDer_Click(sender As System.Object, e As System.EventArgs) Handles btnCapurarDer.Click
            blnBotonCentral = False

            Dim strPath As String = FotoSeleccionada()

            If strPath.Trim <> "" Or strPath.Length > 0 Then
                Me.pbDerecho.ImageLocation = strPath
                Me.ImagenRutaLocalPD = strPath 'interno
                Me.ImagenChangePD = True
            End If
        End Sub

        Private Sub btnWebCamDer_Click(sender As System.Object, e As System.EventArgs) Handles btnWebCamDer.Click
            Dim blnFoto As Boolean = False
            blnFoto = FRM_CapturarFoto(Me.ImagenName(3) & "_PD_tmp")

            If blnFoto = True Then
                Dim strPath As String = Legolas.Configuration.Path.FotoInterno & Me.ImagenName(3) & "_PD.jpg"

                Me.pbDerecho.ImageLocation = strPath
                Me.ImagenRutaLocalPD = strPath 'interno
                Me.ImagenChangePD = True
            End If
        End Sub

        Private Sub pbIzquierdo_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbIzquierdo.DoubleClick
            FRM_Zoom(1)
        End Sub

        Private Sub pbFrente_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbFrente.DoubleClick
            FRM_Zoom(2)
        End Sub

        Private Sub pbDerecho_DoubleClick(sender As System.Object, e As System.EventArgs) Handles pbDerecho.DoubleClick
            FRM_Zoom(3)
        End Sub

        Private Sub frmFotoPerfiles_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            Mostrar_Auditoria()
            Usuario_Permiso()
            objBssFoto = New Bussines.Registro.InternoFoto
        End Sub
    End Class
End Namespace