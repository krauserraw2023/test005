Imports System.Drawing

Namespace Reporte.Clasificacion
    Public Class DatosInterno
#Region "Propiedades_DatosIdentificacion"
        Private strApellidoPaterno As String = ""
        Private strApellidoMaterno As String = ""
        Private strNombres As String = ""
        Private strTipoDocumento As String = ""
        Private strNumeroDocumento As String = ""
        Private strEstadoCivil As String = ""
        Private strPadre As String = ""
        Private strMadre As String = ""
        Private strConyugue As String = ""
        Public Property CodigoRP() As String = ""
        Public Property SituacionJuridicaNombre As String = ""
        Public Property InfoDecadactilarInt As String = ""
        Public Property ApellidoPaterno() As String
            Get
                Return strApellidoPaterno
            End Get
            Set(ByVal value As String)
                strApellidoPaterno = value.ToUpper
            End Set
        End Property
        Public Property ApellidoMaterno() As String
            Get
                Return strApellidoMaterno
            End Get
            Set(ByVal value As String)
                strApellidoMaterno = value.ToUpper
            End Set
        End Property
        Public ReadOnly Property Apellidos() As String
            Get
                Dim strValue As String = ""
                strValue = Me.ApellidoPaterno & " " & Me.ApellidoMaterno
                Return strValue.ToUpper
            End Get
        End Property
        Public Property Nombres() As String
            Get
                Return strNombres.ToUpper
            End Get
            Set(ByVal value As String)
                strNombres = value
            End Set
        End Property
        Public Property TipoDocumento() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strTipoDocumento)
            End Get
            Set(ByVal value As String)
                strTipoDocumento = value
            End Set
        End Property
        Public Property NumeroDocumento() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNumeroDocumento)
            End Get
            Set(ByVal value As String)
                strNumeroDocumento = value
            End Set
        End Property
        Public ReadOnly Property TipoDocumentoyNumero() As String
            Get
                Dim value As String = ""
                value = Me.TipoDocumento & " " & Me.NumeroDocumento
                Return value
            End Get
        End Property
        Public Property OtroDocumento() As String = ""
        Public Property FechaNacimiento() As Long = 0
        Public Property FechaHoy() As Long = 0
        Public ReadOnly Property FechaNacimientoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaNacimiento)
            End Get
        End Property
        Public ReadOnly Property Edad() As Integer
            Get
                Dim intValue As Integer = 0
                intValue = Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimiento, Me.FechaHoy, True)
                Return intValue

            End Get
        End Property
        Public Property SexoID() As Integer = -1
        Public ReadOnly Property SexoNombre() As String
            Get
                Dim strValue As String = ""

                Select Case Me.SexoID
                    Case 1
                        strValue = "M"
                    Case 2
                        strValue = "F"
                End Select

                Return strValue
            End Get
        End Property
        Public Property EstadoCivil() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strEstadoCivil)
            End Get
            Set(ByVal value As String)
                strEstadoCivil = value
            End Set
        End Property
        Public Property Hononimo() As Boolean = False
        Public Property Padre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strPadre)
            End Get
            Set(ByVal value As String)
                strPadre = value
            End Set
        End Property
        Public Property Madre() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strMadre)
            End Get
            Set(ByVal value As String)
                strMadre = value
            End Set
        End Property
        Public Property Conyugue() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strConyugue)
            End Get
            Set(ByVal value As String)
                strConyugue = value
            End Set
        End Property
        Public Property NumeroHijos() As Integer = 0
        Public Property HijosMenores() As Integer = 0
