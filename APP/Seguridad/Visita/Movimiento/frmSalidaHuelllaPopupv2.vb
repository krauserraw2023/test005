Namespace Visita.Movimiento
    Public Class frmSalidaHuelllaPopupv2
        Private objBss As Bussines.Visita.Visitante = Nothing
        'movimiento
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objEntColMov As Entity.Visita.MovimientoCol = Nothing
#Region "Enum"
        Public Enum enmTipoSalida
            Ninguno = 0
            Salida = 1
            SalidaNumeroDocumento = 2
        End Enum
#End Region
#Region "Propiedades_Parametricas"
        Private objTipoSalida As enmTipoSalida = enmTipoSalida.Ninguno
        Private intRegionID As Integer = -1
        Private intPenalID As Integer = -1
        Private intMovimientoID As Integer = -1
        Private intVisitanteID As Integer = -1
        Private intMenoresCantidad As Integer = 0
        Public Property _TipoSalida() As enmTipoSalida
            Get
                Return objTipoSalida
            End Get
            Set(ByVal value As enmTipoSalida)
                objTipoSalida = value
            End Set
        End Property
        Public Property _RegionID() As Integer
            Get
                Return intRegionID
            End Get
            Set(ByVal value As Integer)
                intRegionID = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return intPenalID
            End Get
            Set(ByVal value As Integer)
                intPenalID = value
            End Set
        End Property
        Public Property _MovimientoID() As Integer
            Get
                Return intMovimientoID
            End Get
            Set(ByVal value As Integer)
                intMovimientoID = value
            End Set
        End Property
        Public Property _HoraIngreso() As String
            Get
                Return Me.lblHora.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblHora.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Movimiento"
        Private Property IDMovimientoPadre As Integer = 0
        Private Property IDTipoVisita As Short = -1
#End Region
#Region "Propiedades_Grilla"
        Private ReadOnly Property GrillaFotoVisitante() As String
            Get
                Dim strValue As String = ""
                Try
                    With Me.dgwMenores
                        strValue = .SelectedRows(0).Cells("col_vis_fot_nom").Value
                    End With
                Catch ex As Exception

                End Try
                Return strValue
            End Get
        End Property
#End Region
#Region "Propiedades"
        Private strFoto As String = ""
        Private Property IDVisitante As Integer = -1        
        Private Property IDTipoDocumento As Short = -1
        Private Property TipoDocumentoNombre() As String
            Get
                Return Me.lblTipDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblTipDoc.Text = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.lblNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblNumDoc.Text = value
            End Set
        End Property
        Private Property ApellidoPaterno() As String
            Get
                Return Me.lblApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblApePat.Text = value
            End Set
        End Property
        Private Property ApellidoMaterno() As String
            Get
                Return Me.lblApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblApeMat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.lblNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblNom.Text = value
            End Set
        End Property
        Private Property Nacionalidad() As String
            Get
                Return Me.lblNac.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblNac.Text = value
            End Set
        End Property
        Private Property Sexo() As String
            Get
                Return Me.lblSexo.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblSexo.Text = value
            End Set
        End Property
        Private Property Foto() As String=""            
        Private Property NumeroPase As String
            Get
                Return Me.lblNumPase.Text
            End Get
            Set(value As String)
                Me.lblNumPase.Text = value
            End Set
        End Property
        Private Property VisitaTieneHuella As Short = Type.Enumeracion.Visita.Visitante.TieneHuella.Ninguno
        Private Property ValidacionHuella As Short = -1
#End Region
#Region "Propiedades_Buscar"
        Private Property BuscarIDTipoDocumento As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property BuscarNumeroDocumento() As String
            Get
                Return Me.txtBuscarNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtBuscarNumDoc.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Otros"
        Private Property HoraSalida() As String
            Get
                Return Me.lblHoraSal.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblHoraSal.Text = value
            End Set
        End Property
        Public Property CantidadMenores() As Integer = 0
        Private Property ObsSalida As String = ""
        Private Property TipoSalidaPor As Short = 2 '1=dni,2=huella,3=masivo (grupo entrante)
        Private ReadOnly Property IDUsuarioAutorizaSalida As Integer
            Get
                Return Legolas.Configuration.Usuario.Codigo
            End Get
        End Property        
        Private Property IDUsuarioAutorizaSalidaHuella As Integer = -1
