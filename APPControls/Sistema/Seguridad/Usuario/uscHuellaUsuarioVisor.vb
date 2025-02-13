Imports APPControlHuellaVisita.Huellero.UI.FS10

Namespace Sistema.Seguridad.Usuario
    Public Class uscHuellaUsuarioVisor
        Public _UsuarioId As Integer = -1
        Public _Codigo As Integer = -1

        Private blHuellIzqModif As Boolean = False
        Private blHuellDerModif As Boolean = False

        Public Function Grabar() As Boolean
            Dim bssusuHuella As New Bussines.Sistema.Seguridad.UsuarioHuella
            Dim entUsuHuella As New Entity.Sistema.Seguridad.UsuarioHuella
            Dim v As Integer = -1

            If blHuellIzqModif = False And blHuellDerModif = False Then Return False

            If _UsuarioId = -1 Then 'usuario nuevo
                MessageBox.Show("Primeramente debe grabar los datos del usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            If uscHuelIIzq._TemplateANSI Is Nothing Or uscHuellDer._TemplateANSI Is Nothing Then
                MessageBox.Show("Es necesario la captura mínima de dos huellas", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            entUsuHuella.Codigo = Me._Codigo
            entUsuHuella.UsuarioId = _UsuarioId

            entUsuHuella.Izq_TipoDedoId = uscHuelIIzq._TipoDedo
            entUsuHuella.Izq_TemplateAnsi = uscHuelIIzq._TemplateANSI
            entUsuHuella.Izq_Wsq = uscHuelIIzq._Wsq
            entUsuHuella.Izq_Wsq_alto = uscHuelIIzq._Imagen.Height
            entUsuHuella.Izq_Wsq_ancho = uscHuelIIzq._Imagen.Width
            entUsuHuella.Izq_CalidadHuella = uscHuelIIzq._IndiceCalidad
            entUsuHuella.Izq_DispBiometricoId = uscHuelIIzq._TipoDispostivo

            entUsuHuella.Der_TipoDedoId = uscHuellDer._TipoDedo
            entUsuHuella.Der_TemplateAnsi = uscHuellDer._TemplateANSI
            entUsuHuella.Der_Wsq = uscHuellDer._Wsq
            entUsuHuella.Der_Wsq_alto = uscHuellDer._Imagen.Height
            entUsuHuella.Der_Wsq_ancho = uscHuellDer._Imagen.Width
            entUsuHuella.Der_CalidadHuella = uscHuellDer._IndiceCalidad
            entUsuHuella.Der_DispBiometricoId = uscHuellDer._TipoDispostivo

            If Me._Codigo = -1 Then
                v = bssusuHuella.Grabar(entUsuHuella)
                If v > 0 Then
                    blHuellIzqModif = False
                    blHuellDerModif = False
                    Me._Codigo = v
                End If
            Else
                If blHuellIzqModif And blHuellDerModif Then
                    v = bssusuHuella.Grabar(entUsuHuella)
                    If v > 0 Then
                        blHuellIzqModif = False
                        blHuellDerModif = False
                    End If
                End If
                If blHuellIzqModif And blHuellDerModif = False Then
                    v = bssusuHuella.ActualizarHuellaIzq(entUsuHuella)
                    If v > 0 Then blHuellIzqModif = False
                End If
                If blHuellDerModif And blHuellIzqModif = False Then
                    v = bssusuHuella.ActualizarHuellaDer(entUsuHuella)
                    If v > 0 Then blHuellDerModif = False
                End If

            End If

            If v = -1 Then
                MessageBox.Show("No se pudo grabar el registro", "Información", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Else
                MessageBox.Show("Operación satisfactoria", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True
            End If

        End Function

        Private Sub btnCapturarHuellaIzq_Click(sender As Object, e As EventArgs) Handles btnCapturarHuellaIzq.Click
            Dim frm As New frmSelectTipoDedo(False)
            Dim indHuella As Integer = 0

            If frm.ShowDialog = DialogResult.OK Then indHuella = frm.indiceDedoSel

            If indHuella = 0 Then Exit Sub

            'Dim f As New APPControlHuellaVisita.Huellero.UI.FS10.frmCapturaHuellaUnico(4)
            Dim f As New APPControlHuellaVisita.Huellero.UI.FS10.frmCapturaHuellaUnico(indHuella)
            If f.ShowDialog = DialogResult.OK Then
                uscHuelIIzq._TipoDedo = f._uscDedoActual._TipoDedo
                uscHuelIIzq._Observacion = f._uscDedoActual._Observacion
                uscHuelIIzq._IndiceCalidad = f._uscDedoActual._IndiceCalidad
                uscHuelIIzq._EstadoDedo = f._uscDedoActual._EstadoDedo
                uscHuelIIzq._Codigo = f._uscDedoActual._Codigo
                uscHuelIIzq._TipoDispostivo = f._uscDedoActual._TipoDispostivo
                uscHuelIIzq._ImagenHuellaByte = f._uscDedoActual._ImagenHuellaByte
                uscHuelIIzq._Wsq = f._uscDedoActual._Wsq
                uscHuelIIzq._TemplateANSI = f._uscDedoActual._TemplateANSI

                blHuellIzqModif = True

                usc_izq_med.BackColor = Color.Gray
                usc_izq_ind.BackColor = Color.Gray
                usc_izq_pul.BackColor = Color.Gray

                If indHuella = 3 Then usc_izq_med.BackColor = Color.FromArgb(0, 192, 0)
                If indHuella = 4 Then usc_izq_ind.BackColor = Color.FromArgb(0, 192, 0)
                If indHuella = 5 Then usc_izq_pul.BackColor = Color.FromArgb(0, 192, 0)

            End If

        End Sub

        Private Sub btnCapturarHuellaDer_Click(sender As Object, e As EventArgs) Handles btnCapturarHuellaDer.Click
            Dim frm As New frmSelectTipoDedo(True)
            Dim indHuella As Integer = 0

            If frm.ShowDialog = DialogResult.OK Then indHuella = frm.indiceDedoSel

            If indHuella = 0 Then Exit Sub

            'Dim f As New APPControlHuellaVisita.Huellero.UI.FS10.frmCapturaHuellaUnico(4)
            Dim f As New APPControlHuellaVisita.Huellero.UI.FS10.frmCapturaHuellaUnico(indHuella)
            If f.ShowDialog = DialogResult.OK Then
                uscHuellDer._TipoDedo = f._uscDedoActual._TipoDedo
                uscHuellDer._Observacion = f._uscDedoActual._Observacion
                uscHuellDer._IndiceCalidad = f._uscDedoActual._IndiceCalidad
                uscHuellDer._EstadoDedo = f._uscDedoActual._EstadoDedo
                uscHuellDer._Codigo = f._uscDedoActual._Codigo
                uscHuellDer._TipoDispostivo = f._uscDedoActual._TipoDispostivo
                uscHuellDer._ImagenHuellaByte = f._uscDedoActual._ImagenHuellaByte
                uscHuellDer._Wsq = f._uscDedoActual._Wsq
                uscHuellDer._TemplateANSI = f._uscDedoActual._TemplateANSI
                blHuellIzqModif = True

                usc_der_pul.BackColor = Color.Gray
                usc_der_ind.BackColor = Color.Gray
                usc_der_med.BackColor = Color.Gray

                If indHuella = 6 Then usc_der_pul.BackColor = Color.FromArgb(0, 192, 0)
                If indHuella = 7 Then usc_der_ind.BackColor = Color.FromArgb(0, 192, 0)
                If indHuella = 8 Then usc_der_med.BackColor = Color.FromArgb(0, 192, 0)

            End If

            'Dim f As New APPControlHuellaVisita.Huellero.UI.FS10.frmCapturaHuellaUnico(7)
            'If f.ShowDialog = DialogResult.OK Then
            '    uscHuellDer._TipoDedo = f._uscDedoActual._TipoDedo
            '    uscHuellDer._Observacion = f._uscDedoActual._Observacion
            '    uscHuellDer._IndiceCalidad = f._uscDedoActual._IndiceCalidad
            '    uscHuellDer._EstadoDedo = f._uscDedoActual._EstadoDedo
            '    uscHuellDer._Codigo = f._uscDedoActual._Codigo
            '    uscHuellDer._TipoDispostivo = f._uscDedoActual._TipoDispostivo
            '    uscHuellDer._ImagenHuellaByte = f._uscDedoActual._ImagenHuellaByte
            '    uscHuellDer._Wsq = f._uscDedoActual._Wsq
            '    uscHuellDer._TemplateANSI = f._uscDedoActual._TemplateANSI
            '    blHuellDerModif = True

            '    usc_der_ind.BackColor = Color.FromArgb(0, 192, 0)
            'End If
        End Sub

        Private Sub uscHuelIIzq__DobleClick(sender As APPControlHuellaVisita.uscThumbFinger) Handles uscHuelIIzq._DobleClick
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

        Private Sub uscHuellDer__DobleClick(sender As APPControlHuellaVisita.uscThumbFinger) Handles uscHuellDer._DobleClick
            FormDetalleHuella(sender._Imagen)
        End Sub

        Public Sub LoadUsc()
            Dim bssusuHuella As New Bussines.Sistema.Seguridad.UsuarioHuella
            Dim entUsuHuella As New Entity.Sistema.Seguridad.UsuarioHuella
            Dim bssSysBio As New APPControlHuellaVisita.Business.SysBiometria(APPControls.Configuracion.ConexionBD.CN_BD_HuellaInterno)

            entUsuHuella = bssusuHuella.ListarPorUsuario(Me._UsuarioId)

            usc_izq_ind.Visible = True
            usc_der_ind.Visible = True
            If Not entUsuHuella Is Nothing Then
                Me._Codigo = entUsuHuella.Codigo

                uscHuelIIzq._TipoDedo = entUsuHuella.Izq_TipoDedoId
                uscHuelIIzq._TemplateANSI = entUsuHuella.Izq_TemplateAnsi
                uscHuelIIzq._Wsq = entUsuHuella.Izq_Wsq
                uscHuelIIzq._IndiceCalidad = entUsuHuella.Izq_CalidadHuella
                uscHuelIIzq._TipoDispostivo = entUsuHuella.Izq_DispBiometricoId
                uscHuelIIzq._ImagenHuellaByte = bssSysBio.ObtenerImagenByteDesdeWSQ(entUsuHuella.Izq_Wsq, "")

                uscHuellDer._TipoDedo = entUsuHuella.Der_TipoDedoId
                uscHuellDer._TemplateANSI = entUsuHuella.Der_TemplateAnsi
                uscHuellDer._Wsq = entUsuHuella.Der_Wsq
                uscHuellDer._IndiceCalidad = entUsuHuella.Der_CalidadHuella
                uscHuellDer._TipoDispostivo = entUsuHuella.Der_DispBiometricoId
                uscHuellDer._ImagenHuellaByte = bssSysBio.ObtenerImagenByteDesdeWSQ(entUsuHuella.Der_Wsq, "")

                Select Case entUsuHuella.Izq_TipoDedoId
                    Case 1
                        usc_izq_men.BackColor = Color.FromArgb(0, 192, 0)
                    Case 2
                        ucs_izq_anu.BackColor = Color.FromArgb(0, 192, 0)
                    Case 3
                        usc_izq_med.BackColor = Color.FromArgb(0, 192, 0)
                    Case 4
                        usc_izq_ind.BackColor = Color.FromArgb(0, 192, 0)
                    Case 5
                        usc_izq_pul.BackColor = Color.FromArgb(0, 192, 0)
                End Select

                Select Case entUsuHuella.Der_TipoDedoId
                    Case 6
                        usc_der_pul.BackColor = Color.FromArgb(0, 192, 0)
                    Case 7
                        usc_der_ind.BackColor = Color.FromArgb(0, 192, 0)
                    Case 8
                        usc_der_med.BackColor = Color.FromArgb(0, 192, 0)
                    Case 9
                        usc_der_anu.BackColor = Color.FromArgb(0, 192, 0)
                    Case 10
                        usc_der_men.BackColor = Color.FromArgb(0, 192, 0)
                End Select

            End If

        End Sub

    End Class
End Namespace