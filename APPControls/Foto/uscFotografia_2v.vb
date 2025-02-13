Imports System.Configuration

Namespace Foto
    Public Class uscFotografia_2v
        Public Event _CheckClick()
        Public Event _NoAutorizado_DoubleClick()
#Region "Enum"
        Public Enum enmFotoPerfil
            Ninguno = 0
            Izquierdo = 1
            Frontal = 2
            Derecho = 3
        End Enum
#End Region
#Region "Propiedades_Parametricas"
        Private Property TipoImagen() As Type.Enumeracion.ArchivoDigital.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        Public Property SizeMode() As System.Windows.Forms.PictureBoxSizeMode
            Get
                Return Me.pbFoto.SizeMode
            End Get
            Set(ByVal value As System.Windows.Forms.PictureBoxSizeMode)
                Me.pbFoto.SizeMode = value
            End Set
        End Property
#End Region
#Region "Propiedades_UserControl"
        Private blnEnabledDobleClick As Boolean = True
        Public Property _CheckImagen() As Boolean
            Get
                Return Me.chkVerFoto.Checked
            End Get
            Set(ByVal value As Boolean)
                Me.chkVerFoto.Checked = value
            End Set
        End Property
        Public Property _PanelCheck() As Boolean
            Get
                Return Me.pnlCheck.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.pnlCheck.Visible = value
            End Set
        End Property
        Public Property _PanelAutorizacion() As Boolean
            Get
                Return Me.lblAutorizado.Visible
            End Get
            Set(ByVal value As Boolean)
                Me.lblAutorizado.Visible = value
            End Set
        End Property
        Public Property _EnabledDobleClick() As Boolean
            Get
                Return blnEnabledDobleClick
            End Get
            Set(ByVal value As Boolean)
                blnEnabledDobleClick = value
            End Set
        End Property
        Public Property _HasImagen() As Boolean = False