#End Region
#Region "Propiedades_LocalidadNacimiento"
        Private strNacionalidad As String = ""
        Private strNacimientoPais As String = ""
        Private strNacimientoDepartamento As String = ""
        Private strNacimientoProvincia As String = ""
        Private strNacimientoDistrito As String = ""
        Public Property Nacionalidad() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacionalidad)
            End Get
            Set(ByVal value As String)
                strNacionalidad = value
            End Set
        End Property
        Public Property NacimientoPais() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacimientoPais)
            End Get
            Set(ByVal value As String)
                strNacimientoPais = value
            End Set
        End Property
        Public Property NacimientoDepartamento() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacimientoDepartamento)
            End Get
            Set(ByVal value As String)
                strNacimientoDepartamento = value
            End Set
        End Property
        Public Property NacimientoProvincia() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacimientoProvincia)
            End Get
            Set(ByVal value As String)
                strNacimientoProvincia = value
            End Set
        End Property
        Public Property NacimientoDistrito() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strNacimientoDistrito)
            End Get
            Set(ByVal value As String)
                strNacimientoDistrito = value
            End Set
        End Property
        Public ReadOnly Property NacimientoUbigeo() As String
            Get
                Dim strValue As String = ""
                strValue = Me.NacimientoDepartamento & "/" & Me.NacimientoProvincia & "/" & Me.NacimientoDistrito
                Return strValue
            End Get
        End Property
        Public Property NacimientoLugar() As String = ""
        Public Property Religion() As String = ""
        Public Property Idioma() As String = ""
#End Region
#Region "Propiedades_DatosDomicilio"
        Private strDomicilioDepartamento As String = ""
        Private strDomicilioProvincia As String = ""
        Private strDomicilioDistrito As String = ""
        Private strDomicilio As String = ""
        Public Property DomicilioDepartamento() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDomicilioDepartamento)
            End Get
            Set(ByVal value As String)
                strDomicilioDepartamento = value
            End Set
        End Property
        Public Property DomicilioProvincia() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDomicilioProvincia)
            End Get
            Set(ByVal value As String)
                strDomicilioProvincia = value
            End Set
        End Property
        Public Property DomicilioDistrito() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDomicilioDistrito)
            End Get
            Set(ByVal value As String)
                strDomicilioDistrito = value
            End Set
        End Property
        Public Property Domicilio() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strDomicilio)
            End Get
            Set(ByVal value As String)
                strDomicilio = value
            End Set
        End Property
#End Region
#Region "Propiedades_DatosComplementarios"
        Private strGradoInstruccion As String = ""
        Private strProfesion As String = ""
        Private strCentroTrabajo As String = ""
        Private strOcupacion As String = ""
        Private strFuerzaArmanda As String = ""
        Private strRango As String = ""
        Public Property GradoInstruccion() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strGradoInstruccion)
            End Get
            Set(ByVal value As String)
                strGradoInstruccion = value
            End Set
        End Property
        Public Property Profesion() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strProfesion)
            End Get
            Set(ByVal value As String)
                strProfesion = value
            End Set
        End Property
        Public Property CentroTrabajo() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strCentroTrabajo)
            End Get
            Set(ByVal value As String)
                strCentroTrabajo = value
            End Set
        End Property
        Public Property Ocupacion() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strOcupacion)
            End Get
            Set(ByVal value As String)
                strOcupacion = value
            End Set
        End Property
        Public Property FuerzaArmanda() As String
            Get
                Return Legolas.Components.Cadena.ProperCase(strFuerzaArmanda)
            End Get
            Set(ByVal value As String)
                strFuerzaArmanda = value
            End Set
        End Property
        Public Property Rango() As String 'rango militar
            Get
                Return Legolas.Components.Cadena.ProperCase(strRango)
            End Get
            Set(ByVal value As String)
                strRango = value
            End Set
        End Property
#End Region
#Region "Propiedades_CaracteristicasNotables"
        Private ObjEntColRasgos As Entity.Reporte.FichaIdentificacion.RasgosCol = Nothing
        Private objEntColSenasParticulares As Entity.Reporte.FichaIdentificacion.SenasParticularesCol = Nothing
        Public Property RasgoCol() As Reporte.FichaIdentificacion.RasgosCol
            Get
                Return ObjEntColRasgos
            End Get
            Set(ByVal value As Reporte.FichaIdentificacion.RasgosCol)
                ObjEntColRasgos = value
            End Set
        End Property
        Public Property SenasParticulares() As Reporte.FichaIdentificacion.SenasParticularesCol
            Get
                Return objEntColSenasParticulares
            End Get
            Set(ByVal value As Reporte.FichaIdentificacion.SenasParticularesCol)
                objEntColSenasParticulares = value
            End Set
        End Property
