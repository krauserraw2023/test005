Namespace Registro.Huellas
    Public Class uscVisorDetalleHuellas

        Private strRutTmp As String = Application.StartupPath & "\tmp\tmp_bmt\"

#Region "Propiedades publicas"
        Private InternoHuellaId As Integer = -1
        Public Property _InternoId() As Integer
        Public Property _RegId As Integer
        Public Property _PenId As Integer
        Public Property _TipoLicencia As Type.Enumeracion.Licencia.enmTipoLicencia = Type.Enumeracion.Licencia.enmTipoLicencia.Ninguno
        Public Property _TipDocIdentId As Integer = -1
        Public Property _NumDocIdent As String = ""
        Public Property _CodRP As String = ""
        Public Property _ApePat As String = ""
        Public Property _ApeMat As String = ""
        Public Property _Nombres As String = ""


        Dim controlSoloVista As Boolean = False
        Public Property _ControlSoloVista As Boolean
            Get
                Return controlSoloVista
            End Get
            Set(value As Boolean)
                controlSoloVista = value
                cmdNuevo.Visible = Not value
                'uscMeniqueIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscAnularIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscMedioIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscIndiceIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscPulgarIzquierdo._VisiblechkHuellaNoDisponible = value
                'uscPulgarDerecho._VisiblechkHuellaNoDisponible = value
                'uscIndiceDerecho._VisiblechkHuellaNoDisponible = value
                'uscMedioDerecho._VisiblechkHuellaNoDisponible = value
                'uscAnularDerecho._VisiblechkHuellaNoDisponible = valuedsa ds asd
                'uscMeniqueDerecho._VisiblechkHuellaNoDisponible = value
            End Set
        End Property

#End Region
#Region "Eventos"
        'Public Event _Clik_NuevaCaptura()
#End Region
#Region "otros"
        Private Sub CargarImagenHuella(huellaTemplateId As Integer, visorHulla As APPControlHuellaVisita.uscThumbFinger)
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
            visorHulla._TipoDispostivo = entTmpl.DispBiometricoId

            entWsq = bssSysBio.ListarWSQ_X_TemplateCod(entTmpl.Codigo, "")
            If Not entWsq Is Nothing Then
                'visorHulla._MostrarHuellaFalsa()
                visorHulla._ImagenHuellaByte = bssSysBio.ObtenerImagenByteDesdeWSQ(entWsq.WSQFile, "")
                ''visorHulla._ImagenHuellaByte = APPHuella.NegocioDEMO.ObtenerImagenHuella(strRutTmp, entWsq.WSQFile)
                'Else
                'visorHulla._ImagenHuellaByte = Nothing
            End If

        End Sub

        Private Sub ListarHuellas()
            If Me._InternoId = -1 Then Exit Sub
            If System.IO.Directory.Exists(strRutTmp) = False Then System.IO.Directory.CreateDirectory(strRutTmp)

            ''---------------listar internoHuella por InternoId
            Dim bssIntHuell As New Bussines.Biometria.InternoHuella

            Dim entIntHuellCol As New Entity.Biometria.InternoHuellaCol
            Dim entIntHuell As New Entity.Biometria.InternoHuella

            entIntHuell.InternoId = Me._InternoId

            entIntHuellCol = bssIntHuell.Listar(entIntHuell, "")
            If entIntHuellCol.Count > 0 Then 'significa que ya cuenta con huellas por lo tanto no es posible realizar captura decadactilar
                cmdNuevo.Text = "Recapturar"
            Else
                Exit Sub
            End If

            entIntHuell = entIntHuellCol.InternoHuella(0)

            Me.InternoHuellaId = entIntHuell.Codigo

            CargarImagenHuella(entIntHuell.HuellaDigMenIzqId, uscMeniqueIzquierdo)
            CargarImagenHuella(entIntHuell.HuellaDigAnuIzqId, uscAnularIzquierdo)
            CargarImagenHuella(entIntHuell.HuellaDigMedIzqId, uscMedioIzquierdo)
            CargarImagenHuella(entIntHuell.HuellaDigIndIzqId, uscIndiceIzquierdo)
            CargarImagenHuella(entIntHuell.HuellaDigPulIzqId, uscPulgarIzquierdo)
            CargarImagenHuella(entIntHuell.HuellaDigPulDerId, uscPulgarDerecho)
            CargarImagenHuella(entIntHuell.HuellaDigIndDerId, uscIndiceDerecho)
            CargarImagenHuella(entIntHuell.HuellaDigMedDerId, uscMedioDerecho)
            CargarImagenHuella(entIntHuell.HuellaDigAnuDerId, uscAnularDerecho)
            CargarImagenHuella(entIntHuell.HuellaDigMenDerId, uscMeniqueDerecho)
        End Sub

        Public Sub loadUsc()
            'validar
            Dim sms As String = ""
            If Me._InternoId = -1 Then
                sms = "Id de interno no válido."
            End If

            If Me._RegId = -1 Then
                sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Id del región no especificado"
            End If

            If Me._PenId = -1 Then
                sms = sms & If(sms.Trim.Length > 0, vbCrLf, "") & "Id del penal no especificado"

                If Me._RegId = 3 Then 'region lima
                    sms = ""
                End If

            End If

            If sms.Trim.Length > 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation(sms)
                Exit Sub
            End If

            ListarHuellas()

            Select Case Me._TipoLicencia

                Case Type.Enumeracion.Licencia.enmTipoLicencia.Carceleta,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                    Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana
                    If Legolas.Configuration.Usuario.OficinaID = 11 Then 'Odontologo
                        Me.cmdNuevo.Visible = False
                    Else
                        Me.cmdNuevo.Visible = True
                    End If

                Case Type.Enumeracion.Licencia.enmTipoLicencia.RegionLimaMetropolitana
                    Me.cmdNuevo.Visible = False
            End Select
            
        End Sub
