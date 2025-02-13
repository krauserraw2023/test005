Option Explicit On
Imports Type.Combo.ComboTipo
Imports System.IO
Namespace Registro.Huellas
    Public Class uscDatosInternoReniec
        Private objBssInternoRnc As Bussines.Registro.InternoReniec = Nothing
        Private objEnt As Entity.Registro.InternoReniec = Nothing

#Region "Eventos"
        Public Event _Click_CargarUltimaInformacionInterno(Busca As Integer, Cod_ultimo As Integer)
        Public Event _SelectedIndexChanged_ValidacionID(Busca As Integer, Cod_ultimo As Integer, CodInterno As Integer)
        Public Event _DoubleClick_CargarDetalle(objEntRnc As Entity.Registro.InternoReniec)
#End Region
#Region "Propiedades Interno"
        Private Property intInternoID As Integer = -1
        Public Property _InternoID() As Integer
            Get
                Return intInternoID
            End Get
            Set(ByVal value As Integer)
                intInternoID = value
            End Set
        End Property
        Private Property PrimerApellido() As String
            Get
                Return Me.txtPrimerApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrimerApellido.Text = value

            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtSegundoApellido.Text
            End Get
            Set(ByVal value As String)
                Me.txtSegundoApellido.Text = value
            End Set
        End Property

        Private Property PreNombres() As String
            Get
                Return Me.txtPrenombres.Text
            End Get
            Set(ByVal value As String)
                Me.txtPrenombres.Text = value
            End Set
        End Property
        Private Property NumeroDni() As String
            Get
                Return Me.txtDni.Text
            End Get
            Set(ByVal value As String)
                Me.txtDni.Text = value
            End Set
        End Property
        Private Property FechaNacimiento() As String
            Get
                Return Me.txtFechaNac.Text
            End Get
            Set(ByVal value As String)
                Me.txtFechaNac.Text = value
            End Set
        End Property
        Public Property _Version() As Boolean = False

        Private Property NombreAsociadoValID() As Integer = -1
        Private Property NombreAsociadoValNom() As String = ""
        Private Property FechaInscripcion() As String = ""

        Private Property FechaExpedicion() As String = ""
        '    Get
        '        Return lblFechaExpedicion.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.lblFechaExpedicion.Text = value
        '    End Set
        'End Property
        Private Property Restriccion() As String = ""
        '    Get
        '        Return lblRestriccion.Text
        '    End Get
        '    Set(ByVal value As String)
        '        Me.lblRestriccion.Text = value
        '    End Set
        'End Property
#End Region
#Region "Propiedades_Clase"
        Public Property _Contador As Integer = -1
        Public Property _VarHistorico As Integer = 0
        Private Property RegionID As Integer = -1
        Private Property PenalID As Integer = -1
        Private Property BusquedaID As Integer = -1
        Private Property ComparacionID As Integer = -1
        Private Property ListaInternoData As String = ""
        Private Property ListaReniecdata As String = ""
        Private Property FechaValidacion As Date
        Private Property Observaciones As String = ""
        Private Property PthServidor As String = ""
        Private Property VariableColor As String = ""
        Private Property strLista As String = ""
#End Region
#Region "Propiedades Fotografia"
        Private Property PerfilActual As Integer
        Public Property _CopiaImagen As Integer = -1
        Public Property _CopiaNombreImagen As String = ""
        Private Sub ShowFotografia()
            Dim blnVerFoto As Boolean = False
            If _InternoID < 1 Then
                _Limpiar()
                Exit Sub
            Else
                Dim objBssFoto As New Bussines.Registro.InternoFoto
                Dim objEntVal As New Entity.Registro.InternoReniec

                Dim intCodigo As Integer = objBssFoto.ValidarFotoReniec(_InternoID, Me._VarHistorico)

                Dim intImagen As Integer = -1
                Dim intNombreImagen As String = ""
                Dim strPathServerImg As String = ""

                objBssFoto = New Bussines.Registro.InternoFoto

                objEntVal = objBssFoto.ListarFotoReniec(intCodigo, 1)
                If objEntVal.Codigo > 0 Then
                    With objEntVal
                        intImagen = .PFrenteRnc
                        intNombreImagen = .PFrenteName
                        strPathServerImg = .PthServidor
                    End With
                    _ShowFotoInterno2(intImagen, IIf(Me.BusquedaID = 3, 0, intNombreImagen), Me.PthServidor)
                Else
                    _Limpiar()
                End If
            End If
        End Sub
        Private Property PerfilFotografia() As Integer
            Get
                Dim value As Integer = -1

                ' ''If Me.rdbPI.Checked = True Then
                ' ''    value = 1
                ' ''End If

                ' ''If Me.rdbPF.Checked = True Then
                value = 2
                ' ''End If

                ' ''If Me.rdbPD.Checked = True Then
                ' ''    value = 3
                ' ''End If
                Return value
            End Get
            Set(ByVal value As Integer)
            End Set
        End Property
