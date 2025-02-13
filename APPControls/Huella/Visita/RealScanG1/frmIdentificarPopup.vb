Namespace Visita.Huella
    Public Class frmIdentificarPopup
        Private objDTOHuellaIndice As Entity.Visita.Huella = Nothing
        Private blnCargaForm As Boolean = False
        Private blnCapturarAutomatica As Boolean = False
        Private intContaDer As Short = 0
        Private intContaIzq As Short = 0
#Region "Enum"
        Public Enum enmTipoBusqueda As Short
            Ninguno = 0
            Verificacion = 1
            Identificacion = 2
            IdentificacionPendxSalir = 3
        End Enum
        Public Enum enmTipoMano As Short
            Ninguno = 0
            Izquierda = 1
            Derecha = 2
        End Enum
#End Region
#Region "Propiedades_Publicas"
        Public Property _TipoBusqueda As enmTipoBusqueda = enmTipoBusqueda.Identificacion
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
        Public Property _IDTipoDocumento As Short = -1
        Public Property _NumeroDocumento As String = ""
        Public Property _IDVisitante As Integer = -1
        Public Property _IDTemplateColSinSalida As List(Of Integer)
        Public Property _HabilitarRecaptura As Boolean = True
#End Region
#Region "Propiedades_Retorno"
        Public Property _IDVisitanteReturn As Integer = -1
        Public Property _RecapturarReturn As Boolean = False
#End Region
#Region "Propiedades"
        Private Property ManoSeleccionada As enmTipoMano = enmTipoMano.Ninguno
        Private ReadOnly Property TipoDedo As Integer
            Get

                Dim value As Short = -1

                Select Case Me.ManoSeleccionada

                    Case enmTipoMano.Izquierda

                        If Me.chkHueIzq.Checked = True Then
                            value = Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                        Else
                            value = Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                        End If

                    Case enmTipoMano.Derecha

                        If Me.chkHueDer.Checked = True Then
                            value = Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                        Else
                            value = Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                        End If

                End Select


                Return value
            End Get

        End Property
