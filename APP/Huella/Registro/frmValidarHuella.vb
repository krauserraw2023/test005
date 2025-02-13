
Imports System.Windows.Forms
Imports Type.Enumeracion.Licencia
Imports APPWebService
Imports System.IO

Namespace Huella.Registro
    Public Class frmValidarHuella

#Region "Propiedades"
        Public Property _InternoID As Integer = -1
        Public Property _TipoDocumento As Integer = -1
        Public Property _NumeroDocumentoUsuario As String = ""
        Public Property _NumeroDocumento() As String
            Get
                Return txtDni.Text
            End Get
            Set(ByVal value As String)
                txtDni.Text = value
            End Set
        End Property
        Public Property _IpPC As String = Legolas.Components.PC.GetIP
        Public Property _Mac As String = Legolas.Components.PC.GetMAC(True)
        Public ObjetoReniec As New APPWebService.ws_reniec_sede.NumeroDocumento
        Public Property _Estado As Integer = -1
        Public Property _RegionID As Integer = -1
        Public Property _PenalID As Integer = -1

        Public Property _TipoLicencia As enmTipoLicencia = enmTipoLicencia.Ninguno
        Private Property TipoImagen() As Type.Enumeracion.ArchivoDigital.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        Public Property _HasImagen() As Boolean = False
#End Region
#Region "Propiedades_Huella"
        Private Property TipoDedoDerecho As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno
        Private Property TipoDedoIzquierdo As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

        Private Property HuellaIzquierda As APPControlHuellaVisita.uscThumbFinger = Nothing
        Private Property HuellaDerecha As APPControlHuellaVisita.uscThumbFinger = Nothing
        Private blnHayDatos As Boolean = False
#End Region
#Region "Listar"
        Public Sub Listar()

            ListarDatosInterno()
            ListarInternoReniec()

        End Sub

        Private Sub ListarDatosInterno()
            If Me._InternoID < 1 Then
                Me.lblmensaje.Visible = True
                Exit Sub
            End If
            Dim bss As New Bussines.Registro.Interno
            Dim objInterno As New Entity.Registro.Interno
            Dim objCol As New Entity.Registro.Interno
            objInterno = bss.Listar(Me._InternoID)
            With objInterno
                txtPrimerApellido.Text = .ApellidoPaterno
                txtPrenombres.Text = .Nombres
                txtSegundoApellido.Text = .ApellidoMaterno
                txtDni.Text = .NumeroDocumento
                txtFechaNac.Text = .FechaNacimientoString
                txtSexo.Text = IIf(.SexoID = 1, "MASCULINO", "FEMENINO")
                Me._RegionID = .RegionID
                Me._PenalID = .PenalID
                _showFotoInternoPrincipal(Me._InternoID, 2)
            End With
            ListarHuellasInterno()
        End Sub
        Private Sub ListarInternoReniec()
            UscDatosInternoReniec1.ListarInternoRNC(ObjetoReniec)
            Me.pnlLeyenda.Visible = False
            UscVisorHuellas1.Visible = True
            UscVisorHuellas1.ListarHuellasReniec()
        End Sub
        ' Dim InternoHuellaId As Integer = -1
        Private Sub ListarHuellasInterno()
            Me.UscVisorHuellas2._InternoId = Me._InternoID
            Me.UscVisorHuellas2.ListarHuellas()
            If UscVisorHuellas2.InternoHuellaId > 0 Then
                Me.ckbHuellas.Checked = True
            Else
                Me.ckbHuellas.Checked = False
            End If
        End Sub


