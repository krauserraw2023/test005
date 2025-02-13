Namespace Visita.Huella
    Public Class frmCapturapopup        
        Private frmHuella As New APPControlHuellaVisita.frmCaptura
        Private objDTOHuellaIzq As Entity.Visita.Huella = Nothing
        Private objDTOHuellaDer As Entity.Visita.Huella = Nothing

        Private intContadorManoIzq As Short = 0
        Private intContadorManoDer As Short = 0

        Private intIDHuellaIndiceIzq As Integer = -1
        Private intIDHuellaIndiceDer As Integer = -1
        Private intIDHuellaPulgarIzq As Integer = -1
        Private intIDHuellaPulgarDer As Integer = -1

        Private intCalidadManoIzquierda As Short = 0
        Private intCalidadManoDerecha As Short = 0

#Region "Propiedades_Publicas"
        Public Property _IDRegion As Short = -1
        Public Property _IDPenal As Short = -1
        Public Property _IDVisitante As Integer = -1
        Public Property _IDTipoDocumento As Short = -1
        Public Property _NumeroDocumento As String = ""
        Public Property _MostrarHuellas As Boolean = False
#End Region
#Region "Propiedades_Return"
        Public Property _VisitanteTieneHuella As Type.Enumeracion.Visita.Visitante.TieneHuella = Type.Enumeracion.Visita.Visitante.TieneHuella.Ninguno
#End Region
#Region "Propiedades"
        Private ReadOnly Property IDUsuario As Integer
            Get
                Return Legolas.Configuration.Usuario.Codigo
            End Get
        End Property
        Private Property TipoDedoIzquierdo As Type.Enumeracion.Biometria.TipoDedo
            Get
                Dim value As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

                If Me.rdbIndiceIzq.Checked = True Then
                    value = Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                End If

                If Me.rdbPulgarIzq.Checked = True Then
                    value = Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                End If

                Return value

            End Get
            Set(value As Type.Enumeracion.Biometria.TipoDedo)

                Me.rdbIndiceIzq.Checked = False
                Me.rdbPulgarIzq.Checked = False

                Select Case value
                    Case Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                        Me.rdbIndiceIzq.Checked = True
                    Case Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                        Me.rdbPulgarIzq.Checked = False
                End Select
            End Set

        End Property
        Private Property TipoDedoDerecho As Type.Enumeracion.Biometria.TipoDedo
            Get
                Dim value As Type.Enumeracion.Biometria.TipoDedo = Type.Enumeracion.Biometria.TipoDedo.Ninguno

                If Me.rdbIndiceDer.Checked = True Then
                    value = Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                End If

                If Me.rdbPulgarDer.Checked = True Then
                    value = Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                End If

                Return value

            End Get
            Set(value As Type.Enumeracion.Biometria.TipoDedo)

                Me.rdbIndiceDer.Checked = False
                Me.rdbPulgarDer.Checked = False

                Select Case value
                    Case Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                        Me.rdbIndiceDer.Checked = True
                    Case Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                        Me.rdbPulgarDer.Checked = True
                End Select

            End Set
        End Property
        Private Property TipoCapturaManoIzquierda As Short
            Get

                Dim value As Short = -1

                If Me.rdbIzqAmputado.Checked = True Then
                    value = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                End If

                If Me.rdbIzqNormal.Checked = True Then
                    value = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                End If

                If Me.rdbIzqObs.Checked = True Then
                    value = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                End If

                Return value
            End Get
            Set(value As Short)

                Me.rdbIzqAmputado.Checked = False
                Me.rdbIzqNormal.Checked = False
                Me.rdbIzqObs.Checked = False

                Select Case value
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        Me.rdbIzqAmputado.Checked = True

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                        Me.rdbIzqNormal.Checked = True

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        Me.rdbIzqObs.Checked = True
                End Select

            End Set

        End Property
        Private Property TipoCapturaManoDerecha As Short
            Get

                Dim value As Short = -1

                If Me.rdbDerAmputado.Checked = True Then
                    value = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                End If

                If Me.rdbDerNormal.Checked = True Then
                    value = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                End If

                If Me.rdbDerObs.Checked = True Then
                    value = Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                End If

                Return value

            End Get
            Set(value As Short)

                Me.rdbDerAmputado.Checked = False
                Me.rdbDerNormal.Checked = False
                Me.rdbDerObs.Checked = False

                Select Case value
                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        Me.rdbDerAmputado.Checked = True

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                        Me.rdbDerNormal.Checked = True

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        Me.rdbDerObs.Checked = True
                End Select

            End Set
        End Property

        Private Property ObservacionIzquierda As String
            Get
                Return Me.txtObsIzq.Text.Trim
            End Get
            Set(value As String)
                Me.txtObsIzq.Text = value
            End Set
        End Property

        Private Property ObservacionDerecha As String
            Get
                Return Me.txtObsDer.Text.Trim
            End Get
            Set(value As String)
                Me.txtObsDer.Text = value
            End Set
        End Property
        Private Property TipoDispositivo As Type.Enumeracion.Biometria.enumTipoDispositivo