#End Region
#Region "Functions"
        Private Function ListarImagen(ByVal IDArchivoDigital As Integer) As System.Drawing.Image

            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central
            lblError.Text = ""
            'validar check
            If Me._CheckImagen = False Then
                Return objImagen
            End If

            'validar la ruta
            If IDArchivoDigital < 1 Then
                Return objImagen
            End If

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Timeout = 7000 'NUEVO JMR
            objWS.Url = APPWebService.PathURL.WSPopeLocal

            'test al web service
            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                objImagen = My.Resources.ws_config
                Return objImagen
            End Try

            'listamos el tipo de licencia donde estamos
            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            If IDArchivoDigital < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
                Me._HasImagen = False
            Else

                'si hay foto             
                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim ObjBss As New Bussines.Globall.ArchivoDigital
                Dim strMensajeError As String = ""

                Try
                    Select Case intTipoLocal
                        Case 2 'solo para regiones 
                            objImagenByte = ObjBss.getArchivoDigitalByte_Region(IDArchivoDigital, Me._TipoImagen, strMensajeError)
                        Case Else
                            objImagenByte = ObjBss.ListarArchivoDigitalByte(IDArchivoDigital, Me._TipoImagen, strMensajeError)
                    End Select


                    If strMensajeError.Trim.Length > 0 Then
                        'si hay error
                        objImagen = My.Resources.sin_fotografia
                        Me._HasImagen = False
                    End If

                Catch ex As Exception
                    objImagenByte = Nothing
                End Try

                If objImagenByte Is Nothing Then

                    Select Case intTipoLocal
                        Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                            Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana,
                            Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                            objImagen = My.Resources.fotografia_por_transferir

                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select

                    If intTipoLocal = Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana Then
                        ' MODIFICADO POR JONATAN 06/01/2025
                        ' EN CASO EL ARCHIVO NO SE ENCUENTRE LOCALMENTE, SE MOSTRARA UN MENSAJE, PERO IGUAL BUSCARA USANDO EL WS PARA OBTENER LA FOTO DESDE LIMA

                        Dim objBssFoto = New Bussines.Registro.InternoFoto

                        Dim objEnt As New Entity.Registro.InternoFoto


                        objEnt = objBssFoto.ObtenerCodigoFOTO_SEDE(IDArchivoDigital)
                        Dim ArchivoDigitalIDLocal = IDArchivoDigital
                        IDArchivoDigital = objEnt.SedeRowId

                        lblError.Text = "No se encotro el archivo Local."

                        objWS.Url = APPWebService.PathURL.WSPopeSedeCentral

                        Try 'APPWebService.ws_foto.TipoCarpeta.Reniec
                            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
                            r = objWS.ListarArchivoDigital(IDArchivoDigital, Me._TipoImagen)
                            objImagenByte = r.Resultado.ArchivoByte
                            objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                            objImagen = Image.FromStream(objImagenStream)

                            objWS.Url = APPWebService.PathURL.WSPopeLocal
                            objWS.UploadImageJpg(objImagenByte, ObtenerNombre(ArchivoDigitalIDLocal), r.Resultado.Tipo)
                        Catch ex As Exception
                            objImagenByte = Nothing
                            objImagen = My.Resources.nspm_fotografia
                        End Try

                    End If

                Else

                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)

                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                End If
                Me._HasImagen = True
            End If

            Return objImagen

        End Function
        ' MODIFICADO POR JONATAN 08/01/2025 -- OBTIENE LA RUTA DONDE SE ALMACENA EL ARCHIVO DE FOTO
        Private Function ObtenerNombre(ByVal ArchivoID As Int32) As String
            Try

                Dim Bss As New Bussines.Globall.ArchivoDigital

                Dim archivoDigital2 As Entity.Globall.ArchivoDigital = Bss.Listar_ArchivoDigital_v2(ArchivoID)

                Dim flag As Boolean = False
                Dim path As String

                If String.IsNullOrWhiteSpace(archivoDigital2.RutaServidor) Then
                    flag = True
                    path = archivoDigital2.NombreFisico
                Else
                    flag = False
                    path = IO.Path.Combine(archivoDigital2.RutaServidor, archivoDigital2.NombreFisico & "." & archivoDigital2.Extension)

                    If Not IO.File.Exists(path) Then
                        path = IO.Path.Combine(archivoDigital2.RutaServidor, archivoDigital2.NombreFisico)
                    End If
                End If
                Return path
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return ""
            End Try

        End Function

        Private Function ListarImagen(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, Optional ByVal PathServerImg As String = "") As System.Drawing.Image

            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central

            'validar check
            If Me._CheckImagen = False Then
                Return objImagen
            End If

            'validar la ruta
            If NameFile.Trim = "" Then
                Return objImagen
            End If

            Dim objWS As New APPWebService.ws_foto.PopeLocal
            objWS.Url = APPWebService.PathURL.WSPopeLocal

            'test al web service
            Try
                Dim lngFecha As Long = objWS.FechaHoy()
            Catch ex As Exception
                objImagen = My.Resources.ws_config
                Return objImagen
            End Try

            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            If ArchivoDigitalID < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
                Me._HasImagen = False
            Else
                'si hay foto             
                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim strFotoNameExtension As String = NameFile

                Try
                    If PathServerImg = "" Then 'si es imagen de la version anterior debe ser vacío
                        objImagenByte = objWS.LeerImageJpg(strFotoNameExtension, Me._TipoImagen)
                    Else
                        objImagenByte = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(ArchivoDigitalID, Me.TipoImagen, "") ' sd objWS.LeerArchivoByte(Me._TipoImagen, strFotoNameExtension & ".jpg", PathServerImg)
                    End If
                Catch ex As Exception
                    objImagenByte = Nothing
                End Try

                If objImagenByte Is Nothing Then

                    Select Case intTipoLocal
                        Case 3, 2
                            objImagen = My.Resources.fotografia_por_transferir
                        Case Else
                            objImagen = My.Resources.fotografia_eliminada
                    End Select

                Else

                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)

                    Try
                        objImagen = Image.FromStream(objImagenStream)
                    Catch ex As Exception
                        objImagen = My.Resources.nspm_fotografia
                    End Try
                End If
                Me._HasImagen = True
            End If

            Return objImagen

        End Function
        Public Sub _ShowFotoInterno(ByVal ArchivoDigitalID As Integer, Optional ByVal verFotografiaSedeCentral As Boolean = False)
            If ArchivoDigitalID = -1 Then
                Me.pbFoto.Image = Nothing
                Exit Sub
            End If

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
            If verFotografiaSedeCentral = False Then
                Me.pbFoto.Image = ListarImagen(ArchivoDigitalID)
            Else
                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                objImagenByte = (New Bussines.Globall.ArchivoDigital).ListarArchivoDigitalByte(ArchivoDigitalID, Me._TipoImagen, "", True)
                If Not objImagenByte Is Nothing Then
                    objImagenStream.Write(objImagenByte, 0, objImagenByte.Length)
                    Me.pbFoto.Image = Image.FromStream(objImagenStream)
                Else
                    Me.pbFoto.Image = Nothing
                End If

            End If

        End Sub

        Public Sub _showFotoInternoPrincipal(ByVal intIDInterno As Integer, intTipoPerfil As enmFotoPerfil)

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno

            'Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(intIDPenal)

            If intIDInterno < 1 Or intTipoPerfil < 1 Then
                Me.pbFoto.Image = Nothing
                Exit Sub
            End If

            Dim strFotoName As String = ""
            Dim strPathServer As String = ""
            Dim intIDFoto As Integer = -1
            Dim objBss As New Bussines.Registro.InternoFoto

            intIDFoto = objBss.listarIDFotoPrincipal(intIDInterno, intTipoPerfil, strFotoName, strPathServer)

            If intIDFoto < 1 Then
                Me.pbFoto.Image = Nothing
                Exit Sub
            End If

            If strPathServer.ToString.Trim = "" Then
                Me.pbFoto.Image = ListarImagen(intIDFoto, strFotoName, strPathServer)
            Else
                Me.pbFoto.Image = ListarImagen(intIDFoto) 'version5
            End If

            Me._HasImagen = True

        End Sub

        Public Sub _ShowFotoVisitante(ByVal ArchivoDigitalID As Integer)

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Visitante
            Me.pbFoto.Image = ListarImagen(ArchivoDigitalID)

        End Sub

        Public Sub _cargarImagen(objImage As Image)

            Me.pbFoto.Image = objImage

        End Sub
        Public Sub _Limpiar()
            Me._PanelAutorizacion = False
            Me.pbFoto.Image = My.Resources.sin_foto
            Me._HasImagen = False
        End Sub