#End Region
        Private Sub QuitarFocoHuellas(huelleroActivo As APPControlHuellaVisita.uscThumbFinger)
            uscMeniqueIzquierdo._Foco = False
            uscAnularIzquierdo._Foco = False
            uscMedioIzquierdo._Foco = False
            uscIndiceIzquierdo._Foco = False
            uscPulgarIzquierdo._Foco = False
            uscPulgarDerecho._Foco = False
            uscIndiceDerecho._Foco = False
            uscMedioDerecho._Foco = False
            uscAnularDerecho._Foco = False
            uscMeniqueDerecho._Foco = False
            huelleroActivo._Foco = True

            lblDedoSel.Text = huelleroActivo._NombreLargoDedo
            pbVisorHuellaDetalle.Image = huelleroActivo._Imagen
            lblEstadoDedo.Text = huelleroActivo._EstadoDedoString
            lblCalidadHuella.Text = huelleroActivo._IndiceCalidadString
            txtObservacion.Text = huelleroActivo._Observacion
            If cmdNuevo.Text <> "Nueva captura" Then
                cmdNuevo.Text = "Recapturar " & huelleroActivo._NombreCortoDedo
            End If

        End Sub

        Private Sub uscMeniqueI__SelectDedo_Click() Handles uscMeniqueIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscMeniqueIzquierdo)
        End Sub

        Private Sub uscAnularI__SelectDedo_Click() Handles uscAnularIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscAnularIzquierdo)
        End Sub

        Private Sub uscMedioI__SelectDedo_Click() Handles uscMedioIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscMedioIzquierdo)
        End Sub

        Private Sub uscIndiceI__SelectDedo_Click() Handles uscIndiceIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscIndiceIzquierdo)
        End Sub

        Private Sub uscPulgarI__SelectDedo_Click() Handles uscPulgarIzquierdo._SelectDedo_Click
            QuitarFocoHuellas(uscPulgarIzquierdo)
        End Sub

        Private Sub uscPulgarDerecho__SelectDedo_Click() Handles uscPulgarDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscPulgarDerecho)
        End Sub

        Private Sub uscIndiceDerecho__SelectDedo_Click() Handles uscIndiceDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscIndiceDerecho)
        End Sub

        Private Sub uscMedioDerecho__SelectDedo_Click() Handles uscMedioDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscMedioDerecho)
        End Sub

        Private Sub uscAnularDerecho__SelectDedo_Click() Handles uscAnularDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscAnularDerecho)
        End Sub

        Private Sub uscMeniqueDerecho__SelectDedo_Click() Handles uscMeniqueDerecho._SelectDedo_Click
            QuitarFocoHuellas(uscMeniqueDerecho)
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

        Private Sub cmdNuevo_Click(sender As System.Object, e As System.EventArgs) Handles cmdNuevo.Click

            Dim conBD As String = APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno

            If cmdNuevo.Text = "Nueva captura" Then

                Dim bssSysBio As New APPControlHuellaVisita.Business.SysBiometria(conBD)
                Dim tip As APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo
                tip = bssSysBio.getCompatibilidadDispositivoId

                If tip = APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS10 Then
                    GoTo linea
                ElseIf tip = APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.Desconocido Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Dispositivo biométrico no identificado en el equipo, verifique que se encuentre conectado.")
                    Exit Sub
                End If

                Dim f As New APPControlHuellaVisita.frmCapturaDeca
                f._PenId = Me._PenId
                f._RegId = Me._RegId
                f._UsuarioId = Legolas.Configuration.Usuario.Codigo
                f._CnBdHuella = conBD
                f._TipDocIdentId = Me._TipDocIdentId
                f._NumDocIdent = Me._NumDocIdent
                f._CodRP = Me._CodRP
                f._ApePat = Me._ApePat
                f._ApeMat = Me._ApeMat
                f._Nombres = Me._Nombres
                If f.ShowDialog() = DialogResult.OK Then
                    GrabarHuellas(f._outListaTemplateId, -1)

                    ListarHuellas()
                End If
            Else