#End Region
#Region "Listar"

        Private Sub listarHuellaVisitante()

            Me.Text = "Proceso de Recaptura de Huella Digital"
            Me.btnCapturarHueIzq.Image = My.Resources.recapturar
            Me.btnCapturarHueDer.Image = My.Resources.recapturar

            Dim objEnt As New Entity.Biometria.VisitanteHuella
            Dim objBss As New Bussines.Biometria.VisitanteHuella

            'listar la huella del visitante
            objEnt = objBss.ListarHuellaxIDVisitante(Me._IDVisitante, Me._IDRegion, Me._IDPenal, "")

            If objEnt Is Nothing Then
                Exit Sub
            End If

            With objEnt

                'Me.lblTituloManoIzq.Text = .ManoIzquierda
                'Me.lblTituloManoDer.Text = .ManoDerecha

                intIDHuellaIndiceIzq = .IDIndiceIzquierdo
                intIDHuellaPulgarIzq = .IDPulgarIzquierdo

                intIDHuellaIndiceDer = .IDIndiceDerecho
                intIDHuellaPulgarDer = .IDPulgarDerecho

                ''tipo dedo izquierdo

                Me.TipoCapturaManoIzquierda = .TipoCapturaIzquierdo

                Me.TipoDedoIzquierdo = .TipoDedoIzquierdo
                intCalidadManoIzquierda = .ManoIzquierdaCalidad

                'tipo dedo izquierdo
                Select Case .TipoCapturaIzquierdo

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        'Me.pnlObsIzq.Visible = False
                        'Me.pbHuellaIzquierda.Image = My.Resources.huella_x

                        rdbIzqNormal_Click(Nothing, Nothing)

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                        Me.pnlObsIzq.Visible = False
                        Me.pbHuellaIzquierda.Image = My.Resources.huella_digital
                        Me.pbEstadoHuellaIzq.Visible = True

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                        rdbIzqNormal_Click(Nothing, Nothing)
                        Me.ObservacionIzquierda = .ObservacionIzquierdo
                        'Me.pbHuellaIzquierda.Image = My.Resources.huella_digital
                        'Me.txtObsIzq.Text = .ObservacionIzquierdo

                        'Me.pnlObsIzq.Visible = True
                End Select

                'tipo dedo derecho

                Me.TipoCapturaManoDerecha = .TipoCapturaDerecho
                Me.TipoDedoDerecho = .TipoDedoDerecho
                intCalidadManoDerecha = .ManoDerechaCalidad


                Select Case .TipoCapturaDerecho

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado
                        'Me.pnlObsDer.Visible = False
                        'Me.pbHuellaDerecha.Image = My.Resources.huella_x
                        rdbDerNormal_Click(Nothing, Nothing)

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal
                        Me.pnlObsDer.Visible = False
                        Me.pbHuellaDerecha.Image = My.Resources.huella_digital
                        Me.pbEstadoHuellaDer.Visible = True

                    Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado
                        'Me.pbHuellaDerecha.Image = My.Resources.huella_digital
                        'Me.txtObsDer.Text = .ObservacionDerecho
                        'Me.pnlObsDer.Visible = True
                        rdbDerNormal_Click(Nothing, Nothing)
                        Me.ObservacionDerecha = .ObservacionDerecho
                End Select


                'Calidad dedo izquierdo
                Select Case .ManoIzquierdaCalidad

                    Case Type.Enumeracion.Biometria.CalidadHuella.MuyAlta
                        Me.pbEstadoHuellaIzq.Image = My.Resources.estado_verde

                    Case Type.Enumeracion.Biometria.CalidadHuella.Alta
                        Me.pbEstadoHuellaIzq.Image = My.Resources.estado_azul

                    Case Type.Enumeracion.Biometria.CalidadHuella.Media
                        Me.pbEstadoHuellaIzq.Image = My.Resources.estado_amarillo
                End Select

                'Calidad dedo derecho
                Select Case .ManoDerechaCalidad

                    Case Type.Enumeracion.Biometria.CalidadHuella.MuyAlta
                        Me.pbEstadoHuellaDer.Image = My.Resources.estado_verde

                    Case Type.Enumeracion.Biometria.CalidadHuella.Alta
                        Me.pbEstadoHuellaDer.Image = My.Resources.estado_azul

                    Case Type.Enumeracion.Biometria.CalidadHuella.Media
                        Me.pbEstadoHuellaDer.Image = My.Resources.estado_amarillo
                End Select
            End With

            Me.rdbPulgarIzq.Enabled = True
            Me.rdbPulgarDer.Enabled = True

            Me.rdbIzqObs.Enabled = True
            Me.rdbDerObs.Enabled = True

        End Sub