#End Region
#Region "Combo"
        Private blnComboTipoDoc As Boolean = False
        Private Sub ComboTipoDoc()

            Dim objBss As New Bussines.General.TipoDocumento

            With Me.cbbTipoDoc
                .ValueMember = "Codigo"
                .DisplayMember = "Nombre"
                Dim Col As New Entity.General.ParametricaCol
                Dim objCol As New Entity.General.ParametricaCol
                Col = objBss.ComboTipoDoc()
                For Each obj As Entity.General.Parametrica In Col
                    Select Case obj.Codigo
                        Case 3, 4, 10, 16, 17
                            objCol.Add(obj)
                    End Select
                Next
                .DataSource = objCol ' objBss.ComboTipoDoc
            End With
            Me.BuscarIDTipoDocumento = 10 'dni
            blnComboTipoDoc = True
        End Sub
#End Region
#Region "Validar"
        Private Function ValidarNumeroDocumento() As Boolean

            Dim value As Boolean = True

            If Me.BuscarNumeroDocumento = "" Or Me.BuscarNumeroDocumento.Length < 4 Then
                Legolas.Configuration.Aplication.MessageBox.Information("Ingrese un numero de documento mayor a tres (03) digitos")
                Me.BuscarNumeroDocumento = ""
                Me.txtBuscarNumDoc.Focus()
                value = False
            End If

            Return value

        End Function
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me._MovimientoID < 1 Then
                Exit Sub
            End If

            Me.IDVisitante = Bussines.Visita.Movimiento.Return_VisitanteID(Me._MovimientoID)

            If Me._IDVisitante < 1 Then
                Exit Sub
            End If

            'leer el id del interno
            Dim intIDCodigoInterno As Integer = -1
            Dim blnEsInternoPJ As Boolean = False

            intIDCodigoInterno = Bussines.Visita.Movimiento.Return_InternoID(Me._MovimientoID)

            If intIDCodigoInterno < 1 Then
                intIDCodigoInterno = Bussines.Visita.Movimiento.Return_IDInternoPJ(Me._MovimientoID)

                If intIDCodigoInterno > 0 Then
                    blnEsInternoPJ = True
                End If
            End If

            'datos del visitante 
            Dim objEnt As Entity.Visita.Visitante = Nothing

            objBss = New Bussines.Visita.Visitante
            objEnt = objBss.Listar(Me._IDVisitante)

            With objEnt
                Me._IDVisitante = .Codigo
                Me.IDTipoDocumento = .TipoDocumentoID
                Me.TipoDocumentoNombre = .TipoDocumentoNombre
                Me.NumeroDocumento = .NumeroDocumento
                Me.ApellidoPaterno = .ApellidoPaterno
                Me.ApellidoMaterno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.Nacionalidad = .NacionalidadNombre
                Me.Sexo = .SexoNombre
                Me.Foto = .FotoName
                '/*datos de la huella*/
                Me.VisitaTieneHuella = .VisitanteTieneHuella
            End With
            ImagenFotoVisitante(Me.Foto)

            'foto del interno
            If blnEsInternoPJ = False Then
                ListarInternoFotoVersion(intIDCodigoInterno)
            Else
                Me.UscFotografia_2v1._cargarImagen(My.Resources.logo_pj02)
            End If

            'datos del movimiento
            objBssMov = New Bussines.Visita.Movimiento
            Dim objEntMov As New Entity.Visita.Movimiento
            objEntMov = objBssMov.Listar(Me._MovimientoID)

            With objEntMov
                Me.CantidadMenores = .MenoresCantidad
                Me.NumeroPase = .PaseNumero
            End With

            ListarMovimientoMenores()
            Me.pnlAddObs.Visible = True

            Select Case _TipoSalida
                Case enmTipoSalida.SalidaNumeroDocumento

                    Select Case intIDCodigoInterno
                        Case Is > 0
                            Me.Width = 932
                            Legolas.Configuration.Aplication.CentrarForm(Me)
                        Case Else
                            Me.Width = 630
                            Legolas.Configuration.Aplication.CentrarForm(Me)
                    End Select
            End Select

            Me.pbEstado.Visible = True
            Me.pbEstado.Image = My.Resources.delete_32
            Me.ValidacionHuella = -1

            FRM_CapturarVerificarHuella()

        End Sub
        Private Sub ListarMovimientoMenores()

            Me.gbrMenores.Visible = False

            objBssMov = New Bussines.Visita.Movimiento
            objEntColMov = New Entity.Visita.MovimientoCol

            objEntColMov = objBssMov.ListarMovimientoHijos(Me._MovimientoID)

            With Me.dgwMenores
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AutoGenerateColumns = False
                .DataSource = objEntColMov
            End With

            If Me.dgwMenores.RowCount > 0 And Me.CantidadMenores > 0 Then
                Me.gbrMenores.Visible = True
            End If


        End Sub
        Private Sub BuscarVisitante()

            If ValidarNumeroDocumento() = False Then Exit Sub

            Dim blnOK As Boolean = False
            Dim objEntCol As New Entity.Visita.VisitanteCol
            objBss = New Bussines.Visita.Visitante

            objEntCol = objBss.ListarxNumeroDocumento(Me.BuscarIDTipoDocumento, Me.BuscarNumeroDocumento, Me._RegionID, Me._PenalID)

            If objEntCol.Count > 0 Then

                For Each objEnt As Entity.Visita.Visitante In objEntCol
                    'queda
                    If objEnt.PenalID = Me._PenalID Then
                        Me._IDVisitante = objEnt.Codigo
                        blnOK = True
                        Exit For
                    End If
                Next
            End If

            If blnOK = True Then
                blnOK = False

                Dim lngFechaIngreso As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong

                objBssMov = New Bussines.Visita.Movimiento
                objEntColMov = New Entity.Visita.MovimientoCol

                objEntColMov = objBssMov.ListarMovimientoFaltaSalida_v2(-1, Me._IDVisitante, lngFechaIngreso, _
                                 Me._RegionID, Me._PenalID)

                If objEntColMov.Count > 0 Then

                    For Each objEnt As Entity.Visita.Movimiento In objEntColMov
                        'queda
                        If objEnt.PenalID = Me._PenalID Then
                            Me._MovimientoID = objEnt.Codigo
                            Me.IDMovimientoPadre = objEnt.MovimientoPadre
                            Me.IDTipoVisita = objEnt.TipoID
                            Me._HoraIngreso = objEnt.HoraIngreso
                            Exit For
                        End If
                    Next

                    'pregunto si la visita, es menor de edad
                    Select Case Me.IDTipoVisita
                        Case Type.Enumeracion.Visita.TipoVisita.MenorEdad
                            'si es menor de edad vuelvo a listar el movimiento

                            objBssMov = New Bussines.Visita.Movimiento
                            objEntColMov = New Entity.Visita.MovimientoCol

                            objEntColMov = objBssMov.ListarMovimientoFaltaSalida_v2(Me.IDMovimientoPadre, -1, 0, -1, -1)

                            If objEntColMov.Count > 0 Then

                                For Each objEnt As Entity.Visita.Movimiento In objEntColMov
                                    'queda
                                    If objEnt.PenalID = Me._PenalID Then
                                        Me._MovimientoID = objEnt.Codigo
                                        Me.IDMovimientoPadre = objEnt.MovimientoPadre
                                        Me.IDTipoVisita = objEnt.TipoID
                                        Me._HoraIngreso = objEnt.HoraIngreso
                                        blnOK = True
                                        Exit For
                                    End If
                                Next
                            End If

                        Case Else
                            'es adulto
                            blnOK = True
                    End Select

                End If
            End If

            If blnOK = True Then
                ListarData()
                Me.pnlHora.Visible = True
                Me.pnlAddObs.Visible = True
                Me.btnOk.Focus()
            Else
                Limpiar(True)
                Me.txtBuscarNumDoc.Text = ""
                Me.txtBuscarNumDoc.Focus()
            End If

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim value As Boolean = True

            If Me._MovimientoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se encontro ningun registro de visita")
                Me.txtBuscarNumDoc.Text = ""
                Me.txtBuscarNumDoc.Focus()
                value = False
                Return value
            End If

            Select Case Me.ValidacionHuella
                Case 1, 2 'dni y huella

                Case Else
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "No se ha detectado la Verificacion Biometrica (Huella Digital), no se puede continuar con la salida del Visitante. Vuelva ha intentar")
                    'Me.txtBuscarNumDoc.Text = ""
                    'Me.txtBuscarNumDoc.Focus()
                    value = False
                    Return value
            End Select

            Return value
        End Function
        Private Sub AOk()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim objbss As New Bussines.Visita.Movimiento
            Dim lngFechaSal As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

            intValue = objbss.GrabarSalida_v3(Me._MovimientoID, lngFechaSal, Me.HoraSalida,
                                              Me.IDUsuarioAutorizaSalida, Me.ObsSalida, Me.TipoSalidaPor, Me.IDUsuarioAutorizaSalidaHuella)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()

                Select Case Me._TipoSalida
                    Case enmTipoSalida.Salida

                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()

                    Case enmTipoSalida.SalidaNumeroDocumento
                        Limpiar(True)
                End Select

            End If

        End Sub