#End Region
#Region "Otros"
        Private Sub mostrarHuellasDisponibles()

            Dim objBss As New Bussines.Biometria.VisitanteHuella
            Dim objEnt As New Entity.Biometria.VisitanteHuella

            Dim blnTieneManoIzq As Boolean = False
            Dim blnTieneManoDer As Boolean = False
            Dim blnMostrarCalidadIzq As Boolean = False
            Dim blnMostrarCalidadDer As Boolean = False

            Dim intCalidadIzq As Short = 0
            Dim intCalidadDer As Short = 0

            Dim blnHabilitarIndiceIzq As Boolean = False
            Dim blnHabilitarIndiceDer As Boolean = False

            Dim blnCambiarMano As Boolean = False
            'listar la huella del visitante
            objEnt = objBss.ListarHuellaxIDVisitante(Me._IDVisitante, Me._IDRegion, Me._IDPenal, "")

            With objEnt

                'mano izquierda
                Select Case .TipoCapturaIzquierdo

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        blnTieneManoIzq = True
                        blnMostrarCalidadIzq = True

                        'si tiene huella del dedo indice 
                        If .IDIndiceIzquierdo > 0 Then
                            blnHabilitarIndiceIzq = True
                            intCalidadIzq = .CalidadIndiceIzquierdo
                        End If

                        If .IDPulgarIzquierdo > 0 Then
                            blnHabilitarIndiceIzq = False
                            intCalidadIzq = .CalidadPulgarIzquierdo
                        End If

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado, _
                        Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                        With pbManoIzq
                            .Image = My.Resources.huella_x
                            .Enabled = False
                        End With
                        Me.pnlManoIzqDetalle.Visible = False

                        Me.lblObsManIzq.Text = .ManoIzquierda
                        Me.lblObsManIzq.Visible = True

                End Select

                'mano derecha
                Select Case .TipoCapturaDerecho

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        blnTieneManoDer = True
                        blnMostrarCalidadDer = True

                        ' si tiene huella del dedo indice 
                        If .IDIndiceDerecho > 0 Then
                            blnHabilitarIndiceDer = True
                            intCalidadDer = .CalidadIndiceDerecho
                        End If

                        If .IDPulgarDerecho > 0 Then
                            blnHabilitarIndiceDer = False
                            intCalidadDer = .CalidadPulgarDerecho
                        End If

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado, _
                        Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                        With pbManoDer
                            .Image = My.Resources.huella_x
                            .Enabled = False
                        End With
                        Me.pnlManoDerDetalle.Visible = False

                        Me.lblObsManDer.Text = .ManoDerecha
                        Me.lblObsManDer.Visible = True

                        blnCambiarMano = True
                End Select

            End With

            'Me.pnlManoIzq.Visible = blnMostrarManoIzq
            'Me.pnlManoDer.Visible = blnMostrarManoDer

            Me.pbCalidadManoIzq.Visible = blnMostrarCalidadIzq
            Me.pbCalidadManoDer.Visible = blnMostrarCalidadDer

            Me.chkHueIzq.Checked = blnHabilitarIndiceIzq
            Me.chkHueIzq.Enabled = False

            Me.chkHueDer.Checked = blnHabilitarIndiceDer
            Me.chkHueDer.Enabled = False

            'asignar el color de la calidad de la huella
            Select Case intCalidadIzq
                Case Type.Enumeracion.Biometria.CalidadHuella.MuyAlta
                    Me.pbCalidadManoIzq.Image = My.Resources.estado_verde
                Case Type.Enumeracion.Biometria.CalidadHuella.Alta
                    Me.pbCalidadManoIzq.Image = My.Resources.estado_azul
                Case Type.Enumeracion.Biometria.CalidadHuella.Media
                    Me.pbCalidadManoIzq.Image = My.Resources.estado_amarillo
            End Select

            'asignar el color de la calidad de la huella
            Select Case intCalidadDer
                Case Type.Enumeracion.Biometria.CalidadHuella.MuyAlta
                    Me.pbCalidadManoDer.Image = My.Resources.estado_verde
                Case Type.Enumeracion.Biometria.CalidadHuella.Alta
                    Me.pbCalidadManoDer.Image = My.Resources.estado_azul
                Case Type.Enumeracion.Biometria.CalidadHuella.Media
                    Me.pbCalidadManoDer.Image = My.Resources.estado_amarillo
            End Select

            chkHueIzq_Click(Nothing, Nothing)
            chkHueDer_Click(Nothing, Nothing)

            'si no hay huella en la mano derecha, hacer el cambio de mano
            If blnCambiarMano = True Then
                pbManoIzq_Click(Nothing, Nothing)
            End If

            'si ambos dedos estan observados o amputados, iniciar la recaptura automatica
            If blnTieneManoIzq = False And blnTieneManoDer = False Then
                Me._RecapturarReturn = True
                Me._IDVisitanteReturn = -1
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub


        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            Dim intIDVisitaCol As New List(Of Integer)
            Dim intIDVisita As Integer = -1

            If Not objDTOHuellaIndice Is Nothing Then

                If objDTOHuellaIndice.HayDatos = True Then

                    Dim objBssAfis As New APPControlHuellaVisita.AfisDemo(APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita)
                    Dim intIDTemplateCol As New List(Of Integer)
                    Dim strMensajeError As String = ""
                    Dim intEstado As Short = -1

                    Select Case Me._TipoBusqueda

                        Case enmTipoBusqueda.Verificacion

                            '/*verifica con plantilla suprema*/
                            'intEstado = objBssAfis.VerificarHuella(Me._IDTipoDocumento, Me._NumeroDocumento, APPControlHuellaVisita.Type.Enumeracion.TipoPlantilla.Suprema,
                            '                           objDTOHuellaIndice.TemplateSuprema, Me.TipoDedo,
                            '                           APPControlHuellaVisita.Type.Enumeracion.enumRSE_NivelSeguridad.RSE_SECURITY_1_TO_100000,
                            '                           intIDTemplateCol, strMensajeError)

                            '/*verificar con plantilla ansi*/
                            intEstado = objBssAfis.VerificarHuella(APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.RealScanG1,
                                                                    Me._IDTipoDocumento, Me._NumeroDocumento, Me.TipoDedo,
                                                                    APPControlHuellaVisita.Type.Enumeracion.TipoPlantilla.ANSI378,
                                                                    objDTOHuellaIndice.TemplateAnsi,
                                                                    intIDTemplateCol, strMensajeError)


                        Case enmTipoBusqueda.Identificacion

                            'intEstado = objBssAfis.Identificar(objDTOHuellaIndice.TemplateSuprema, Me.TipoDedo, True, _
                            '                       APPControlHuellaVisita.Type.Enumeracion.enumRSE_NivelSeguridad.RSE_SECURITY_1_TO_100000,
                            '                       intIDTemplateCol, strMensajeError)

                        Case enmTipoBusqueda.IdentificacionPendxSalir

                            '/*identificar con plantilla suprema*/
                            'intEstado = objBssAfis.Identificar(objDTOHuellaIndice.TemplateSuprema, Me.TipoDedo, True, _
                            '                      APPControlHuellaVisita.Type.Enumeracion.enumRSE_NivelSeguridad.RSE_SECURITY_1_TO_100000,
                            '                      intIDTemplateCol, _IDTemplateColSinSalida, strMensajeError)

                            '/*identificar con plantilla ansi*/
                            intEstado = objBssAfis.Identificar(APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.RealScanG1,
                                                            Me.TipoDedo, APPControlHuellaVisita.Type.Enumeracion.TipoPlantilla.ANSI378,
                                                            objDTOHuellaIndice.TemplateAnsi, True,
                                                            intIDTemplateCol, _IDTemplateColSinSalida, strMensajeError)


                    End Select

                    If intEstado = 0 Then 'ok

                        Dim objBss As New Bussines.Visita.Visitante
                        For Each j As Integer In intIDTemplateCol

                            intIDVisitaCol.Add(objBss.BuscarHuella(j, Me._IDRegion, Me._IDPenal))

                        Next

                    End If

                End If

            End If

            For Each j As Integer In intIDVisitaCol
                intIDVisita = j
            Next

            If intIDVisita > 0 Then
                Me.lblLeyenda.Text = "Huella encontrada, cargando datos espere..."
                Me._IDVisitanteReturn = intIDVisita
                Me.DialogResult = Windows.Forms.DialogResult.OK
            Else

                Dim strMensaje As String = ""
                Dim strTitulo As String = ""

                Select Case Me._TipoBusqueda

                    Case enmTipoBusqueda.Verificacion
                        strMensaje = "La Huella capturada del dedo seleccionado, no coincide con los datos del visitante. Vuelva ha intentarlo"
                        strTitulo = "Verificacion"

                    Case enmTipoBusqueda.IdentificacionPendxSalir
                        strMensaje = "La Huella capturada del dedo seleccionado, no coincide con ningun visitante registrado"
                        strTitulo = "Identificacion"

                    Case Else
                        strMensaje = "Los datos no coinciden"
                        strTitulo = Me.Text
                End Select

                Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensaje, strTitulo)

                If blnCapturarAutomatica = False Then
                    Select Case Me.ManoSeleccionada
                        Case enmTipoMano.Izquierda
                            intContaIzq = intContaIzq + 1
                        Case enmTipoMano.Derecha
                            intContaDer = intContaDer + 1
                    End Select
                End If

                If intContaIzq >= 3 Or intContaDer >= 3 Then
                    Me.btnRecapturar.Enabled = True
                End If

                blnCapturarAutomatica = False
                Me.btnCapturarHuella.Focus()

            End If

        End Sub

        Private Sub frmIdentificarPopup_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

            Me.lblLeyenda.Text = "Cargando datos espere..."
            Me.UscCaptura1._FinalizarDispositivo()

        End Sub

        Private Sub frmIdentificarPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Me.ManoSeleccionada = enmTipoMano.Derecha
            Me.pbManoDer.BorderStyle = BorderStyle.Fixed3D
            Me.pbManoDer.BackColor = Color.SteelBlue

            Me.pnlManoIzqDetalle.Visible = False

        End Sub

        Private Sub frmIdentificarPopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            Me.Cursor = Cursors.WaitCursor

            'si se realiza la verificacion de la huella, el sistema mostrara los dedos disponibles
            If _TipoBusqueda = enmTipoBusqueda.Verificacion Then
                mostrarHuellasDisponibles()

                If _HabilitarRecaptura = True Then
                    Me.btnRecapturar.Visible = True
                End If

            End If

            Me.Refresh()
            Threading.Thread.Sleep(500)

            Me.UscCaptura1._MostrarLeyenda = False
            Me.UscCaptura1._IniciarDispositivo()
            Me.UscCaptura1._IniciarCaptura(Me.TipoDedo, APPControlHuellaVisita.Type.Enumeracion.IndiceCalidadHuella.Media)

            Me.Cursor = Cursors.Default
            Me.lblLeyenda.Text = "Ingrese el dedo seleccionado, dentro del escaner del equipo Biometrico"
            Me.btnSalir.Enabled = True
            blnCargaForm = True

        End Sub

        Private Sub UscCaptura1__Accion_HuellaCapturada() Handles UscCaptura1._Accion_HuellaCapturada

            objDTOHuellaIndice = New Entity.Visita.Huella

            With Me.UscCaptura1
                objDTOHuellaIndice.TipoDedo = Me.TipoDedo
                objDTOHuellaIndice.HuellaByte = ._ImagenHuella
                objDTOHuellaIndice.CalidadHuella = ._CalidadIndiceHuellaCapturada
                objDTOHuellaIndice.TemplateAnsi = ._TemplateANSI
                objDTOHuellaIndice.TemplateSuprema = ._TemplateSUPREMA
                objDTOHuellaIndice.TemplateWsq = ._WSQ
                objDTOHuellaIndice.HayDatos = True

                Me.pbHuella.Image = Image.FromStream(New IO.MemoryStream(._ImagenHuella))

                Select Case Me.ManoSeleccionada
                    Case enmTipoMano.Izquierda
                        intContaIzq = intContaIzq + 1
                    Case enmTipoMano.Derecha
                        intContaDer = intContaDer + 1
                End Select
                blnCapturarAutomatica = True
                btnAceptar_Click(Nothing, Nothing)

            End With

        End Sub


        Private Sub btnCapturarHuella_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturarHuella.Click

            Me.pbHuella.Image = Nothing
            Me.UscCaptura1.Visible = True
            Me.UscCaptura1._IniciarCaptura(Me.TipoDedo, APPControlHuellaVisita.Type.Enumeracion.IndiceCalidadHuella.Media)

        End Sub

        Private Sub SeleccionarMano(objTipoMano As enmTipoMano)

            '/*limpiar*/
            Me.pbManoIzq.BorderStyle = BorderStyle.None
            Me.pbManoIzq.BackColor = Color.White
            Me.pbManoDer.BorderStyle = BorderStyle.None
            Me.pbManoDer.BackColor = Color.White

            'si es por verificacion, el enabled esta deshabilitado
            If Me.chkHueIzq.Enabled = True Then
                Me.chkHueIzq.Checked = False
            End If

            If Me.chkHueDer.Enabled = True Then
                Me.chkHueDer.Checked = False
            End If

            Me.pnlManoIzqDetalle.Visible = False
            Me.pnlManoDerDetalle.Visible = False

            Me.ManoSeleccionada = objTipoMano

            Select Case objTipoMano

                Case enmTipoMano.Izquierda
                    Me.pbManoIzq.BorderStyle = BorderStyle.Fixed3D
                    Me.pbManoIzq.BackColor = Color.SteelBlue

                    'si es por verificacion, el enabled esta deshabilitado
                    If Me.chkHueIzq.Enabled = True Then
                        Me.chkHueIzq.Checked = True
                    End If

                    Me.pnlManoIzqDetalle.Visible = True

                Case enmTipoMano.Derecha

                    Me.pbManoDer.BorderStyle = BorderStyle.Fixed3D
                    Me.pbManoDer.BackColor = Color.SteelBlue

                    'si es por verificacion, el enabled esta deshabilitado
                    If Me.chkHueDer.Enabled = True Then
                        Me.chkHueDer.Checked = True
                    End If

                    Me.pnlManoDerDetalle.Visible = True

            End Select

            If blnCargaForm = True Then

                Me.pbHuella.Image = Nothing
                Me.UscCaptura1.Visible = True
                Me.UscCaptura1._IniciarCaptura(Me.TipoDedo, APPControlHuellaVisita.Type.Enumeracion.IndiceCalidadHuella.Media)

            End If
        End Sub

        Private Sub pbManoIzq_Click(sender As System.Object, e As System.EventArgs) Handles pbManoIzq.Click

            SeleccionarMano(enmTipoMano.Izquierda)

        End Sub

        Private Sub pbManoDer_Click(sender As System.Object, e As System.EventArgs) Handles pbManoDer.Click

            SeleccionarMano(enmTipoMano.Derecha)

        End Sub


        Private Sub chkHueIzq_Click(sender As Object, e As System.EventArgs) Handles chkHueIzq.Click

            If Me.chkHueIzq.Checked = True Then

                If Me.pbManoIzq.Enabled = True Then
                    Me.pbManoIzq.Image = My.Resources.mano_izquierda
                End If

                Me.chkHueIzq.Text = "Indice Izquierdo"
            Else

                If Me.pbManoIzq.Enabled = True Then
                    Me.pbManoIzq.Image = My.Resources.mano_izquierda02
                End If

                Me.chkHueIzq.Text = "Pulgar Izquierdo"
            End If

        End Sub

        Private Sub chkHueDer_Click(sender As Object, e As System.EventArgs) Handles chkHueDer.Click

            If Me.chkHueDer.Checked = True Then

                If Me.pbManoDer.Enabled = True Then
                    Me.pbManoDer.Image = My.Resources.mano_derecha
                End If

                Me.chkHueDer.Text = "Indice Derecho"
            Else

                If Me.pbManoDer.Enabled = True Then
                    Me.pbManoDer.Image = My.Resources.mano_derecha02
                End If

                Me.chkHueDer.Text = "Pulgar Derecho"
            End If

        End Sub

        Private Sub UscCaptura1_Load(sender As System.Object, e As System.EventArgs) Handles UscCaptura1.Load

        End Sub


        Private Sub btnRecapturar_Click(sender As System.Object, e As System.EventArgs) Handles btnRecapturar.Click

            Me._RecapturarReturn = True
            Me._IDVisitanteReturn = -1

            Me.DialogResult = Windows.Forms.DialogResult.OK

        End Sub

        Private Sub chkHueIzq_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHueIzq.CheckedChanged

        End Sub

        Private Sub chkHueDer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkHueDer.CheckedChanged

        End Sub
    End Class
End Namespace