#End Region
#Region "Propiedades_Parametricas"
        Private Property TipoImagen() As Type.Enumeracion.ArchivoDigital.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        Public Property _SizeMode() As System.Windows.Forms.PictureBoxSizeMode
            Get
                Return Me.picFoto.SizeMode
            End Get
            Set(ByVal value As System.Windows.Forms.PictureBoxSizeMode)
                Me.picFoto.SizeMode = value
            End Set
        End Property
#End Region
#Region "Propiedades Otros"
        Public Property _CondicionBusqueda As Integer = -1
        Public Property _EnabledDobleClick() As Boolean = False
        Public Property _HasImagen() As Boolean = False
#End Region
#Region "Combo"
        Private blnHistorial As Boolean = False

#End Region
#Region "Listar"
        Public Property Fecha() As Long = 0
        Public Sub ListarInternoReniec(dni As String)
            Dim bss As New Bussines.Globall.Reniec
            Dim rpt As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
            rpt = bss.WS_ReniecxDNI_Resultado(dni)
            If rpt.Error_Cod < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Codigo error: " & rpt.Error_Cod & ", Mensaje: " & rpt.Error_Mensaje)
                Exit Sub
            End If
            If rpt.Error_Cod = 5114 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(rpt.Error_Mensaje & " o no existe.")
                Exit Sub
            End If
            If rpt.Error_Cod = 5111 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(rpt.Error_Mensaje)
                Exit Sub
            End If
            If rpt.Error_Cod = 0 Then
                Me.Cursor = Cursors.WaitCursor
                Dim p As New APPWebService.ws_reniec_sede.NumeroDocumento
                p = rpt.Resultado
                With p
                    txtDni.Text = .NumeroDNI
                    '    txtDigitoVeri.Text = .DigitoVerificacion
                    txtPrimerApellido.Text = .ApellidoPaterno.Trim
                    txtSegundoApellido.Text = .ApellidoMaterno.Trim
                    '   txtApellidoCasada.Text = .ApellidoCasada.Trim
                    txtPrenombres.Text = .Nombres.Trim
                    txtFechaNac.Text = .FechaNacimiento
                    txtSexo.Text = IIf(.Sexo = 1, "MASCULINO", "FEMENINO")

                    'txtRestriccion.Text = IIf(.Restriccion = "  ", "NINGUNA", Trim(.Restriccion))
                    Try
                        Dim ms As MemoryStream = New MemoryStream(.FotoByte)
                        picFoto.Image = Image.FromStream(ms)
                    Catch ex As Exception
                        picFoto.Image = Nothing
                    End Try
                End With
                Me.Cursor = Cursors.Default
            End If
        End Sub
        Public Sub ListarInternoRNC(ObjetoReniec As APPWebService.ws_reniec_sede.NumeroDocumento)
            ' Dim bss As New Bussines.Globall.Reniec
            '  Dim rpt As APPWebService.ws_reniec_sede.DTO_ResultOfNumeroDocumento
            With ObjetoReniec
                Me.Cursor = Cursors.WaitCursor
                Me.NumeroDni = .NumeroDNI
                Me.PrimerApellido = .ApellidoPaterno.Trim
                Me.SegundoApellido = .ApellidoMaterno.Trim
                Me.PreNombres = .Nombres.Trim
                Me.FechaNacimiento = .FechaNacimiento
                Me.txtSexo.Text = IIf(.Sexo = 1, "MASCULINO", "FEMENINO")
                'txtRestriccion.Text = IIf(.Restriccion = "  ", "NINGUNA", Trim(.Restriccion))
                Try
                    Dim ms As MemoryStream = New MemoryStream(.FotoByte)
                    picFoto.Image = Image.FromStream(ms)
                Catch ex As Exception
                    picFoto.Image = Nothing
                End Try
                Me.Cursor = Cursors.Default
            End With

        End Sub