#End Region
#Region "Fotos"
        Public Sub _showFotoInternoPrincipal(ByVal intIDInterno As Integer, intTipoPerfil As Integer)
            Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno

            'Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(intIDPenal)

            If intIDInterno < 1 Or intTipoPerfil < 1 Then
                Me.picFoto.Image = Nothing
                Exit Sub
            End If

            Dim strFotoName As String = ""
            Dim strPathServer As String = ""
            Dim intIDFoto As Integer = -1
            Dim objBss As New Bussines.Registro.InternoFoto

            intIDFoto = objBss.listarIDFotoPrincipal(intIDInterno, intTipoPerfil, strFotoName, strPathServer)

            If intIDFoto < 1 Then
                Me.picFoto.Image = Nothing
                Exit Sub
            End If

            If strPathServer.ToString.Trim = "" Then
                Me.picFoto.Image = ListarImagen(intIDFoto, strFotoName, strPathServer)
            Else
                Me.picFoto.Image = ListarImagen(intIDFoto) 'version5
            End If

            Me._HasImagen = True

        End Sub
        Private Function ListarImagen(ByVal IDArchivoDigital As Integer) As System.Drawing.Image
            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central

            'validar check
            'If Me._CheckImagen = False Then
            '    Return objImagen
            'End If

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

                    objImagenByte = ObjBss.ListarArchivoDigitalByte(IDArchivoDigital, Me._TipoImagen, strMensajeError)

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
        Private Function ListarImagen(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, Optional ByVal PathServerImg As String = "") As System.Drawing.Image

            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central

            'validar check
            'If Me._CheckImagen = False Then
            '    Return objImagen
            'End If

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
#End Region
#Region "Accion"
        Private objCol As New List(Of String)
        Private Function WS_CalidadHuella() As List(Of String)
            'Obtener calidad de huella
            If objCol.Count = 0 Then
                Dim objWS As New APPWebService.ReniecBiometria
                Dim objEnt As New APPWebService.Result.CalidadHuella
                objEnt = objWS.CalidadHuella("43476118", ObjetoReniec.NumeroDNI, Me._IpPC, Me._Mac)
                'huella izquierda
                objCol.Add(objEnt.TipoDedoIzquierdo) 'pos(0)izquierda
                UscVisorHuellas1.lblhuellaizquierda = objEnt.DescripcionHuellaIzquierda
                'huella derecha
                objCol.Add(objEnt.TipoDedoDerecho) 'pos(2)derecha
                UscVisorHuellas1.lblhuelladerecha = objEnt.DescripcionHuellaDerecha
            End If
            Return objCol
        End Function