#End Region
#Region "Form"
        Private Sub Form_FotoMenor()

            Me.UscFotoMenor._Show_FotoAutoSize()

        End Sub
        Private Sub FRM_CapturarVerificarHuella()

            Dim strMensaje As String = ""
            Dim objBssVisHue As New Bussines.Biometria.VisitanteHuella

            Select Case Me.VisitaTieneHuella
                Case Type.Enumeracion.Visita.Visitante.TieneHuella.SI

                    Dim intIDVisitante As Integer = -1
                    Dim blnTieneMinimoUnaHuella As Boolean = False

                    blnTieneMinimoUnaHuella = objBssVisHue.TieneMinimoUnaHuella(Me._IDVisitante, Me._RegionID, Me._PenalID)

                    If blnTieneMinimoUnaHuella = True Then
                        intIDVisitante = FRM_VerificarHuella()

                        'consultar si el id de la huellacapturada, es igual al id de la huella almacenada del visitante
                        If Me.IDVisitante = intIDVisitante Then
                            Me.pbEstado.Image = My.Resources.accept_32
                            Me.ValidacionHuella = 2 'huella
                            strMensaje = "Icono de validacion de la huella: Huella validada correctamente"
                        Else
                            Me.pbEstado.Image = My.Resources.delete_32
                            Me.ValidacionHuella = -1 'sin validacion
                            strMensaje = "Icono de validacion de la huella: Sin validacion de huella"
                        End If
                    End If

                Case Type.Enumeracion.Visita.Visitante.TieneHuella.Obs

                    Me.pbEstado.Image = My.Resources.advertencia
                    Me.ValidacionHuella = 2 'huella
                    strMensaje = "Icono de validacion de la huella: Huella observada"
                    
                Case Else

            End Select

            Me.ToolTip1.SetToolTip(Me.pbEstado, strMensaje)

        End Sub

        Private Function FRM_VerificarHuella() As Integer

            Dim value As Integer = -1

            Dim objAfis As New APPControlHuellaVisita.IdentificarDispositivo

            'pregunta x el tipo de dispostivo biometrico conectado
            Select Case objAfis.IdentificarDispositivo

                Case APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.RealScanG1

                    Dim frm As New APPControls.Visita.Huella.frmIdentificarPopup
                    With frm
                        ._TipoBusqueda = APPControls.Visita.Huella.frmIdentificarPopup.enmTipoBusqueda.Verificacion
                        ._IDRegion = Me._RegionID
                        ._IDPenal = Me._PenalID
                        ._IDTipoDocumento = Me.IDTipoDocumento
                        ._NumeroDocumento = Me.NumeroDocumento
                        ._IDVisitante = Me.IDVisitante
                        ._HabilitarRecaptura = False

                        If .ShowDialog() = Windows.Forms.DialogResult.OK Then value = ._IDVisitanteReturn

                    End With

                Case APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS10, APPControlHuellaVisita.Type.Enumeracion.enumTipoDispositivo.FutronicFS88H

                    Dim objEntVisHue As New Entity.Biometria.VisitanteHuella
                    Dim objBssVisHue As New Bussines.Biometria.VisitanteHuella

                    objEntVisHue = objBssVisHue.ListarHuellaxIDVisitante(Me._IDVisitante, Me._RegionID, Me._PenalID, "")

                    Dim intIDVisitaCol As New List(Of Integer)
                    Dim intIDVisita As Integer = -1

                    Dim frm As New APPControlHuellaVisita.Huellero.FS10.frmIdentificarPopup
                    With frm
                        ._CNBDHuella = APPControls.Configuracion.ConexionBD.CN_BD_HuellaVisita
                        ._TipoBusqueda = APPControlHuellaVisita.Huellero.FS10.frmIdentificarPopup.enmTipoBusqueda.Verificacion
                        ._IDTipoDocumento = Me.IDTipoDocumento
                        ._NumeroDocumento = Me.NumeroDocumento
                        ._HabilitarRecaptura = False

                        ._DatosHuellaVerificacion(objEntVisHue.TipoCapturaIzquierdo, objEntVisHue.IDIndiceIzquierdo, objEntVisHue.IDPulgarIzquierdo,
                                                    objEntVisHue.CalidadIndiceIzquierdo, objEntVisHue.CalidadPulgarIzquierdo, objEntVisHue.TipoCapturaDerecho,
                                                    objEntVisHue.IDIndiceDerecho, objEntVisHue.IDPulgarDerecho, objEntVisHue.CalidadIndiceDerecho,
                                                    objEntVisHue.CalidadPulgarDerecho)

                        If .ShowDialog = Windows.Forms.DialogResult.OK Then

                            'buscar la huella del visitante
                            Dim objBssVis As New Bussines.Visita.Visitante
                            For Each j As Integer In ._ReturnIDTemplateColRpta
                                intIDVisitaCol.Add(objBssVis.BuscarHuella(j, Me._RegionID, Me._PenalID))
                            Next

                            For Each j As Integer In intIDVisitaCol
                                intIDVisita = j
                            Next

                            If intIDVisita > 0 Then
                                value = intIDVisita
                            Else

                                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                                    "La Huella capturada del dedo seleccionado, no coincide con los datos del visitante. Vuelva ha intentarlo", "Verificacion")
                            End If

                        End If

                    End With
            End Select

            Return value

        End Function