#End Region
#Region "Function"

        Private Function ListarImagen2(ByVal ArchivoDigitalID As Integer, ByVal NameFile As String, RutaWeb As String) As System.Drawing.Image

            Dim objImagen As System.Drawing.Image = My.Resources.sin_fotografia
            Dim intTipoLocal As Integer = 3 'sede central
            Dim r As APPWebService.ws_foto.DTO_ResultOfDto_ArchivoDigital
            Try
                Dim objBss As New Bussines.Sistema.Instalacion
                intTipoLocal = objBss.ListarTipo(Legolas.LBusiness.Globall.WinApp.LicenciaApp)
            Catch ex As Exception
                intTipoLocal = -1
            End Try

            'validar la ruta
            If NameFile.Trim = "" Then
                Return objImagen
            End If

            If ArchivoDigitalID < 1 Then
                'no hay foto
                objImagen = My.Resources.sin_fotografia
                Me._HasImagen = False
            Else
                'si hay foto
                Dim objWS As New APPWebService.ws_foto.PopeLocal
                objWS.Timeout = -1
                objWS.Url = APPWebService.PathURL.WSPopeLocal

                Dim objImagenByte As Byte()
                Dim objImagenStream As New IO.MemoryStream

                Dim strFotoNameExtension As String = NameFile

                Try 'APPWebService.ws_foto.TipoCarpeta.Reniec
                    r = objWS.ListarArchivoDigital(ArchivoDigitalID, 4)
                    objImagenByte = r.Resultado.ArchivoByte
                    objWS.Dispose()
                    objWS = Nothing
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
                    Me._EnabledDobleClick = True
                End If
                Me._HasImagen = True
            End If

            Return objImagen

        End Function
        'Public Sub _ShowFotoInterno(ByVal ArchivoDigitalID As Integer, ByVal FileName As String)

        '    Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Interno
        '    Me.picFoto.Image = ListarImagen(ArchivoDigitalID, FileName)

        'End Sub
        Public Sub _ShowFotoInterno2(ByVal ArchivoDigitalID As Integer, ByVal FileName As String, Ruta As String)
            'Me.TipoImagen = Type.Enumeracion.ArchivoDigital.TipoImagen.Reniec
            Me.picFoto.Image = ListarImagen2(ArchivoDigitalID, FileName, Ruta)

        End Sub
        Public Sub _Limpiar()
            'Me._PanelAutorizacion = False
            Me.picFoto.Image = My.Resources.sin_foto
            Me._HasImagen = False
        End Sub
        Private Function ComparacionCadenas(TestStr1 As String, TestStr2 As String) As Integer
            Dim TestComp As Integer
            ' valores         -1= no se parecen,0=iguales
            TestComp = StrComp(TestStr1, TestStr2, CompareMethod.Text)
            Return TestComp
        End Function
        Public Sub _Show_FotoAutoSize()
            Form_FotoAutoSize()
        End Sub
        Private Sub Form_FotoAutoSize()

            If Me._EnabledDobleClick = False Then
                Exit Sub
            End If

            If Me.picFoto.Image Is Nothing = True Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(
                "No se puede hacer zoom a la foto")
                Exit Sub
            End If

            Dim frm As New Foto.frmFotoZoomPopup
            With frm
                ._pImagen = Me.picFoto.Image
                ._pSizeMode = PictureBoxSizeMode.Zoom
                .ShowDialog()
            End With

        End Sub
#End Region
#Region "Accion"
        Public Sub ProcesoVisualizacion(valor As Boolean)
            Me.Visible = True
            gbLeyenda.Visible = True
            pnlFotoVis.Size = New Size(190, 210)
            pnlCabecera.BackColor = Color.MidnightBlue
            lblCabecera.Text = "1 Nueva Autenticacion 1:1"
            txtSexo.Visible = False
            lblsexo.Visible = False
            If valor = True Then
                If Me.TipoImagen = 1 Then 'cuando existe la huella

                ElseIf TipoImagen = 2 Then 'cuando la huella es nueva

                End If
                pnlCuerpo.BackColor = Color.ForestGreen
                lblCuerpo1.Text = "CORRESPONDE"
                lblCuerpo2.Text = "La primera impresion dactilar capturada" + Chr(13) +
                                    "corresponde al DNI consultadoo. La segunda" + Chr(13) +
                                    "impresion dactilar capturada corresponde al" + Chr(13) +
                                    "DNI consultado."
            Else
                pnlCuerpo.BackColor = Color.Red
                lblCuerpo1.Text = "NO CORRESPONDE"
                lblCuerpo2.Text = "Ninguna de las impresiones dactilares" + Chr(13) +
                                    "capturadas corresponde al DNI consultado."
            End If
        End Sub
        Private Sub picFoto_DoubleClick(sender As Object, e As System.EventArgs)
            Form_FotoAutoSize()
        End Sub
#End Region

#Region "ValoresxDefault"

#End Region

        Private Sub cbbHistorial_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
        Private Sub dgwGrillaDetalle_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

        End Sub

        Private Sub dgwGrillaDetalle_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
            If objEnt.InternoSisData <> "" And e.RowIndex <> -1 Then
                RaiseEvent _DoubleClick_CargarDetalle(Me.objEnt)
            End If
        End Sub

        Private Sub picFoto_Click(sender As System.Object, e As System.EventArgs)

        End Sub

        Private Sub dgwGrillaDetalle_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub

        Private Sub uscDatosInternoReniec_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.gbLeyenda.Visible = False
        End Sub
    End Class
End Namespace


