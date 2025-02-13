Namespace Reporte.Registro.CertificadoLibertad_v2
    Public Class CertificadoLibertad
        Private strPenalNombre As String = ""
        Public Property CabeceraRptId As Integer = -1
        Public Property AnioDoc As Integer = Now.Year
        Public Property NumSerieDoc As Integer = 0
        Public Property CodigoPenal As String = ""
        Public Property PathServerImg() As String = "" 'ruta de imagen, 01/02/1235/120028
        Public Property FotoVersionAntigua() As Boolean = True
        Public Property ApellidoPrimero() As String = ""
        Public Property ApellidoSegundo() As String = ""
        Public Property PreNombres() As String = ""
        Public Property CodigoRP() As String = ""
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
        Public Property FotoPerfilCentralNombre() As String = ""
        Public Property NombresAsociados() As String = ""
        Public ReadOnly Property FotoPC() As Byte()
            Get

                Dim value As Byte() = Nothing
                Dim strFotoNameExtension As String = Me.FotoPerfilCentralNombre.Trim

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
                Dim strFotoNameExtension As String = Me.FotoPerfilCentralNombre.Trim

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
        Public Property Nota() As String = ""
        Public Property CertificadoAnulado As Boolean = False
        Public Property CertMotivoAnulacion As String = ""
        Public Property FechaEmisionCertificado() As Long = Now.ToFileTime
        Public ReadOnly Property FechaEmisionCertificadoStr() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaEmisionCertificado)
            End Get
        End Property



#Region "INGRESO"
        Private strExpedienteSalaJuzgado As String = ""
        Private strExpedienteNumero As String = ""

        Public Property InternoID() As Integer = -1
        Public Property InternoIngresoID() As Integer = -1
        Public Property FechaIngreso() As Long
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
        Public Property ExpedienteDelitosStringLibetad() As String = "" 'expedientes concatenados con sus delitos, EPX01 por delito del [del01; del02; del03]; EPX02 por delito del [del011; del012; del013]
#End Region
#Region "EGRESO"
        Private strLibertadSalaJuzgado As String = ""
        Private strLibertadSalaJuzgadoOtro As String = ""
        Private strLibertadSalaJuzgadoOtroCargo As String = ""
        Private strLibertadNumeroDocumento As String = ""
        Private strLibertadSecretario As String = ""
        Private strLibertadTipo As String = ""
        Private strDelito As String = ""

        Public Property FechaEgreso() As Long = 0
        Public Property ExpedienteNumeroLibertad() As String = "" 'expediente con libertad
        Public Property LibertadSalaJuzgado() As String
            Get
                Return strLibertadSalaJuzgado.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSalaJuzgado = value
            End Set
        End Property
        Public Property LibertadSalaJuzgadoOtroNombre() As String
            Get
                Return strLibertadSalaJuzgadoOtro.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadSalaJuzgadoOtro = value
            End Set
        End Property
        Public Property LibertadSalaJuzgadoOtroCargo() As String
            Get
                Return strLibertadSalaJuzgadoOtroCargo
            End Get
            Set(value As String)
                strLibertadSalaJuzgadoOtroCargo = value
            End Set
        End Property
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
        Public Property LibertadTipo() As String
            Get
                Return strLibertadTipo.ToUpper
            End Get
            Set(ByVal value As String)
                strLibertadTipo = value
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


#End Region
    End Class
#Region "CertificadoCol"
    Public Class CertificadoLibertadCol
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
        Public Function Add(ByVal obj As CertificadoLibertad) As Integer
            Return MyBase.List.Add(obj)
        End Function
        Public ReadOnly Property CertificadoLibertad(ByVal Index As Integer) As CertificadoLibertad
            Get
                Return CType(MyBase.List(Index), CertificadoLibertad)
            End Get
        End Property
    End Class
#End Region
End Namespace