#End Region
#Region "ListarFoto"
        Private Sub ListarInternoFotoVersion(ByVal intIDInterno As Integer)

            If intIDInterno < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(intIDInterno, 2)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub

        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            With Me.UscFotografia1
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
        Private Sub ImagenFotoVisitanteMenor(ByVal FotoNameExtension As String)

            With Me.UscFotoMenor
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub

#End Region
#Region "Otros"
        Private Sub VisibleSalir()

            Me.pnlSalir.Visible = False
            Me.pnlCancelar.Visible = False

            Select Case Me._TipoSalida
                Case enmTipoSalida.Salida
                    Me.pnlCancelar.Visible = True
                Case enmTipoSalida.SalidaNumeroDocumento
                    Me.pnlSalir.Visible = True
            End Select

        End Sub

        Private Sub ValoresxDefault()

            ComboTipoDoc()

            Me.Timer1.Enabled = True
            Me.HoraSalida = Legolas.LBusiness.Globall.DateTime.HoraServer

            Me.pbEstado.Visible = False
            Me.gbrBuscarNumDoc.Visible = False

            Select Case Me._TipoSalida
                Case enmTipoSalida.Salida

                Case enmTipoSalida.SalidaNumeroDocumento
                    Me.gbrBuscarNumDoc.Visible = True
                    Me.pnlHora.Visible = False
            End Select

            VisibleSalir()

            'centrar form
            'leer el id del interno
            Dim intIDCodigoInterno As Integer = -1
            intIDCodigoInterno = Bussines.Visita.Movimiento.Return_InternoID(Me._MovimientoID)

            If intIDCodigoInterno < 1 Then
                intIDCodigoInterno = Bussines.Visita.Movimiento.Return_IDInternoPJ(Me._MovimientoID)
            End If

            If intIDCodigoInterno < 1 Then
                Me.Width = 630
                Legolas.Configuration.Aplication.CentrarForm(Me)
            End If

            With Me.ToolTip1
                .SetToolTip(Me.btnObs, "Agregar observacion de salida")
            End With

        End Sub
        Private Sub Limpiar(blnLimpiarTipoDoc As Boolean)

            If blnLimpiarTipoDoc = True Then
                Me.BuscarIDTipoDocumento = 10 'dni
            End If

            Me.BuscarNumeroDocumento = ""
            Me.NumeroDocumento = ""
            Me.IDTipoDocumento = -1
            Me.TipoDocumentoNombre = ""
            Me.ApellidoPaterno = ""
            Me.ApellidoMaterno = ""
            Me.Nombres = ""
            Me.Nacionalidad = ""
            Me.Sexo = ""
            Me.Foto = ""
            Me.NumeroPase = ""

            Me.IDVisitante = -1
            Me._MovimientoID = -1
            Me.ObsSalida = ""

            'huella
            Me.TipoSalidaPor = 2 'por huella
            Me.IDUsuarioAutorizaSalidaHuella = -1

            Me.pbEstado.Visible = False
            Me.ValidacionHuella = -1

            Me.pnlHora.Visible = False
            Me.UscFotografia1._Limpiar()
            Me.UscFotografia_2v1._Limpiar()
            Me.gbrMenores.Visible = False
            Me.pnlAddObs.Visible = False

            Me.txtBuscarNumDoc.Focus()

        End Sub
        Private Sub HabilitarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.BuscarIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.LE
                    Me.txtBuscarNumDoc.MaxLength = 8
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtBuscarNumDoc.MaxLength = 8
                Case Else
                    Me.txtBuscarNumDoc.MaxLength = 20
            End Select

            Select Case Me.BuscarIDTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Else
                    Me.txtBuscarNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            End Select

            'Me.txtNumDoc.Text = ""
            'Me.txtNumDoc.Focus()

        End Sub
