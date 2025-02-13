Imports System.Drawing

Namespace Reporte.CertificadoReclusion
    Public Class Certificado
#Region "Propiedades"
        Private strPenalNombre As String = ""
        Public Property PathServerImg() As String = "" 'ruta de imagen, 01/02/1235/120028
        Public Property FotoVersionAntigua() As Boolean = True
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
        Public Property FechaIngreso() As Long = 0
        Public ReadOnly Property FechaIngresStrLargo() As String
            Get
                Return Legolas.Components.FechaHora.FechaText(Me.FechaIngreso, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get

        End Property
        Public ReadOnly Property FechaIngresStr() As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaIngreso)
            End Get

        End Property
        Public Property InternoIngresoID() As Long = -1
        Public Property IngresoInpeId As Integer = -1
        Public Property InternoExpedienteID() As Long = -1
        'Public Property PathInternoWeb() As String
        '    Get
        '        Return strPathInternoWeb
        '    End Get
        '    Set(ByVal value As String)
        '        strPathInternoWeb = value
        '    End Set
        'End Property
        Public Property FotoPerfilCentral() As String = ""
        Public Property FotoPerfilCentralId() As Integer = -1
        Public Property TipoLocal As Integer = -1
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
                Dim strFotoNameExtension As String = Me.FotoPerfilCentral.Trim

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
                        'value = objWS.LeertrwterwImageJpg(strFotoNameExtension, 1) 'interno
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
        Public Property Obs() As String = ""
        Public Property NombresAsociados() As String = ""
        Public Property FechaISP As Long = 0
        'formato de fecha ejmm: 12 de marzo del 2019
        Public ReadOnly Property FechaISPString As String
            Get
                Return Legolas.Components.FechaHora.FechaText(Me.FechaISP, Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get
        End Property
        'formato dia/mes/anio
        Public ReadOnly Property FechaISPStr As String
            Get
                Return Legolas.Components.FechaHora.FechaString(Me.FechaISP)  ', Legolas.Components.FechaHora.enmFechaLong.enmdma)
            End Get
        End Property
#Region "Col"
        Private objExpediente As Entity.Reporte.CertificadoReclusion.ExpedienteCol = Nothing
        Private objDelito As Entity.Reporte.DelitoCol = Nothing
        Public Property Expediente() As Entity.Reporte.CertificadoReclusion.ExpedienteCol
            Get
                Return objExpediente
            End Get
            Set(ByVal value As Entity.Reporte.CertificadoReclusion.ExpedienteCol)
                objExpediente = value
            End Set
        End Property
        Public Property Delito() As Entity.Reporte.DelitoCol
            Get
                Return objDelito
            End Get
            Set(ByVal value As Entity.Reporte.DelitoCol)
                objDelito = value
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