#End Region

        Private Sub frmValidarHuella_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Listar()
        End Sub

        Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
            Me.Cursor = Cursors.WaitCursor
            Dim mensaje As String = "Desea actualizar las nuevas huellas verificadas" + Chr(13) +
                                    "_______________________________________________" + Chr(13) +
                                    "Si acepta, las 02 huellas capturadas seran" + Chr(13) +
                                    "actualizadas sobre las huellas existentes."
            If Me.btnGrabar.Text = "Actualizar Huella" Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar(mensaje) = DialogResult.OK Then
                    'Actualizar Huella
                End If
            ElseIf Me.btnGrabar.Text = "Registrar interno" Then
                Dim intIDInterno As Integer = -1
                FRM_InternoDetalle(intIDInterno)
            End If
            Me.Cursor = Cursors.Default
            Me.Close()
        End Sub
        Private Sub FRM_InternoDetalle(IDInterno As Long)

            '/*abrir el los permisos del usuario*/

            Dim objEntUsuarioModuloCol As New Legolas.LEntity.Seguridad.UsuarioModuloCol
            Dim objBss As New Legolas.LBusiness.Seguridad.UsuarioModulo

            objEntUsuarioModuloCol = objBss.Listar(Legolas.Configuration.Usuario.Codigo, -1, 31) 'registro penal

            Dim blnLectura As Boolean = False
            Dim blnEscritura As Boolean = False
            Dim blnReporte As Boolean = False
            Dim blnEliminar As Boolean = False

            If objEntUsuarioModuloCol IsNot Nothing Then
                If objEntUsuarioModuloCol.Count = 1 Then
                    blnLectura = objEntUsuarioModuloCol.Item(0).Lectura
                    blnEscritura = objEntUsuarioModuloCol.Item(0).Escritura
                    blnReporte = objEntUsuarioModuloCol.Item(0).Reporte
                    blnEliminar = objEntUsuarioModuloCol.Item(0).Eliminar
                End If
            End If

            Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(Me._PenalID)
            '/*abrir el formulario de internos*/
            'Dim frm As New Registro.Main.Penal.v5.frmMantenimientoV2  'version 5

            'frm.MdiParent = Me.MdiParent
            '    With frm
            '        .InternoID = IDInterno
            '        ._FormLectura = blnLectura
            '        ._FormEscritura = blnEscritura
            '        ._FormReporte = blnReporte
            '        ._FormEliminar = blnEliminar
            '        .Show()
            '    End With

        End Sub

        Private Sub btnVerifHuella_Click(sender As Object, e As EventArgs) Handles btnVerifHuella.Click

            'Verificacion de huellas reniec
            Dim strMensajeOut As String = ""

            If UscVisorHuellas1.VerificarHuella(Me._NumeroDocumentoUsuario, Me.ObjetoReniec.NumeroDNI, Me.HuellaIzquierda._Wsq, Me.HuellaDerecha._Wsq, Me._IpPC, Me._Mac,
                                                strMensajeOut) = True Then

                Me.lblCuerpo1.Text = "CORRESPONDE"
                lblCuerpo2.Text = "La primera impresion dactilar capturada" + Chr(13) +
                                    "corresponde al DNI consultadoo. La segunda" + Chr(13) +
                                    "impresion dactilar capturada corresponde al" + Chr(13) +
                                    "DNI consultado."

                pnlGrabar.Visible = True
                If Me.UscVisorHuellas2.InternoHuellaId < 1 Then
                    Me.btnGrabar.Text = "Registrar" + Chr(13) +
                        "Interno"
                    Me.btnGrabar.Image = My.Resources.Drive___USB_32
                End If
            Else

                If strMensajeOut.Trim.Length > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                Else

                    Me.pnlCuerpo.BackColor = Color.Red
                    Me.lblCuerpo1.Text = "NO CORRESPONDE"
                    lblCuerpo2.Text = "Ninguna de las impresiones dactilares" + Chr(13) +
                                        "capturadas corresponde al DNI consultado."
                    pnlGrabar.Visible = False

                End If
            End If

            Me.lblCabecera.Text = "1 Nueva Autenticacion 1:1"
            Me.UscVisorHuellas1.Visible = False
            Me.pnlLeyenda.Visible = True

            pnlVerificar.Visible = False
        End Sub

        Private Function ValidarHuella() As Boolean
            Dim strMensaje As String = ""
            Dim value As Boolean = False

            'validar que los datos del usuario se listen
            If Me._NumeroDocumentoUsuario.Length = 0 Then
                strMensaje = "No se ha listado el numero de DNI del usuario."
                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje)
                'Me._NumeroDocumento.Focus()
                Return value
            End If

            value = True
            Return value

        End Function
        Private Function FRM_CapturarHuella(enmTipoDedo As Type.Enumeracion.Biometria.TipoDedo) As APPControlHuellaVisita.uscThumbFinger

            Dim uscHuellaActiva As New APPControlHuellaVisita.uscThumbFinger
            uscHuellaActiva._TipoDedo = enmTipoDedo

            Dim frm As New APPControlHuellaVisita.frmCapturaMonoDac_v2(uscHuellaActiva._TipoDedo)
            With frm
                ._UsarBDHuella = False

                If .ShowDialog() = DialogResult.OK Then
                    uscHuellaActiva = frm._uscDedoActual
                End If
            End With

            Return uscHuellaActiva

        End Function


        Private Sub UscVisorHuellas1__click_CapturarHuellaDerecha() Handles UscVisorHuellas1._click_CapturarHuellaDerecha
            If ValidarHuella() = False Then
                Exit Sub
            End If

            Me.TipoDedoDerecho = WS_CalidadHuella.Item(1) ' Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
            Me.HuellaDerecha = FRM_CapturarHuella(Me.TipoDedoDerecho)
            Me.UscVisorHuellas1.Ver_HuellaDerecha(Me.HuellaDerecha._Imagen)

        End Sub

        Private Sub UscVisorHuellas1__click_CapturarHuellaIzquierda() Handles UscVisorHuellas1._click_CapturarHuellaIzquierda
            If ValidarHuella() = False Then
                Exit Sub
            End If
            Me.TipoDedoIzquierdo = WS_CalidadHuella.Item(0)
            Me.HuellaIzquierda = FRM_CapturarHuella(Me.TipoDedoIzquierdo)
            Me.UscVisorHuellas1.Ver_HuellaIzquierda(Me.HuellaIzquierda._Imagen)

        End Sub

    End Class

End Namespace