#End Region

        Private Sub frmSalidaPopup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub


        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            Me.lblHoraSal.Text = CDate(Me.lblHoraSal.Text).AddSeconds(1).ToString("HH:mm:ss")
        End Sub

        Private Sub frmSalidaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Select Case Me._TipoSalida
                Case enmTipoSalida.Salida
                    ListarData()
                Case enmTipoSalida.SalidaNumeroDocumento
                    Me.txtBuscarNumDoc.Focus()
            End Select

        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
            AOk()
        End Sub


        Private Sub txtBuscarNumDoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNumDoc.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                BuscarVisitante()
                Me.pnlHora.Focus()
            End If

        End Sub

        Private Sub dgwMenores_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellClick

            '/*iconos*/
            With Me.dgwMenores
                If e.RowIndex = -1 Then Exit Sub
                If .RowCount > 0 Then
                    '/*icono ver*/
                    Select Case e.ColumnIndex
                        Case .Columns("col_ver_fot").Index
                            Form_FotoMenor()
                    End Select
                End If
            End With

        End Sub

        Private Sub dgwMenores_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellEnter

            If Me.dgwMenores.RowCount > 0 Then ImagenFotoVisitanteMenor(Me.GrillaFotoVisitante)

        End Sub

        Private Sub btnSalir_Click(sender As System.Object, e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

            BuscarVisitante()

        End Sub

        Private Sub pnlOK_GotFocus(sender As Object, e As System.EventArgs) Handles pnlOK.GotFocus

            Me.btnOk.Focus()

        End Sub


        Private Sub btnBuscar_GotFocus(sender As Object, e As System.EventArgs) Handles btnBuscar.GotFocus

            Me.txtBuscarNumDoc.Focus()

        End Sub

        Private Sub btnObs_Click(sender As System.Object, e As System.EventArgs) Handles btnObs.Click

            Dim frm As New Visita.Movimiento.frmMovSalidaObs
            frm._Observacion = Me.ObsSalida
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then Me.ObsSalida = frm._Observacion

        End Sub

        Private Sub btnDesbloquear_Click(sender As System.Object, e As System.EventArgs) Handles btnDesbloquear.Click

            If Me._MovimientoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("No se muestra los datos del visitante. Ingrese el numero de documento del visitante.")
                Exit Sub
            End If

            Dim strMensaje As String = "Desea realizar la salida del visitante sin realizar la captura de la huella. Se realizará registros de auditoria por esta operacion"
            If Legolas.Configuration.Aplication.MessageBox.Question(strMensaje) = Windows.Forms.DialogResult.Yes Then

                Me.IDUsuarioAutorizaSalidaHuella = Legolas.Configuration.Usuario.Codigo
                Me.TipoSalidaPor = 1 'por dni

                Me.pbEstado.Image = My.Resources.Resources.id_card_view
                Me.ValidacionHuella = 1 'por dni

                Me.ToolTip1.SetToolTip(Me.pbEstado, "Icono de validacion de la huella: Salida x Numero de Documento")

            End If

        End Sub

        Private Sub cbbTipoDoc_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbTipoDoc.SelectedIndexChanged

            If blnComboTipoDoc = True Then
                Limpiar(False)
                HabilitarNumeroDocumento()
                Me.txtBuscarNumDoc.Focus()
            End If

        End Sub

    End Class

End Namespace
