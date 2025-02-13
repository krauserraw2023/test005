Namespace Reporte.Registro.CertificadoReclusion_v2
    Public Class CertificadoReclusion
        Private strPenalNombre As String = ""
        Public Property InternoID() As Integer = -1
        Public Property InternoIngresoID() As Integer = -1
        Public Property CabeceraRptId As Integer = -1
        Public Property AnioDoc As Integer = Now.Year
        Public Property CodigoPenal As String = ""
        Public Property NumSerieDoc As Integer = 0
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
        Public Property FotoVersionAntigua() As Boolean = True
        Public Property FotoPerfilCentralNombre() As String = ""
        Public Property PathServerImg() As String = "" 'ruta de imagen, 01/02/1235/120028
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
                        objWS.Test()
                        value = objWS.LeerImageJpg(strFotoNameExtension, 1) 'interno
                    Catch ex As Exception
                        'nada
                    End Try
                    If value Is Nothing Then value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
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
                        objWS.Test()
                        value = objWS.LeerArchivoByte(APPWebService.ws_foto.enmTipoImagen.Interno, strFotoNameExtension & ".jpg", Me.PathServerImg)
                    Catch ex As Exception
                        'nada
                    End Try

                    If value Is Nothing Then value = Legolas.Components.Archivo.FileImagenConvertByte(My.Resources.sin_foto)
                End If

                Return value

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
        Public Property Obs() As String = ""
        Public Property FechaEmisionCertificado() As Long = Now.ToFileTime
        Public ReadOnly Property FechaEmisionCertificadoStr() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaEmisionCertificado)
            End Get
        End Property
        Public Property CertificadoAnulado As Boolean = False
        Public Property CertMotivoAnulacion As String = ""
    End Class
End Namespace