#End Region
#Region "FRM"
        Private Function FRM_CapturarHuella(intTipoDedo As Short, intTipoCaptura As Short, strObs As String) As Entity.Visita.Huella

            Dim value As New Entity.Visita.Huella

            'preguntar por el tipo de dispositivo
            Dim objAfis As New APPControlHuellaVisita.IdentificarDispositivo
            Me.TipoDispositivo = objAfis.IdentificarDispositivo

            Select Case Me.TipoDispositivo

                Case APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.RealScanG1

                    With frmHuella
                        ._IniciarDispositivo(intTipoDedo, APPControlHuellaVisita.Type.Enumeracion.IndiceCalidadHuella.Media)

                        Me.Cursor = Cursors.Default

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                            value.TipoDedo = intTipoDedo
                            value.HuellaByte = ._ImagenHuella
                            value.CalidadHuella = ._CalidadIndiceHuellaCapturada
                            value.TemplateAnsi = ._TemplateANSI
                            value.TemplateSuprema = ._TemplateSUPREMA
                            value.TemplateWsq = ._WSQ
                            value.TipoCaptura = intTipoCaptura
                            value.EstadoDedo = 0 'dispobible
                            value.Observacion = strObs
                            value.HayDatos = True
                        End If

                    End With

                Case APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS10, APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS88H

                    Dim frmHuella1 As New APPControlHuellaVisita.Huellero.FS10.frmCaptura

                    With frmHuella1
                        ._IniciarDispositivo(intTipoDedo, APPControlHuellaVisita.Type.Enumeracion.IndiceCalidadHuella.Media)

                        Me.Cursor = Cursors.Default

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then

                            value.TipoDedo = intTipoDedo
                            value.HuellaByte = ._ImagenHuella
                            value.CalidadHuella = ._CalidadIndiceHuellaCapturada
                            value.TemplateAnsi = ._TemplateANSI
                            value.TemplateSuprema = ._TemplateSUPREMA
                            value.TemplateWsq = ._WSQ
                            value.TipoCaptura = intTipoCaptura
                            value.EstadoDedo = 0 'dispobible
                            value.Observacion = strObs
                            value.HayDatos = True
                        End If

                    End With

                Case Else

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Dispositivo no compatible")

            End Select

            Return value

        End Function