#End Region
#Region "NombresAsociadosAliasBandas"
        Public Property NombresAsociados() As String = ""
        Public Property AliasNombres() As String = ""
        Public Property Bandas() As String = ""
#End Region
#Region "DatosUltimoInternamiento"
        Public Property InternoIngresoID() As Long = -1
        Public Property InternoIngresoInpeID() As Long = -1
        Public Property TipoIngreso() As String = ""
        Public Property FechaIngresoPenal() As Long = 0
        Public ReadOnly Property FechaIngresoPenalString() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngresoPenal)
            End Get

        End Property
        Public Property NumeroIngreso() As Integer = 0
        Public Property PenalActual() As String = ""
        Public Property Delitos() As Reporte.FichaIdentificacion.DelitosCol = Nothing
#End Region
#Region "SituacionJuridica"
        Public Property SituacionJuridica() As Reporte.FichaIdentificacion.SituacionJuridicaCol = Nothing
#End Region
#Region "Foto"
        Public Property FotoVersionAntigua() As Boolean = True
        Public Property TipoLocal As Integer = -1
        Public Property FotoPerfilCentral() As String = ""
        Public Property FotoPerfilCentralId() As Integer = -1
        Public Property FotoPerfilIzquierdoId() As Integer = -1
        Private _FotoPerfilIzquierdo As String = ""
        Public Property FotoPerfilIzquierdo() As String
            Get
                Return _FotoPerfilIzquierdo
            End Get
            Set(value As String)
                _FotoPerfilIzquierdo = value
            End Set
        End Property
        Public Property PathServerImg() As String = "" 'ruta de imagen, 01/02/1235/120028
        Public ReadOnly Property FotoPI() As Byte()
            Get

                Dim value As Byte() = Nothing
                Dim strFotoNameExtension As String = Me.FotoPerfilIzquierdo.Trim

                If strFotoNameExtension.Trim = "" Then
                    value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                Else
                    'si hay foto
                    Dim objWS As New APPWebService.ws_foto.PopeLocal
                    objWS.Url = APPWebService.PathURL.WSPopeLocal

                    Try
                        value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno
                    Catch ex As Exception
                        value = Nothing
                    End Try

                    If value Is Nothing = True Then

                        'value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)

                        Select Case Me.TipoLocal
                            Case 3, 2 'sede y region
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_por_transferir)
                            Case Else 'penal
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_eliminada)
                        End Select
                    Else

                        'verificar que el archivo byte (imagen, no este dañado)
                        Dim objImagen As System.Drawing.Image = My.Resources.sin_foto
                        Dim objImagenStream As New IO.MemoryStream

                        objImagenStream.Write(value, 0, value.Length)

                        Try
                            objImagen = Image.FromStream(objImagenStream)
                            Return value
                        Catch ex As Exception
                            'objImagen = My.Resources.nspm_fotografia
                            value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.nspm_fotografia)
                        End Try
                    End If

                End If

                Return value

            End Get
        End Property
        Public ReadOnly Property FotoPC() As Byte()
            Get

                Dim value As Byte() = Nothing
                Dim strFotoNameExtension As String = Me.FotoPerfilCentral.Trim

                If strFotoNameExtension.Trim = "" Then
                    value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                Else
                    'si hay foto
                    Dim objWS As New APPWebService.ws_foto.PopeLocal
                    objWS.Url = APPWebService.PathURL.WSPopeLocal

                    Try
                        value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno
                    Catch ex As Exception
                        value = Nothing
                    End Try

                    If value Is Nothing = True Then

                        'value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)

                        Select Case Me.TipoLocal
                            Case 3, 2 'sede y region
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_por_transferir)
                            Case Else 'penal
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_eliminada)
                        End Select
                    Else

                        'verificar que el archivo byte (imagen, no este dañado)
                        Dim objImagen As System.Drawing.Image = My.Resources.sin_foto
                        Dim objImagenStream As New IO.MemoryStream

                        objImagenStream.Write(value, 0, value.Length)

                        Try
                            objImagen = Image.FromStream(objImagenStream)
                            Return value
                        Catch ex As Exception
                            'objImagen = My.Resources.nspm_fotografia
                            value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.nspm_fotografia)
                        End Try
                    End If

                End If


                Return value

            End Get
        End Property

        'para la nueva version de almacenamiento de imagen
        Public ReadOnly Property FotoPI_v2() As Byte()
            Get

                Dim value As Byte() = Nothing
                Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
                If Me.FotoPerfilIzquierdoId = -1 Then
                    value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                Else
                    'si hay foto
                    Dim objWS As New APPWebService.ws_foto.PopeLocal
                    objWS.Timeout = -1
                    objWS.Url = APPWebService.PathURL.WSPopeLocal


                    Try
                        'value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno

                        r = objWS.ListarArchivoDigital(Me.FotoPerfilIzquierdoId, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)
                        value = r.Resultado.ArchivoByte
                    Catch ex As Exception
                        value = Nothing
                    End Try

                    If value Is Nothing = True Then

                        'value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)

                        Select Case Me.TipoLocal
                            Case 3, 2 'sede y region
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_por_transferir)
                            Case Else 'penal
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_eliminada)
                        End Select
                    Else

                        'verificar que el archivo byte (imagen, no este dañado)
                        Dim objImagen As System.Drawing.Image = My.Resources.sin_foto
                        Dim objImagenStream As New IO.MemoryStream

                        objImagenStream.Write(value, 0, value.Length)

                        Try
                            objImagen = Image.FromStream(objImagenStream)
                            Return value
                        Catch ex As Exception
                            'objImagen = My.Resources.nspm_fotografia
                            value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.nspm_fotografia)
                        End Try
                    End If

                End If

                Return value

            End Get
        End Property
        Public ReadOnly Property FotoPC_v2() As Byte()
            Get

                Dim value As Byte() = Nothing
                Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital

                If Me.FotoPerfilCentralId = -1 Then
                    value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                Else
                    'si hay foto
                    Dim objWS As New APPWebService.ws_foto.PopeLocal
                    objWS.Timeout = -1
                    objWS.Url = APPWebService.PathURL.WSPopeLocal

                    Try
                        'value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno
                        r = objWS.ListarArchivoDigital(Me.FotoPerfilCentralId, Type.Enumeracion.ArchivoDigital.TipoImagen.Interno)
                        value = r.Resultado.ArchivoByte
                    Catch ex As Exception
                        value = Nothing
                    End Try

                    If value Is Nothing = True Then
                        Select Case Me.TipoLocal
                            Case 3, 2 'sede y region
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_por_transferir)
                            Case Else 'penal
                                value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.fotografia_eliminada)
                        End Select
                    Else

                        'verificar que el archivo byte (imagen, no este dañado)
                        Dim objImagen As System.Drawing.Image = My.Resources.sin_foto
                        Dim objImagenStream As New IO.MemoryStream

                        objImagenStream.Write(value, 0, value.Length)

                        Try
                            objImagen = Image.FromStream(objImagenStream)
                            Return value
                        Catch ex As Exception
                            'objImagen = My.Resources.nspm_fotografia
                            value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.nspm_fotografia)
                        End Try
                    End If

                End If


                Return value

            End Get
        End Property
#End Region
    End Class
#Region "FichaCol"

    Public Class DatosInternoCol
        Inherits System.Collections.CollectionBase
        Private _enmSortDirection As SortDirection
        Public Sub New()
            _enmSortDirection = SortDirection.Asc
        End Sub
        Public Sub Sort(ByVal sortExpression As String, ByVal sortDirection As SortDirection)
            InnerList.Sort(New Comparer(sortExpression, sortDirection))
        End Sub
        Public Sub Sort(ByVal sortExpression As String)
            InnerList.Sort(New Comparer(sortExpression, _enmSortDirection))
            If _enmSortDirection = SortDirection.Asc Then
                _enmSortDirection = SortDirection.Desc
            Else
                _enmSortDirection = SortDirection.Asc
            End If
        End Sub
        Public Function Add(ByVal obj As DatosInterno) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Ficha(ByVal Index As Integer) As DatosInterno
            Get
                Return CType(MyBase.List(Index), DatosInterno)
            End Get
        End Property
    End Class
#End Region
End Namespace
