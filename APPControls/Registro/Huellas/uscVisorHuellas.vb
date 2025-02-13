Imports System.Data
Imports System.Data.SqlClient
Imports APPControlHuellaVisita.Type.Enumeracion

Imports System.Drawing
Imports System.Windows.Forms
Namespace Registro.Huellas
    Public Class uscVisorHuellas

        Private strRutTmp As String = Application.StartupPath & "\tmp\tmp_bmt\"
        Public Event _click_CapturarHuellaDerecha()
        Public Event _click_CapturarHuellaIzquierda()
#Region "Propiedades publicas"
        Public InternoHuellaId As Integer = -1
        Public Property _InternoId() As Integer
        Public Property _RegId As Integer
        Public Property _PenId As Integer
        Public Property _TipDocIdentId As Integer = -1
        Public Property _NumDocIdent As String = ""
        Public Property _CodRP As String = ""
        Public Property _ApePat As String = ""
        Public Property _ApeMat As String = ""
        Public Property _Nombres As String = ""

#End Region
#Region "PropiedadesHuellas"
        Public Property lblhuelladerecha() As String
            Get
                Return lblDedoSelDerecho.Text
            End Get
            Set(ByVal value As String)
                lblDedoSelDerecho.Text = value
            End Set
        End Property
        Public Property lblhuellaizquierda() As String
            Get
                Return lblDedoSelIzquierdo.Text
            End Get
            Set(ByVal value As String)
                lblDedoSelIzquierdo.Text = value
            End Set
        End Property
        Private Sub CargarImagenHuella(huellaTemplateId As Integer, visorHulla As APPControlHuellaVisita.uscThumbFinger)
            Dim ImageHuella As Byte() = Nothing
            If huellaTemplateId = -1 Then
                visorHulla.LimpiarHuella()
                Exit Sub
            End If

            Dim bssSysBio As New APPControlHuellaVisita.Business.SysBiometria(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

            Dim entWsq As APPControlHuellaVisita.Entity.Ent_HuellaWSQ = Nothing
            Dim entTmpl As APPControlHuellaVisita.Entity.Ent_HuellaTemplate = Nothing

            entTmpl = bssSysBio.ListarTemplate(huellaTemplateId, "")
            If entTmpl Is Nothing Then Exit Sub

            visorHulla._Observacion = entTmpl.Observacion
            visorHulla._IndiceCalidad = entTmpl.IndiceCalidadImg
            visorHulla._EstadoDedo = entTmpl.EstadoDedo
            visorHulla._Codigo = entTmpl.Codigo

            entWsq = bssSysBio.ListarWSQ_X_TemplateCod(entTmpl.Codigo, "")
            If Not entWsq Is Nothing Then
                'visorHulla._MostrarHuellaFalsa()
                ' ImageHuella = entWsq.WSQFile
                visorHulla._ImagenHuellaByte = bssSysBio.ObtenerImagenByteDesdeWSQ(entWsq.WSQFile, "")
                visorHulla._Wsq = entWsq.WSQFile
                ''visorHulla._ImagenHuellaByte = APPHuella.NegocioDEMO.ObtenerImagenHuella(strRutTmp, entWsq.WSQFile)
                'Else
                'visorHulla._ImagenHuellaByte = Nothing
            End If
        End Sub
        Private intIndCal As Integer = -1
        Private img As Byte() = Nothing
        Public Property _IndiceCalidad(lblcalidad As Label) As Integer
            Get
                Return intIndCal
            End Get
            Set(value As Integer)
                intIndCal = value
                'If value > 0 Then
                Select Case value
                    Case Is > 3
                      '  lblDedo.Image = My.Resources.Circle_Invalido16x16
                    Case 1 'alta calidad
                        lblcalidad.Image = My.Resources.Circle_Green16x16
                    Case 2 'calidad media
                        lblcalidad.Image = My.Resources.Circle_Red16x16 '._1420838563_Circle_Blue
                    Case 3 'calidad baja
                        lblcalidad.Image = My.Resources.Circle_Yellow16x16
                    Case Else
                        lblcalidad.Image = Nothing
                End Select
                'End If
            End Set
        End Property
#End Region
#Region "Listar"
        Public Sub ListarHuellas()
            Me.gbHuellas.Text = "Huellas del interno"
            'validar
            Dim sms As String = ""
            If Me._RegId = -1 Then
                sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Id del región no especificado"
            ElseIf Me._PenId = -1 Then
                sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Id del penal no especificado"
                If Me._RegId = 3 Then 'region lima
                    sms = ""
                End If
            End If
            If sms.Trim.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
                Exit Sub
            End If
            ' ----------------  ListarHuellas(wsCol)---------------------------------------
            If System.IO.Directory.Exists(strRutTmp) = False Then System.IO.Directory.CreateDirectory(strRutTmp)

            ''---------------listar internoHuella por InternoId
            Dim bssIntHuell As New Bussines.Biometria.InternoHuella

            Dim entIntHuellCol As New Entity.Biometria.InternoHuellaCol
            Dim entIntHuell As New Entity.Biometria.InternoHuella

            If Me._InternoId > 0 Then
                entIntHuell.InternoId = Me._InternoId
                entIntHuellCol = bssIntHuell.Listar(entIntHuell, "")
            End If
            If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                entIntHuell = entIntHuellCol.InternoHuella(0)
                Me.InternoHuellaId = entIntHuell.Codigo

                CargarImagenHuellas(entIntHuell.HuellaDigIndIzqId, lblDedoSelIzquierdo, lblDedoIzquierdo, pbVisorIzquierdo)
                CargarImagenHuellas(entIntHuell.HuellaDigIndDerId, lblDedoSelDerecho, lblDedoDerecho, pbVisorDerecho)
            Else
                pbVisorIzquierdo.Image = My.Resources.huella_x
                pbVisorDerecho.Image = My.Resources.huella_x
            End If
        End Sub

        Public Sub ListarHuellasReniec()
            Me.lblhuellaizquierda = "Huella Izquierda"
            Me.lblhuelladerecha = "Huella Derecha"
            Me.btnCapturaIzquierda.Visible = True
            Me.btnCapturaDerecha.Visible = True
        End Sub

#End Region
#Region "ProcesosHuella"

        Private Sub CargarImagenHuellas(huellaTemplateId As Integer, lblHuella As Label, lblCalidad As Label, visor As PictureBox)

            Dim bssSysBio As New APPControlHuellaVisita.Business.SysBiometria(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

            Dim entWsq As APPControlHuellaVisita.Entity.Ent_HuellaWSQ = Nothing
            Dim entTmpl As APPControlHuellaVisita.Entity.Ent_HuellaTemplate = Nothing

            entTmpl = bssSysBio.ListarTemplate(huellaTemplateId, "")
            If entTmpl Is Nothing Then Exit Sub

            lblHuella.Text = entTmpl.TipoDedoId.ToString
            lblCalidad.Text = entTmpl.IndiceCalidadImg.ToString
            Me._IndiceCalidad(lblCalidad) = entTmpl.IndiceCalidadImg

            'visorHulla._Codigo = entTmpl.Codigo
            entWsq = bssSysBio.ListarWSQ_X_TemplateCod(entTmpl.Codigo, "")
            If Not entWsq Is Nothing Then
                'wsqHuella._Wsq = entWsq.WSQFile
                Me.img = bssSysBio.ObtenerImagenByteDesdeWSQ(entWsq.WSQFile, "")
                Me._ImagenHuellaByte(visor) = Me.img
            End If
        End Sub
        Public Property _ImagenHuellaByte(pbVisor As PictureBox) As Byte()
            Get
                Return img
            End Get
            Set(value As Byte())
                img = value
                If Not img Is Nothing Then
                    Dim m As New System.IO.MemoryStream(img)
                    pbVisor.Image = Image.FromStream(m)
                    pbVisor.Image.RotateFlip(RotateFlipType.Rotate180FlipY) 'jmr, codigo para cambiar el reflejo de la huella, debe ser condicionado con el tipo de dispositivo tipo 4
                ElseIf img Is Nothing Then
                    pbVisor.Image = My.Resources.huella_x
                    img = Nothing
                End If
            End Set
        End Property
#End Region


        Public Function VerificarHuella(_NumeroDocumentoUsuario As String, _NumeroDocumento As String, HuellaIzquierda As Byte(),
                                        HuellaDerecha As Byte(), ipPC As String, Mac As String, ByRef strMensajeOut As String) As Boolean

            Dim objWS As New APPWebService.ReniecBiometria
            Dim objEnt As New APPWebService.Result.VerificarHuella
            Dim value As Boolean = False

            If _NumeroDocumento = "40283404" Then ' Huella Existente
                Dim wsqizq() As Byte
                Dim wsqder() As Byte

                'pc jonh
                'wsqizq = Legolas.Components.Archivo.FileConvertByte("E:\jonh_huella\jhon_ind_izq.wsq")
                'wsqder = Legolas.Components.Archivo.FileConvertByte("E:\jonh_huella\jhon_ind_der.wsq")

                'pc jmr
                wsqizq = Legolas.Components.Archivo.FileConvertByte("D:\Desarrollo\DEV\Reniec\wsq_imagen\jhon_ind_izq.wsq")
                wsqder = Legolas.Components.Archivo.FileConvertByte("D:\Desarrollo\DEV\Reniec\wsq_imagen\jhon_ind_der.wsq")

                '    Dim sqlcon As New SqlConnection("server=SRVDESDBALL\HADESDEV; database=inpe_bd_huella_visita; uid=usr_desk_huella_visita_dev; pwd=usr_desk_huella_visita_dev;")
                '    Dim dt As New DataTable
                '    dt = Legolas.Components.SQL.Select_DataTable(sqlcon, "select fk_tmp_id,wsq_file from mov_huella_wsq where fk_tmp_id in (2052,2053)")
                '    wsqizq = dt.Rows.Item(0).Item("wsq_file")
                '    wsqder = dt.Rows.Item(1).Item("wsq_file")

                objEnt = objWS.VerificarHuella(_NumeroDocumentoUsuario, _NumeroDocumento, wsqizq, wsqder, ipPC, Mac)

                If objEnt.HayError = True Then
                    strMensajeOut = objEnt.ErrorMensaje
                    value = False
                Else
                    If objEnt.Corresponde = "SI" Then
                        value = True
                    End If
                End If
            Else 'Huella nueva

                objEnt = objWS.VerificarHuella(_NumeroDocumentoUsuario, _NumeroDocumento, HuellaIzquierda, HuellaDerecha, ipPC, Mac)

                If objEnt.HayError = True Then
                    strMensajeOut = objEnt.ErrorMensaje
                    value = False
                Else
                    If objEnt.Corresponde = "SI" Then
                        value = True
                    End If
                End If
            End If

            Return value
        End Function

        Private Sub QuitarFocoHuellas(huelleroActivo As APPControlHuellaVisita.uscThumbFinger)
            'uscMeniqueIzquierdo._Foco = False
            'uscAnularIzquierdo._Foco = False
            'uscMedioIzquierdo._Foco = False
            'uscIndiceIzquierdo._Foco = False
            'uscPulgarIzquierdo._Foco = False
            'uscPulgarDerecho._Foco = False
            'uscIndiceDerecho._Foco = False
            'uscMedioDerecho._Foco = False
            'uscAnularDerecho._Foco = False
            'uscMeniqueDerecho._Foco = False
            'huelleroActivo._Foco = True

            'lblDedoSel.Text = huelleroActivo._NombreLargoDedo
            'pbVisorHuellaDetalle.Image = huelleroActivo._Imagen
            'lblEstadoDedo.Text = huelleroActivo._EstadoDedoString
            'lblCalidadHuella.Text = huelleroActivo._IndiceCalidadString
            'txtObservacion.Text = huelleroActivo._Observacion
            'If cmdNuevo.Text <> "Nueva captura" Then
            '    cmdNuevo.Text = "Recapturar " & huelleroActivo._NombreCortoDedo
            'End If

        End Sub

        Private Sub uscMeniqueI__SelectDedo_Click()
            '  QuitarFocoHuellas(uscMeniqueIzquierdo)
        End Sub

        Private Sub uscAnularI__SelectDedo_Click()
            ' QuitarFocoHuellas(uscAnularIzquierdo)
        End Sub

        Private Sub uscMedioI__SelectDedo_Click()
            'QuitarFocoHuellas(uscMedioIzquierdo)
        End Sub

        Private Sub uscIndiceI__SelectDedo_Click()
            'QuitarFocoHuellas(uscIndiceIzquierdo)
        End Sub

        Private Sub uscPulgarI__SelectDedo_Click()
            'QuitarFocoHuellas(uscPulgarIzquierdo)
        End Sub

        Private Sub uscPulgarDerecho__SelectDedo_Click()
            'QuitarFocoHuellas(uscPulgarDerecho)
        End Sub

        Private Sub uscIndiceDerecho__SelectDedo_Click()
            '  QuitarFocoHuellas(uscIndiceDerecho)
        End Sub

        Private Sub uscMedioDerecho__SelectDedo_Click()
            ' QuitarFocoHuellas(uscMedioDerecho)
        End Sub

        Private Sub uscAnularDerecho__SelectDedo_Click()
            'QuitarFocoHuellas(uscAnularDerecho)
        End Sub

        Private Sub uscMeniqueDerecho__SelectDedo_Click()
            'QuitarFocoHuellas(uscMeniqueDerecho)
        End Sub

        Private Sub GrabarHuellas(lstTemplateIds As Dictionary(Of Integer, Integer), idInternoHuella As Integer)
            Dim entIH As New Entity.Biometria.InternoHuella
            Dim bssIH As New Bussines.Biometria.InternoHuella
            Dim id As Integer = -1
            Dim outSms As String = ""
            If idInternoHuella > 0 Then
                entIH = bssIH.Listar(idInternoHuella, "")
                With entIH
                    .InternoId = Me._InternoId
                    .HuellaDigMenIzqId = If(lstTemplateIds.ContainsKey(1), lstTemplateIds.Item(1), .HuellaDigMenIzqId) 'los indices corresponen a cada tipo de dedo
                    .HuellaDigAnuIzqId = If(lstTemplateIds.ContainsKey(2), lstTemplateIds.Item(2), .HuellaDigAnuIzqId)
                    .HuellaDigMedIzqId = If(lstTemplateIds.ContainsKey(3), lstTemplateIds.Item(3), .HuellaDigMedIzqId)
                    .HuellaDigIndIzqId = If(lstTemplateIds.ContainsKey(4), lstTemplateIds.Item(4), .HuellaDigIndIzqId)
                    .HuellaDigPulIzqId = If(lstTemplateIds.ContainsKey(5), lstTemplateIds.Item(5), .HuellaDigPulIzqId)

                    .HuellaDigPulDerId = If(lstTemplateIds.ContainsKey(6), lstTemplateIds.Item(6), .HuellaDigPulDerId)
                    .HuellaDigIndDerId = If(lstTemplateIds.ContainsKey(7), lstTemplateIds.Item(7), .HuellaDigIndDerId)
                    .HuellaDigMedDerId = If(lstTemplateIds.ContainsKey(8), lstTemplateIds.Item(8), .HuellaDigMedDerId)
                    .HuellaDigAnuDerId = If(lstTemplateIds.ContainsKey(9), lstTemplateIds.Item(9), .HuellaDigAnuDerId)
                    .HuellaDigMenDerId = If(lstTemplateIds.ContainsKey(10), lstTemplateIds.Item(10), .HuellaDigMenDerId)

                    .RegionId = Me._RegId
                    .PenalId = Me._PenId
                End With
            Else
                With entIH
                    .Codigo = -1
                    .InternoId = Me._InternoId
                    .HuellaDigMenIzqId = If(lstTemplateIds.ContainsKey(1), lstTemplateIds.Item(1), -1) 'los indices corresponen a cada tipo de dedo
                    .HuellaDigAnuIzqId = If(lstTemplateIds.ContainsKey(2), lstTemplateIds.Item(2), -1)
                    .HuellaDigMedIzqId = If(lstTemplateIds.ContainsKey(3), lstTemplateIds.Item(3), -1)
                    .HuellaDigIndIzqId = If(lstTemplateIds.ContainsKey(4), lstTemplateIds.Item(4), -1)
                    .HuellaDigPulIzqId = If(lstTemplateIds.ContainsKey(5), lstTemplateIds.Item(5), -1)

                    .HuellaDigPulDerId = If(lstTemplateIds.ContainsKey(6), lstTemplateIds.Item(6), -1)
                    .HuellaDigIndDerId = If(lstTemplateIds.ContainsKey(7), lstTemplateIds.Item(7), -1)
                    .HuellaDigMedDerId = If(lstTemplateIds.ContainsKey(8), lstTemplateIds.Item(8), -1)
                    .HuellaDigAnuDerId = If(lstTemplateIds.ContainsKey(9), lstTemplateIds.Item(9), -1)
                    .HuellaDigMenDerId = If(lstTemplateIds.ContainsKey(10), lstTemplateIds.Item(10), -1)

                    .RegionId = Me._RegId
                    .PenalId = Me._PenId
                End With
            End If

            id = bssIH.Grabar(entIH, outSms)

            If id > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            Else
                If outSms.Trim.Length > 3 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Se produjo un error interno, " & outSms)
                Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("La operacion realizada no se pudo completar correctamente. Inténtelo nuevamente")
                End If

                Exit Sub
            End If

        End Sub
        Private Function FRM_CapturarHuella(enmTipoDedo As Type.Enumeracion.Biometria.TipoDedo) As APPControlHuellaVisita.uscThumbFinger

            Dim uscHuellaActiva As New APPControlHuellaVisita.uscThumbFinger
            uscHuellaActiva._TipoDedo = enmTipoDedo

            Dim frm As New APPControlHuellaVisita.frmCapturaMonoDac(uscHuellaActiva._TipoDedo)
            With frm
                ._UsarBDHuella = False

                If .ShowDialog() = DialogResult.OK Then
                    uscHuellaActiva = frm._uscDedoActual
                End If
            End With

            Return uscHuellaActiva

        End Function

        Private Sub pbVisorHuellaDetalle_DoubleClick(sender As Object, e As System.EventArgs)
            ' FormDetalleHuella(pbVisorManoIzquierda.Image)
        End Sub


        Private Sub FormDetalleHuella(ImgHuella As Image)
            Try
                Dim frmNuevo As Form
                frmNuevo = New Form()

                Dim pbHuella = New System.Windows.Forms.PictureBox()

                pbHuella.Dock = DockStyle.Fill
                pbHuella.Image = ImgHuella
                pbHuella.Location = New System.Drawing.Point(0, 0)
                pbHuella.SizeMode = PictureBoxSizeMode.Zoom
                pbHuella.TabIndex = 0
                pbHuella.TabStop = False
                frmNuevo.StartPosition = FormStartPosition.CenterParent
                frmNuevo.Controls.Add(pbHuella)
                frmNuevo.Size = New Size(400, 600)

                With frmNuevo
                    .Text = "Detalle Huella"
                    .ShowDialog()
                End With
            Catch ex As Exception

            End Try
        End Sub

        Public Sub Ver_HuellaDerecha(imagen As Image)
            Me.pbVisorDerecho.Image = imagen
        End Sub
        Public Sub Ver_HuellaIzquierda(imagen As Image)
            Me.pbVisorIzquierdo.Image = imagen
        End Sub

        Private Sub btnCapturaIzquierda_Click(sender As Object, e As EventArgs) Handles btnCapturaIzquierda.Click
            RaiseEvent _click_CapturarHuellaIzquierda()
        End Sub

        Private Sub btnCapturaDerecha_Click(sender As Object, e As EventArgs) Handles btnCapturaDerecha.Click
            RaiseEvent _click_CapturarHuellaDerecha()
        End Sub
    End Class
End Namespace