#End Region
#Region "Otros"
        Private Function Validar() As Boolean

            Dim value As Boolean = False

            'validar id del visitante
            If Me._IDVisitante < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Visitante")
                Exit Function
            End If

            'mano izquierda
            Select Case Me.TipoCapturaManoIzquierda
                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado

                    If Me.TipoCapturaManoDerecha = 0 Then 'amputado
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ambas huellas de los dedos no puedes ser de tipo amputado")
                        Return False
                    End If

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                    If intIDHuellaIndiceIzq < 1 And intIDHuellaPulgarIzq < 1 Then

                        If objDTOHuellaIzq Is Nothing OrElse Me.pbEstadoHuellaIzq.Visible = False OrElse objDTOHuellaIzq.HayDatos = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe capturar la huella de la mano izquierda")
                            Return False
                        End If

                    End If

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                    If Me.ObservacionIzquierda.Trim.Length < 5 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar la observacion por el cual no se puede registrar la huella izquierda de la visita")
                        Me.txtObsIzq.Focus()
                        Return False
                    End If

                Case Else
                    'si el tipo de captura es menos uno (-1)

                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe volver ha capturar la huella de la mano izquierda")
                    Return False

            End Select

            'mano derecha
            Select Case Me.TipoCapturaManoDerecha
                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado

                    If Me.TipoCapturaManoIzquierda = 0 Then 'amputado
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Ambas huellas de los dedos no puedes ser de tipo amputado")
                        Return False
                    End If

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                    If intIDHuellaIndiceDer < 1 And intIDHuellaPulgarDer < 1 Then

                        If objDTOHuellaDer Is Nothing OrElse objDTOHuellaDer.HayDatos = False OrElse Me.pbEstadoHuellaDer.Visible = False Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe capturar la huella de la mano derecha")
                            Return False
                        End If

                    End If

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                    If Me.ObservacionDerecha.Trim.Length < 5 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe ingresar la observacion por el cual no se puede registrar la huella derecha de la visita")
                        Me.txtObsDer.Focus()
                        Return False
                    End If
                Case Else

                    'si el tipo de captura es menos uno (-1)
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe volver ha capturar la huella de la mano derecha")
                    Return False

            End Select

            value = True
            Return value
        End Function

        Private Function CapturarHuella(objTipoDedo As Type.Enumeracion.Biometria.TipoDedo, intTipoCaptura As Short, strObs As String) As Entity.Visita.Huella

            Dim value As New Entity.Visita.Huella

            value = FRM_CapturarHuella(objTipoDedo, intTipoCaptura, strObs)

            Return value

        End Function

        Private Sub ValoresxDefault()

            Me.pnlObsDer.Visible = False
            Me.pnlObsIzq.Visible = False

            Me.pbEstadoHuellaIzq.Visible = False
            Me.pbEstadoHuellaDer.Visible = False

            Me.rdbIzqObs.Enabled = False
            Me.rdbDerObs.Enabled = False

        End Sub

        Private Sub SeleccionarManoIzquierda()

            Me.pnlObsIzq.Visible = False

            Select Case Me.TipoCapturaManoIzquierda
                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado

                    Me.pbHuellaIzquierda.Image = My.Resources.huella_x
                    Me.btnCapturarHueIzq.Enabled = False
                    Me.pnlDedosIzq.Visible = False

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                    Me.rdbIndiceIzq.Checked = True
                    Me.pnlDedosIzq.Visible = True

                    Me.btnCapturarHueIzq.Enabled = True

                    SeleccionarTipoDedoIzquierdo()

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                    Me.pnlDedosIzq.Visible = False
                    Me.pnlObsIzq.Visible = True
                    Me.btnCapturarHueIzq.Enabled = False
                    Me.txtObsIzq.Text = ""
                    Me.txtObsIzq.Focus()

            End Select

        End Sub

        Private Sub ManoDerecha()

            Me.pnlObsDer.Visible = False

            Select Case Me.TipoCapturaManoDerecha
                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Amputado

                    Me.pbHuellaDerecha.Image = My.Resources.huella_x
                    Me.btnCapturarHueDer.Enabled = False
                    Me.pnlDedosDer.Visible = False

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Normal

                    Me.rdbIndiceDer.Checked = True
                    Me.pnlDedosDer.Visible = True
                    Me.btnCapturarHueDer.Enabled = True

                    SeleccionarTipoDedoDerecho()

                Case Type.Enumeracion.Visita.Visitante.TipoCapturaHuella.Observado

                    Me.pnlDedosDer.Visible = False
                    Me.pnlObsDer.Visible = True
                    Me.btnCapturarHueDer.Enabled = False
                    Me.txtObsDer.Text = ""
                    Me.txtObsDer.Focus()
            End Select

        End Sub

        Private Sub limpiarHuellaIzquierda()

            Me.objDTOHuellaIzq = Nothing
            Me.pbEstadoHuellaIzq.Visible = False
            intIDHuellaIndiceIzq = -1
            intIDHuellaPulgarIzq = -1
            intCalidadManoIzquierda = 0
            'Me.pbHuellaIzquierda.Image = Nothing

        End Sub

        Private Sub limpiarHuellaDerecha()

            Me.objDTOHuellaDer = Nothing            
            Me.pbEstadoHuellaDer.Visible = False
            intIDHuellaIndiceDer = -1
            intIDHuellaPulgarDer = -1
            intCalidadManoDerecha = 0
            'Me.pbHuellaDerecha.Image = Nothing

        End Sub

        Private Sub SeleccionarTipoDedoIzquierdo()

            Select Case Me.TipoDedoIzquierdo
                Case Type.Enumeracion.Biometria.TipoDedo.IndiceIzquierdo
                    Me.pbHuellaIzquierda.Image = My.Resources.mano_izquierda

                Case Type.Enumeracion.Biometria.TipoDedo.PulgarIzquierdo
                    Me.pbHuellaIzquierda.Image = My.Resources.mano_izquierda02
            End Select

            limpiarHuellaIzquierda()

        End Sub
        Private Sub SeleccionarTipoDedoDerecho()

            Select Case Me.TipoDedoDerecho
                Case Type.Enumeracion.Biometria.TipoDedo.IndiceDerecho
                    Me.pbHuellaDerecha.Image = My.Resources.mano_derecha

                Case Type.Enumeracion.Biometria.TipoDedo.PulgarDerecho
                    Me.pbHuellaDerecha.Image = My.Resources.mano_derecha02
            End Select

            limpiarHuellaDerecha()

        End Sub