linea:
                Dim uscHuellaActiva As APPControlHuellaVisita.uscThumbFinger
                If uscMeniqueIzquierdo._Foco = True Then uscHuellaActiva = uscMeniqueIzquierdo
                If uscAnularIzquierdo._Foco = True Then uscHuellaActiva = uscAnularIzquierdo
                If uscMedioIzquierdo._Foco = True Then uscHuellaActiva = uscMedioIzquierdo
                If uscIndiceIzquierdo._Foco = True Then uscHuellaActiva = uscIndiceIzquierdo
                If uscPulgarIzquierdo._Foco = True Then uscHuellaActiva = uscPulgarIzquierdo
                If uscPulgarDerecho._Foco = True Then uscHuellaActiva = uscPulgarDerecho
                If uscIndiceDerecho._Foco = True Then uscHuellaActiva = uscIndiceDerecho
                If uscMedioDerecho._Foco = True Then uscHuellaActiva = uscMedioDerecho
                If uscAnularDerecho._Foco = True Then uscHuellaActiva = uscAnularDerecho
                If uscMeniqueDerecho._Foco = True Then uscHuellaActiva = uscMeniqueDerecho

                If uscHuellaActiva Is Nothing Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione una huella para capturar.")
                    Exit Sub
                End If

                Dim f As New APPControlHuellaVisita.frmCapturaMonoDac(uscHuellaActiva._TipoDedo)
                f._PenId = Me._PenId
                f._RegId = Me._RegId
                f._UsuarioId = Legolas.Configuration.Usuario.Codigo
                f._CnBdHuella = conBD
                f._Observacion = uscHuellaActiva._Observacion
                f._TemplateId = uscHuellaActiva._Codigo
                f._TipDocIdentId = Me._TipDocIdentId
                f._NumDocIdent = Me._NumDocIdent
                f._CodRP = Me._CodRP
                f._ApePat = Me._ApePat
                f._ApeMat = Me._ApeMat
                f._Nombres = Me._Nombres
                If f.ShowDialog() = DialogResult.OK Then
                    Dim lstTemplateIds As New Dictionary(Of Integer, Integer)
                    lstTemplateIds.Add(uscHuellaActiva._TipoDedo, f._TemplateId)
                    GrabarHuellas(lstTemplateIds, Me.InternoHuellaId)

                    ListarHuellas()
                End If
            End If
        End Sub

        Private Sub pbVisorHuellaDetalle_DoubleClick(sender As Object, e As System.EventArgs) Handles pbVisorHuellaDetalle.DoubleClick
            FormDetalleHuella(pbVisorHuellaDetalle.Image)
        End Sub

        Private Sub uscMeniqueDerecho__DobleClick(sender As APPControlHuellaVisita.uscThumbFinger) Handles uscMeniqueDerecho._DobleClick, _
                                                    uscAnularDerecho._DobleClick, uscMedioDerecho._DobleClick, uscIndiceDerecho._DobleClick, _
                                                    uscPulgarDerecho._DobleClick, uscMeniqueIzquierdo._DobleClick, uscAnularIzquierdo._DobleClick, _
                                                    uscMedioIzquierdo._DobleClick, uscIndiceIzquierdo._DobleClick, uscPulgarIzquierdo._DobleClick
            FormDetalleHuella(sender._Imagen)
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
    End Class

End Namespace