#End Region
#Region "Otros"

        Public Sub _Show_FotoAutoSize()
            Form_FotoAutoSize()
        End Sub
        Private Sub Form_FotoAutoSize()

            If Me._EnabledDobleClick = False Then
                Exit Sub
            End If

            If Me.pbFoto.Image Is Nothing = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "No se puede hacer zoom a la foto")
                Exit Sub
            End If

            Dim frm As New Foto.frmFotoZoomPopup
            With frm
                .FormBorderStyle = FormBorderStyle.SizableToolWindow
                ._pImagen = Me.pbFoto.Image
                ._pSizeMode = PictureBoxSizeMode.Zoom
                .ShowDialog()
            End With

        End Sub
        Private Sub LoadToolTipText()

            With Me.ToolTip1
                .SetToolTip(Me.lblAutorizado, "Haga doble click, para ver mas detalles")
                .SetToolTip(Me.pbFoto, "Haga doble click, para aumentar el tamaño")
            End With
        End Sub
        Public Sub _Show_Silueta()
            Me.pbFoto.Image = My.Resources.silueta
            Me.pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End Sub
#End Region

        Private Sub pbFotoVisita_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFoto.DoubleClick

            Form_FotoAutoSize()

        End Sub

        Private Sub chkVerFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerFoto.Click
            lblError.Text = ""
            RaiseEvent _CheckClick()

        End Sub

        Private Sub lblAutorizado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAutorizado.DoubleClick

            RaiseEvent _NoAutorizado_DoubleClick()

        End Sub

        Private Sub uscFotografia_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            LoadToolTipText()

        End Sub

        Private Sub chkVerFoto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkVerFoto.CheckedChanged

        End Sub

        Private Sub pbFoto_Click(sender As System.Object, e As System.EventArgs) Handles pbFoto.Click

        End Sub
    End Class
End Namespace