#End Region

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub btnCapturarHueIzq_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturarHueIzq.Click

            'limpiarHuellaIzquierda()
            SeleccionarTipoDedoIzquierdo()

            intContadorManoIzq += 1

            objDTOHuellaIzq = New Entity.Visita.Huella
            objDTOHuellaIzq = CapturarHuella(Me.TipoDedoIzquierdo, Me.TipoCapturaManoIzquierda, Me.ObservacionIzquierda)

            With objDTOHuellaIzq
                If .HayDatos = True And Not .HuellaByte Is Nothing Then
                    Me.pbHuellaIzquierda.Image = Image.FromStream(New IO.MemoryStream(.HuellaByte))
                    Me.pbEstadoHuellaIzq.Visible = True

                    Select Case .CalidadHuella
                        Case 1
                            Me.pbEstadoHuellaIzq.Image = Me.pbEstadoVerde.Image
                        Case 2
                            Me.pbEstadoHuellaIzq.Image = Me.pbEstadoAzul.Image
                        Case 3
                            Me.pbEstadoHuellaIzq.Image = Me.pbEstadoAma.Image
                    End Select

                End If
            End With

            If intContadorManoIzq >= 3 Then
                Me.rdbPulgarIzq.Enabled = True
                Me.rdbIzqObs.Enabled = True
            End If

        End Sub

        Private Sub btnCapturarHueDer_Click(sender As System.Object, e As System.EventArgs) Handles btnCapturarHueDer.Click

            'limpiarHuellaDerecha()
            SeleccionarTipoDedoDerecho()

            intContadorManoDer += 1

            objDTOHuellaDer = New Entity.Visita.Huella
            objDTOHuellaDer = CapturarHuella(Me.TipoDedoDerecho, Me.TipoCapturaManoDerecha, Me.ObservacionDerecha)

            With objDTOHuellaDer
                If .HayDatos = True And Not .HuellaByte Is Nothing Then

                    Me.pbHuellaDerecha.Image = Image.FromStream(New IO.MemoryStream(.HuellaByte))
                    Me.pbEstadoHuellaDer.Visible = True

                    Select Case .CalidadHuella
                        Case 1
                            Me.pbEstadoHuellaDer.Image = Me.pbEstadoVerde.Image
                        Case 2
                            Me.pbEstadoHuellaDer.Image = Me.pbEstadoAzul.Image
                        Case 3
                            Me.pbEstadoHuellaDer.Image = Me.pbEstadoAma.Image
                    End Select

                End If
            End With

            If intContadorManoDer >= 3 Then
                Me.rdbPulgarDer.Enabled = True
                Me.rdbDerObs.Enabled = True
            End If

        End Sub

        Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click

            If Validar() = False Then
                Exit Sub
            End If

            Dim objBssBDHuella As New APPControlHuellaVisita.AfisDemo(APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita)

            'grabar el dedo izquierdo
            If Not objDTOHuellaIzq Is Nothing Then
                If objDTOHuellaIzq.HayDatos = True Then

                    objDTOHuellaIzq.IDTemplate = objBssBDHuella.GrabarHuella(Me.TipoDispositivo, Me._IDTipoDocumento, Me._NumeroDocumento, objDTOHuellaIzq.TipoDedo,
                                    objDTOHuellaIzq.TemplateSuprema, objDTOHuellaIzq.TemplateAnsi, objDTOHuellaIzq.TemplateWsq, objDTOHuellaIzq.CalidadHuella,
                                    objDTOHuellaIzq.EstadoDedo, "", Me._IDRegion, Me._IDPenal, Me.IDUsuario, "")
                End If
            Else

                'se crea la instancia de la huella vacia
                objDTOHuellaIzq = New Entity.Visita.Huella

                If intIDHuellaIndiceIzq < 1 And intIDHuellaPulgarIzq < 1 Then

                    With objDTOHuellaIzq
                        .TipoCaptura = Me.TipoCapturaManoIzquierda
                        .Observacion = Me.ObservacionIzquierda
                    End With

                Else

                    Dim intIDHuella As Integer = -1

                    If intIDHuellaIndiceIzq > 0 Then
                        intIDHuella = intIDHuellaIndiceIzq
                    Else
                        intIDHuella = intIDHuellaPulgarIzq
                    End If

                    With objDTOHuellaIzq
                        .TipoCaptura = Me.TipoCapturaManoIzquierda
                        .Observacion = Me.ObservacionIzquierda
                        .TipoDedo = Me.TipoDedoIzquierdo
                        .CalidadHuella = intCalidadManoIzquierda
                        .IDHuella = intIDHuella
                    End With

                End If

            End If

            'grabar el dedo derecho
            If Not objDTOHuellaDer Is Nothing Then
                If objDTOHuellaDer.HayDatos = True Then

                    objDTOHuellaDer.IDTemplate = objBssBDHuella.GrabarHuella(Me.TipoDispositivo, Me._IDTipoDocumento, Me._NumeroDocumento, objDTOHuellaDer.TipoDedo,
                                        objDTOHuellaDer.TemplateSuprema, objDTOHuellaDer.TemplateAnsi, objDTOHuellaDer.TemplateWsq, objDTOHuellaDer.CalidadHuella,
                                        objDTOHuellaDer.EstadoDedo, "", Me._IDRegion, Me._IDPenal, Me.IDUsuario, "")
                End If
            Else

                'se crea la instancia de la huella vacia
                objDTOHuellaDer = New Entity.Visita.Huella

                If intIDHuellaIndiceDer < 1 And intIDHuellaPulgarDer < 1 Then

                    With objDTOHuellaDer
                        .TipoCaptura = Me.TipoCapturaManoDerecha
                        .Observacion = Me.ObservacionDerecha
                    End With

                Else

                    Dim intIDHuella As Integer = -1

                    If intIDHuellaIndiceDer > 0 Then
                        intIDHuella = intIDHuellaIndiceDer
                    Else
                        intIDHuella = intIDHuellaPulgarDer
                    End If

                    With objDTOHuellaDer
                        .TipoCaptura = Me.TipoCapturaManoDerecha
                        .Observacion = Me.ObservacionDerecha
                        .TipoDedo = Me.TipoDedoDerecho
                        .CalidadHuella = intCalidadManoDerecha
                        .IDHuella = intIDHuella
                    End With

                End If

            End If

            'grabar en la bd del pope             
            Dim objBss As New Bussines.Visita.Visitante
            Dim intIDVisitante As Integer = -1
            intIDVisitante = objBss.GrabarHuella(Me._IDVisitante, objDTOHuellaIzq, objDTOHuellaDer, Me._IDRegion, Me._IDPenal, Me._VisitanteTieneHuella)

            If intIDVisitante > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub

        Private Sub frmCapturapopup_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

            frmHuella._FinalizarCaptura()

        End Sub

        Private Sub frmCapturapopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub


        Private Sub rdbIzqNormal_Click(sender As Object, e As System.EventArgs) Handles _
            rdbIzqNormal.Click,
            rdbIzqAmputado.Click,
            rdbIzqObs.Click

            SeleccionarManoIzquierda()
            limpiarHuellaIzquierda()

        End Sub

        Private Sub rdbDerNormal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbDerNormal.CheckedChanged

        End Sub

        Private Sub rdbDerNormal_Click(sender As Object, e As System.EventArgs) Handles _
            rdbDerNormal.Click,
            rdbDerAmputado.Click,
            rdbDerObs.Click

            ManoDerecha()
            limpiarHuellaDerecha()

        End Sub

        Private Sub frmCapturapopup_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            If Me._MostrarHuellas = True Then
                listarHuellaVisitante()
            End If

        End Sub

        Private Sub rdbIzqNormal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbIzqNormal.CheckedChanged

        End Sub

        Private Sub rdbIndiceIzq_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbIndiceIzq.CheckedChanged

        End Sub

        Private Sub rdbIndiceIzq_Click(sender As Object, e As System.EventArgs) _
            Handles rdbIndiceIzq.Click,
            rdbPulgarIzq.Click

            SeleccionarTipoDedoIzquierdo()

        End Sub

        Private Sub rdbIndiceDer_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbIndiceDer.CheckedChanged

        End Sub

        Private Sub rdbIndiceDer_Click(sender As Object, e As System.EventArgs) _
        Handles rdbIndiceDer.Click, _
            rdbPulgarDer.Click

            SeleccionarTipoDedoDerecho()

        End Sub

        Private Sub rdbIzqAmputado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbIzqAmputado.CheckedChanged

        End Sub
    End Class
End Namespace