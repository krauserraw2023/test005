Namespace Foto
    Public Class uscFotografia
        Public Event _CheckClick()
        Public Event _NoAutorizado_DoubleClick()

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
        Public Sub _ShowFotoInterno(ByVal ArchivoDigitalID As Integer, ByVal FileName As String, Optional ByVal PathServerImg As String = "")

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
            Me.pbFoto.Image = ListarImagen(ArchivoDigitalID, FileName, PathServerImg)
            'Me.pbFoto.Image = ListarImagen(ArchivoDigitalID, FileName)
        End Sub
        Public Sub _ShowFotoPersonal(ByVal FileName As String)

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Personal
            Me.pbFoto.Image = ListarImagen(1, FileName)

        End Sub
        Public Sub _ShowFotoVisitante(ByVal FileName As String)

            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Visitante
            Me.pbFoto.Image = ListarImagen(1, FileName)

        End Sub
        'Public Sub _ShowFotoLocal(ByVal FileName As String)

        '    'Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Visitante
        '    Me.pbFoto.ImageLocation = FileName

        'End Sub
        Public Sub _ShowFotoVisitante_Byte(objByte As Byte())

            Me.pbFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(objByte)
            Me.pbFoto.SizeMode = PictureBoxSizeMode.Zoom

        End Sub
        Public Sub _mostrarFotoByte(objByte As Byte())

            If objByte Is Nothing Then
                Me.pbFoto.Image = My.Resources.sin_fotografia
                Exit Sub
            End If

            Me.pbFoto.Image = Legolas.Components.Archivo.FileByteConvertImagen(objByte)
            Me.pbFoto.SizeMode = PictureBoxSizeMode.Zoom

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
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se puede hacer zoom a la foto")
                Exit Sub
            End If

            Dim frm As New Foto.frmFotoZoomPopup
            With frm
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
#End Region

        Private Sub pbFotoVisita_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles pbFoto.DoubleClick

            Form_FotoAutoSize()

        End Sub

        Private Sub chkVerFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVerFoto.Click

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
    End Class
End Namespace

