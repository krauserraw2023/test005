Imports System.Drawing

Namespace Reporte.CertificadoLibertad
    Public Class Certificado
#Region "Propiedades"
        Private strPenalNombre As String = ""

        Public Property PathServerImg() As String = "" 'ruta de imagen, 01/02/1235/120028
        Public Property FotoVersionAntigua() As Boolean = True
        Public Property InternoID As Integer = -1
        Public Property IngresoID As Integer = -1
        Public Property CodigoRP() As String = ""
        Public Property ApellidoPrimero() As String = ""
        Public Property ApellidoSegundo() As String = ""
        Public Property PreNombres() As String = ""
        Public ReadOnly Property ApellidosyPreNombres() As String
            Get
                Dim value As String = ""
                value = Me.ApellidoPrimero & " " & Me.ApellidoSegundo & ", " & Me.PreNombres
                Return value.ToUpper
            End Get
        End Property
        Public Property PenalNombre() As String
            Get
                Return strPenalNombre.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalNombre = value
            End Set
        End Property
        Public Property FotoPerfilCentral() As String = ""
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
                        value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                    End If

                End If

                Return value

            End Get
        End Property
        Public ReadOnly Property FotoPC_v2() As Byte()
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
                        'value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno
                        value = objWS.LeerArchivoByte(APPWebService.ws_foto.enmTipoImagen.Interno, strFotoNameExtension & ".jpg", Me.PathServerImg)
                    Catch ex As Exception
                        value = Nothing
                    End Try

                    If value Is Nothing = True Then
                        value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                    End If

                End If

                Return value

            End Get
        End Property

        Public Property FotoPerfilCentralId() As Integer = -1
        Public Property TipoLocal As Integer = -1

        Public ReadOnly Property FotoPC_LM_v2() As Byte()
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
                        'value = objWSfdsfdsfds.LeerImageJpg(strFotoNameExtension, 1) 'interno
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
        Public Property Nota() As String = ""
        Public Property NombresAsociados() As String = ""
        Public Property Ciudad() As String = ""
#Region "Ingreso"
        Private strPenalProcedencia As String = ""
        Private lngFechaIngreso As Long = 0
        Private strExpedienteSalaJuzgado As String = ""
        Private strExpedienteNumero As String = ""

        Public Property ListaNumExpedientes() As String = ""
        Public Property InternoIngresoID() As Long = 0
        Public Property InternoIngresoInpeID() As Long = 0
        Public Property InternoExpedienteID() As Long = 0
        Public Property PenalProcedencia() As String
            Get
                Return strPenalProcedencia.ToUpper
            End Get
            Set(ByVal value As String)
                strPenalProcedencia = value
            End Set
        End Property
        Public Property FechaIngreso() As Long
            Get
                Return lngFechaIngreso
            End Get
            Set(ByVal value As Long)
                lngFechaIngreso = value
            End Set
        End Property
        Public ReadOnly Property FechaIngresoString() As String
            Get
                Return Legolas.Components.FechaHora.FechaText(Me.FechaIngreso, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get

        End Property
        Public Property ExpedienteSalaJuzgado() As String
            Get
                Return strExpedienteSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strExpedienteSalaJuzgado = value
            End Set
        End Property
        Public Property ExpedienteNumero() As String
            Get
                Return strExpedienteNumero.ToUpper
            End Get
            Set(ByVal value As String)
                strExpedienteNumero = value
            End Set
        End Property
        Public Property ExpedienteNumeroLibertad() As String = "" 'expediente con libertad
        Public Property ExpedienteDelitosStringLibetad() As String = "" 'expedientes concatenados con sus delitos, EPX01 por delito del [del01; del02; del03]; EPX02 por delito del [del011; del012; del013]
        Public Property FechaISP As Long = 0
        Public Property FechaIngresoInpe As Long = 0

        'formato de fecha ejmm: 12 de marzo del 2019
        Public ReadOnly Property FechaISPString As String
            Get
                Return Legolas.Components.FechaHora.FechaText(Me.FechaISP, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get
        End Property

        ''' <summary>
        ''' Fecha de ingreso inpe o ISP en formato forto, ejmm: 12/03/2019
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property FechaIngresoInpeStr As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngresoInpe)  ', Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get
        End Property
        ''' <summary>
        ''' Fecha de ingreso inpe o ISP en formato largo cadena, ejmm: 12 de marzo del 2019
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property FechaIngresoInpeString As String
            Get
                Return Legolas.Components.FechaHora.FechaText(Me.FechaIngresoInpe, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get
        End Property




#End Region
#Region "Egreso"
        Private lngFechaEgreso As Long = 0
        Private strLibertadSalaJuzgado As String = ""
        Private strLibertadSalaJuzgadoOtro As String = ""
        Private strLibertadNumeroDocumento As String = ""
        Private strLibertadSecretario As String = ""
        Private strDelito As String = ""
        Private intLibertadTipoID As Integer = -1
        Private strLibertadTipo As String = ""
        Private strDireccion As String = ""
        Public Property FechaEgreso() As Long
            Get
                Return lngFechaEgreso
            End Get
            Set(ByVal value As Long)
                lngFechaEgreso = value
            End Set
        End Property
        Public ReadOnly Property FechaEgresoString() As String
            Get
                'Return Legolas.Components.FechaHora.FechaString(Me.FechaEgreso)
                Return Legolas.Components.FechaHora.FechaText(Me.FechaEgreso, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get
        End Property
        Public Property LibertadSalaJuzgado() As String
            Get
                Return strLibertadSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSalaJuzgado = value
            End Set
        End Property
        Public Property LibertadSalaJuzgadoOtro() As String
            Get
                Return strLibertadSalaJuzgadoOtro.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSalaJuzgadoOtro = value
            End Set
        End Property
        Public Property LibertadSalaJuzgadoCargo() As String = ""
        Public Property LibertadNumeroDocumento() As String
            Get
                Return strLibertadNumeroDocumento.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadNumeroDocumento = value
            End Set
        End Property
        Public Property LibertadSecretario() As String
            Get
                Return strLibertadSecretario.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSecretario = value
            End Set
        End Property
        Public Property Delito() As String
            Get
                Return strDelito.ToUpper
            End Get
            Set(ByVal value As String)
                strDelito = value
            End Set
        End Property
        Public Property LibertadTipoID() As Integer
            Get
                Return intLibertadTipoID
            End Get
            Set(ByVal value As Integer)
                intLibertadTipoID = value
            End Set
        End Property 'd
        Public Property LibertadTipo() As String
            Get
                Return strLibertadTipo.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadTipo = value
            End Set
        End Property
#End Region
#Region "Col"
        Private objRestriccion As Entity.Reporte.CertificadoLibertad.RestriccionCol = Nothing
        Public Property Restricciones() As Entity.Reporte.CertificadoLibertad.RestriccionCol
            Get
                Return objRestriccion
            End Get
            Set(ByVal value As Entity.Reporte.CertificadoLibertad.RestriccionCol)
                objRestriccion = value
            End Set
        End Property
#End Region
#End Region
    End Class
#Region "CertificadoCol"
    Public Class CertificadoCol
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
        Public Function Add(ByVal obj As Certificado) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property Certificado(ByVal Index As Integer) As Certificado
            Get
                Return CType(MyBase.List(Index), Certificado)
            End Get
        End Property
    End Class
#End Region
End Namespace