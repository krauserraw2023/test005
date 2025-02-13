Namespace Visita.Visitante
    Public Class frmVisitanteMenorPopup
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
        Private objBssVis As Bussines.Visita.Visitante = Nothing        
#Region "Propiedades_Parametricas"        
        Public Property _RegionID() As Short = -1
        Public Property _PenalID() As Short = -1
        Public Property _IDEtapaInterno As Short = -1
        Public Property _IDVisitanteAdulto As Integer = -1

        Public Property _IDVisitanteMenor As Integer = -1
        Public Property _IDTipoDocumentoVisitanteMenor As Integer = -1
        Public Property _VisitanteMenorNumeroDocumento As String = ""
#End Region
#Region "Propiedades"
        Public ReadOnly Property FechaVisita As Long
            Get
                Return Legolas.LBusiness.Globall.DateTime.FechaServerLong
            End Get
        End Property
#End Region
#Region "Propiedades_Visita"
        Private intCodigoVisita As Integer = -1
        Public Property VisitanteID() As Integer
            Get
                Return intCodigoVisita
            End Get
            Set(ByVal value As Integer)
                intCodigoVisita = value
            End Set
        End Property
        Private Property TipoDocumentoID() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property VisApellidoPaterno() As String
            Get
                Return Me.txtApePat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property VisApellidoMaterno() As String
            Get
                Return Me.txtApeMat.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property VisNombres() As String
            Get
                Return Me.txtNom.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private ReadOnly Property VisApelidosyNombres() As String
            Get
                Dim strValue As String = ""
                strValue = Me.VisApellidoPaterno & " " & Me.VisApellidoMaterno & ", " & Me.VisNombres

                Return strValue
            End Get
        End Property
        Private Property Nacionalidad() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property Sexo() As Integer
            Get
                Return Me.cbbSexo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbSexo.SelectedValue = value
            End Set
        End Property
        Private Property VisFoto() As Integer = -1
        Private Property VisFotoName() As String = ""
        Private Property VisitaSancion() As Boolean
            Get
                Return Me.UscFoto1._PanelAutorizacion
            End Get
            Set(ByVal value As Boolean)
                Me.UscFoto1._PanelAutorizacion = value
            End Set
        End Property
        Private Property FechaNacimiento() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property
        Private Property VisitaHuellaCodigo() As String = ""
        Private Property VisitaHuellaDedo() As Integer = -1
        Private Property VistaHuellaReniec() As Integer = -1
#End Region
#Region "Propiedades_Return"
        Public ReadOnly Property _VisitanteID() As Integer
            Get
                Return Me.VisitanteID
            End Get
        End Property
#End Region
#Region "Propiedades_Otros"
        Private Property RegimenTipoID As Integer = -1
        Private Property RegimenTipoNombre As String = ""
        Private Property SolicitarAutoRegOrdinario As Boolean = False
#End Region
#Region "Combo"
        Private blnCargoComboTipoDoc = False
        Private Sub ComboDocumentoTipo()

            '/*tipo documento*/
            With Me.cbbTipoDoc
                ._Todos = True
                ._TodosMensaje = "[No Especificado]"
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboOtros()

            Me.cbbNacionalidad.LoadUsc()
            Me.cbbSexo.LoadUsc()

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarIngresoVisitante() As Boolean

            Dim value As Boolean = False

            objBssMov = New Bussines.Visita.Movimiento

            If objBssMov.ValidarDobleIngresoVisitante(Me.VisitanteID, Me.FechaVisita, _
                                                     Me._RegionID, Me._PenalID) = True Then

                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El visitante que desea registrar ya se encuentra dentro del establecimiento")
                Return value
            End If
            value = True

            Return value
        End Function

        Private Sub ValidarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.TipoDocumentoID
                Case Type.Enumeracion.enmTipoDocumento.LE
                    Me.txtNumDoc.MaxLength = 8
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtNumDoc.MaxLength = 8
                Case Else
                    Me.txtNumDoc.MaxLength = 20
            End Select

            Select Case Me.TipoDocumentoID
                Case Type.Enumeracion.enmTipoDocumento.CE, _
                    Type.Enumeracion.enmTipoDocumento.PAS, _
                    Type.Enumeracion.enmTipoDocumento.PN, _
                    Type.Enumeracion.enmTipoDocumento.CC

                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal

                Case Else

                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros

            End Select

            Me.txtNumDoc.Text = ""
            Me.txtNumDoc.Focus()

        End Sub

#End Region
#Region "Listar"
        Private Sub ListarMenordeEdad()

            If Me._IDVisitanteMenor > 0 Then
                Me.TipoDocumentoID = Me._IDTipoDocumentoVisitanteMenor
                Me.NumeroDocumento = Me._VisitanteMenorNumeroDocumento
                Buscar()
            End If

        End Sub
        Private Sub ListarVisitanteData(VisitanteID As Integer)

            If VisitanteID < 1 Then
                Exit Sub
            End If

            objBssVis = New Bussines.Visita.Visitante
            Dim objEnt As Entity.Visita.Visitante

            objEnt = objBssVis.Listar(VisitanteID)
            With objEnt
                Me.VisitanteID = .Codigo
                Me.TipoDocumentoID = .TipoDocumentoID
                Me.NumeroDocumento = .NumeroDocumento
                Me.VisApellidoPaterno = .ApellidoPaterno
                Me.VisApellidoMaterno = .ApellidoMaterno
                Me.VisNombres = .Nombres
                Me.Nacionalidad = .NacionalidadID
                Me.Sexo = .SexoID
                Me.VisFoto = .FotoID
                Me.VisFotoName = .FotoName
                Me.FechaNacimiento = .FechaNacimiento

            End With

            ImagenFotoVisitante(Me.VisFotoName)

            'bloquear datos del visitante
            Dim blnEnabledVisitante As Boolean = False

            HabilitarDatosVisitante(blnEnabledVisitante)

        End Sub
        Private Function ListarVisitante(ByVal NumeroDocumento As String) As Boolean

            Dim value As Boolean = False

            objBssVis = New Bussines.Visita.Visitante
            Dim objEntCol As New Entity.Visita.VisitanteCol

            objEntCol = objBssVis.ListarxNumeroDocumento(Me.TipoDocumentoID, Me.NumeroDocumento, Me._RegionID, Me._PenalID)

            If objEntCol.Count > 0 Then

                For Each ent As Entity.Visita.Visitante In objEntCol
                    'queda
                    If ent.PenalID = Me._PenalID And ent.TipoDocumentoID = Me.TipoDocumentoID Then
                        ListarVisitanteData(ent.Codigo)
                        value = True
                        Exit For
                    End If
                Next
            End If

            Return value

        End Function

        Private Sub Buscar()

            RegimenTipo_Permisos()
            ALimpiar()

            'validar penal
            If Me._PenalID < 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingresar Parametro Penal")
                Exit Sub
            End If

            'validar tipo documento y numero
            Select Case Me.TipoDocumentoID
                Case Is < 1
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Seleccione el tipo de documento")
                    Me.txtNumDoc.Focus()
                    Exit Sub
                Case 10 'dni
                    If Me.NumeroDocumento.Length <> 8 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese el numero de documento, el numero debe contener 8 digitos")
                        Me.txtNumDoc.Focus()
                        Exit Sub
                    End If
            End Select

            '/**************/
            Dim blnSigueProceso As Boolean = True
            Dim blnExisteVisitante As Boolean = False

            blnExisteVisitante = ListarVisitante(Me.NumeroDocumento)

            Me.btnGrabarVisitante.Enabled = True

            If blnExisteVisitante = False Then
                'ALimpiar()

                If Me.SolicitarAutoRegOrdinario = True Then

                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "El visitante no esta registrado en el sistema")
                    blnSigueProceso = False
                    ALimpiar(True)
                    Me.txtNumDoc.Focus()
                Else

                    'If Legolas.Configuration.Aplication.MessageBox.Question( _
                    '"El visitante no existe, desea agregarlo") = Windows.Forms.DialogResult.Yes Then

                    If MessageBox.Show("El visitante no existe, desea agregarlo", _
                                   Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                                   MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                        'numero documento
                        If Me.NumeroDocumento.Trim = "" Then
                            Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                            "Ingrese el numero de documento del visitante")
                            Me.txtNumDoc.Focus()
                            Exit Sub
                        End If

                        HabilitarTipoyNumeroDocumento(False)
                        HabilitarDatosVisitante(True)
                        Me.txtApePat.Focus()
                        blnSigueProceso = False

                    Else

                        ALimpiar(True)
                        Me.txtApePat.Focus()
                        blnSigueProceso = False

                    End If
                End If

            Else

                If Me._IDVisitanteAdulto = Me.VisitanteID Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "La Visita de Menor de Edad, no puede ser igual a la Visita de Adultos")
                    ALimpiar(True)
                    Exit Sub
                End If

                'validar doble ingreso del menor de edad
                If ValidarIngresoVisitante() = False Then
                    ALimpiar(True)
                    Exit Sub
                End If

                'si hay datos del menor de edad
                Me.HabilitarTipoyNumeroDocumento(False)
                HabilitarDatosVisitante()
            End If

        End Sub
#End Region
#Region "Accion"
        Private Function ValidarVisita() As Boolean

            Dim value As Boolean = False

            'numero documento
            Select Case Me.TipoDocumentoID
                Case -1 'no especificado

                Case Else
                    If Me.NumeroDocumento = "" Or Me.NumeroDocumento.Length < 8 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese el numero de documento del visitante")
                        Me.txtNumDoc.Focus()
                        Return value
                    End If
            End Select

            'apellido paterno
            If Me.VisApellidoPaterno = "" Or Me.VisApellidoPaterno.Length < 2 Then
                MessageBox.Show("Ingrese el apellido paterno del visitante", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtApePat.Focus()
                Return value
            End If

            'nombres
            If Me.VisNombres = "" Or Me.VisNombres.Length < 3 Then
                MessageBox.Show("Ingrese los nombres del visitante", _
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNom.Focus()
                Return value
            End If

            'sexo
            If Me.Sexo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Seleccione el sexo del menor")
                Me.cbbSexo.Focus()
                value = False
                Return value
            End If

            'Fecha nacimiento     
            If Me.FechaNacimiento <= 0 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Ingrese la fecha de Nacimiento del menor")
                Me.dtpFechaNac.Focus()
                value = False
                Return value
            End If

            'el visitante no es menor de edad
            If Legolas.Components.FechaHora.FechaCalcularAnio(Me.FechaNacimiento, _
            Legolas.Configuration.Aplication.FechayHora.FechaLong, True) > 17 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "El visitante menor, no puede ser mayor igual a 18 años.")
                Me.dtpFechaNac.Focus()
                value = False
                Return value
            End If

            If Me._IDVisitanteAdulto = Me.VisitanteID Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "La Visita de Menor de Edad, no puede ser igual a la Visita de Adultos")
                value = False
                Return value
            End If

            'validar ingreso doble del menor de edad
            If ValidarIngresoVisitante() = False Then
                value = False
                Return value
            End If

            value = True
            Return value

        End Function
        Private Function AGrabarVisitante(Optional ByVal MensajeGrabar As Boolean = False) As Boolean

            Dim blnValue As Boolean = False

            If ValidarVisita() = False Then          
                Return blnValue
            End If

            Me.VisApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.VisApellidoPaterno)
            Me.VisApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.VisApellidoMaterno)
            Me.VisNombres = Legolas.Components.Cadena.LimpiarEspacios(Me.VisNombres)

            Dim objEnt As New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me.VisitanteID
                .ApellidoPaterno = Me.VisApellidoPaterno
                .ApellidoMaterno = Me.VisApellidoMaterno
                .Nombres = Me.VisNombres
                .SexoID = Me.Sexo
                .TipoDocumentoID = Me.TipoDocumentoID
                .NumeroDocumento = Me.NumeroDocumento
                .FechaNacimiento = Me.FechaNacimiento
                .NacionalidadID = Me.Nacionalidad
                '.FotoID = Me.FotoID
                '.FotoName = Me.FotoName
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            objBssVis = New Bussines.Visita.Visitante
            Me.VisitanteID = objBssVis.Grabar(objEnt)

            'Me.VisitanteID = objBssVis.Grabar(Me.VisitanteID, Me.VisApellidoPaterno, Me.VisApellidoMaterno, _
            'Me.VisNombres, Me.Sexo, Me.TipoDocumentoID, Me.NumeroDocumento, Me.FechaNacimiento, "", _
            'Me.Nacionalidad, "", _
            'Me.VisFoto, Me.VisFotoName, _
            'Me.VisitaHuellaCodigo, Me.VisitaHuellaDedo, _
            'Me.VistaHuellaReniec, _
            'Me._RegionID, Me._PenalID)

            If Me.VisitanteID > 0 And MensajeGrabar = True Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
            End If

            blnValue = True

            Return blnValue

        End Function
        Private Function AGrabarFotoVisita() As Boolean

            Dim Value As Boolean = False

            If ValidarVisita() = False Then              
                Return Value
            End If

            Dim objEnt As New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me.VisitanteID
                .FotoID = Me.VisFoto
                .FotoName = Me.VisFotoName
                .IDUsuarioCapturaFoto = Legolas.Configuration.Usuario.Codigo
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            Dim intIDVisitante As Integer = -1
            objBssVis = New Bussines.Visita.Visitante
            intIDVisitante = objBssVis.GrabarFoto(objEnt)

            'si el resultado es correcto
            If intIDVisitante > 0 Then
                Value = True
            End If

            Return Value

        End Function
        Private Sub AGrabar()

            Dim blnOK As Boolean = True

            'Validar

            If AGrabarVisitante(False) = False Then
                blnOK = False
                Exit Sub
            End If

            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Grabe el registro del visitante menor")
                blnOK = False
                Exit Sub
            End If

            If Me.VisFoto < 1 Then

                If Legolas.Configuration.Aplication.MessageBox.Question( _
                "No ha agregado la foto del Visitante, desea agregar la foto") = Windows.Forms.DialogResult.Yes Then

                    FormFoto()
                    If Me.VisFoto < 1 Then
                        blnOK = False
                        Exit Sub
                    End If
                End If
            End If

            If blnOK = True Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
        Private Function AGrabarFotoLocal(FotoNameExtension As String, PathFotoName As String) As Boolean

            Dim value As Boolean = False

            Dim objBssImag As New Bussines.Globall.ArchivoDigital

            Me.VisFoto = objBssImag.GrabarImage(Me.VisFoto, FotoNameExtension, _
                                               PathFotoName, -1, Me._PenalID, Me._RegionID, _
                                               Type.Enumeracion.ArchivoDigital.TipoImagen.Visitante)

            value = APPControls.Configuracion.WebService.SubirFoto(FotoNameExtension, PathFotoName, APPControls.Configuracion.WebService.enmDirectotioTipo.Visitante)

            If value = False Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "La fotografia no fue grabada en el directorio, vuelva ha intentarlo")
            Else
                Legolas.Components.Archivo.FileDelete(PathFotoName)
            End If

            Return value

        End Function
#End Region
#Region "Permisos/Accesos"
        Private Sub RegimenTipo_Permisos()

            Dim objBss As New Bussines.Visita.Config
            Dim objEnt As New Entity.Visita.Config

            Dim objEntFiltro As New Entity.Visita.Config

            With objEntFiltro
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
                .Estado = 1 'alta
            End With

            objEnt = objBss.ListarConfigActual(objEntFiltro)

            If Not objEnt Is Nothing Then
                With objEnt
                    Me.RegimenTipoID = .RegimenTipoID
                    Me.RegimenTipoNombre = .RegimenTipoNombre
                    'Me.SolicitarInfoPabellon = .SolicitaInfoPabellon
                    Me.SolicitarAutoRegOrdinario = .SolicitaAutoRegOrdinario
                End With
            Else
                Me.RegimenTipoID = -1
                Me.RegimenTipoNombre = "Regimen Ordinario"
                'Me.SolicitarInfoPabellon = False
                Me.SolicitarAutoRegOrdinario = False
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FormFoto()

            If AGrabarVisitante(False) = False Then
                Exit Sub
            End If

            If Me.VisitanteID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Antes de capturar la foto del visitante, grabe el registro")
                Me.txtNumDoc.Focus()
                Exit Sub
            End If

            Dim strCodigo As String = ""
            Dim intInstall As Integer = -1
            Dim strRegion As String = ""
            Dim strPenal As String = ""
            Dim strNumDoc As String = ""

            intInstall = Configuracion.Licencia.Codigo

            Dim objBss As New Bussines.Sistema.InstalacionDetalle
            Dim objEnt As Entity.Sistema.InstalacionDetalle

            objEnt = objBss.ListarRegionPenal(intInstall)
            With objEnt
                strRegion = .RegionID.ToString("00")
                strPenal = .PenalID.ToString("0000")
            End With
            strNumDoc = Legolas.Components.Cadena.Format(Me.NumeroDocumento, "000000000000")
            strCodigo = strRegion & strPenal & strNumDoc

            '/*capturar foto de la webcam, version02.1*/
            Me.VisFotoName = strCodigo & ".jpg"
            Dim strPathFoto As String = Legolas.Configuration.Path.FotoVisitante & Me.VisFotoName

            Dim blnCopio As Boolean = False
            Dim strRutaW As String = Legolas.Configuration.Path.Directorio & "windows81.ini".ToUpper.ToString

            '/*si el equipo dectecta el archivo windows8.1, sadlra la webcam para ese so*/
            If Legolas.Components.Archivo.FileExiste(strRutaW) = True Then
                Dim frm As New APPCamaraWeb.frmFotov3
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                        ._EliminarArchivo(._PathImagenTemporal)
                    End If
                End With
            Else
                Dim frm As New APPCamaraWeb.frmFoto
                With frm
                    If .ShowDialog = Windows.Forms.DialogResult.OK Then
                        blnCopio = Legolas.Components.Archivo.FileCopy(._PathImagenTemporal, strPathFoto, True)
                        ._EliminarArchivo(._PathImagenTemporal)
                    End If
                End With
            End If

            If blnCopio = True Then
                blnCopio = AGrabarFotoLocal(Me.VisFotoName, strPathFoto)
            End If

            'si la foto subio al web service
            If blnCopio = True Then
                ImagenFotoVisitante(Me.VisFotoName, True)
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarDatosVisitante()

            Dim blnEnabledVisitante As Boolean = True

            If Me._SolicitarAutoRegOrdinario = True Then
                blnEnabledVisitante = False
            Else
                If Me._IDEtapaInterno < 1 Then
                    blnEnabledVisitante = True
                Else
                    blnEnabledVisitante = False
                End If
            End If

            HabilitarDatosVisitante(blnEnabledVisitante)

        End Sub
        Private Sub HabilitarDatosVisitante(vf As Boolean)


            Me.pnlDatosVisitante.Enabled = vf

        End Sub
        Private Sub HabilitarTipoyNumeroDocumento(vf As Boolean)

            Me.cbbTipoDoc.Enabled = vf
            Me.txtNumDoc.Enabled = vf
            Me.btnBuscar.Enabled = vf

        End Sub
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String, Optional ByVal Nuevo As Boolean = False)

            With Me.UscFoto1
                '._TipoImagen = Foto.uscFotografia.DirectotioTipo.Visitante
                ._ShowFotoVisitante(FotoNameExtension)
            End With

            If Nuevo = True Then
                AGrabarFotoVisita()                
            End If

        End Sub
        Private Sub ALimpiar(Optional ByVal LimpiarNumeroDoc As Boolean = False)

            Me.VisitanteID = -1

            If LimpiarNumeroDoc = True Then
                Me.NumeroDocumento = ""
            End If

            Me.VisApellidoPaterno = ""
            Me.VisApellidoMaterno = ""
            Me.VisNombres = ""
            Me.Sexo = -1 'masculino
            Me.Nacionalidad = 141 'peruana
            Me.FechaNacimiento = 0
            Me.UscFoto1._Limpiar()

            Me.pnlDatosVisitante.Enabled = False
            Me.btnGrabarVisitante.Enabled = False

            Me.HabilitarTipoyNumeroDocumento(True)
            Me.txtNumDoc.Focus()

        End Sub
        Private Sub ValoresxDefault()

            ComboDocumentoTipo()
            ComboOtros()

            Me.TipoDocumentoID = 10 'dni
            Me.Nacionalidad = 141 'peru
            blnCargoComboTipoDoc = True
        End Sub

        'Private Sub HabilitarFechaNacimiento()

        '    If Me.chkOmitirFecha.Checked = True Then
        '        Me.FechaNacimiento = 0
        '        Me.dtpFechaNac.Enabled = False
        '    Else
        '        Me.dtpFechaNac.Enabled = True
        '        Me.dtpFechaNac.Focus()
        '    End If

        'End Sub
#End Region

        Private Sub btnCapurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapurar.Click
            FormFoto()
        End Sub

        Private Sub frmVisitantePopupIngreso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            ValoresxDefault()
        End Sub

        Private Sub txtNumDoc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                Buscar()
            End If

        End Sub

        Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

            ALimpiar(True)

        End Sub

        Private Sub btnGrabarVisitante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabarVisitante.Click

            AGrabar()

        End Sub

        Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
            Me.Close()
        End Sub

        Private Sub frmVisitanteMenorPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            Me.txtNumDoc.Focus()
            ListarMenordeEdad()

        End Sub

        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

            Buscar()

        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged

            If Me.TipoDocumentoID > 0 And blnCargoComboTipoDoc = True Then
                ValidarNumeroDocumento()
            End If

        End Sub

    End Class
End Namespace
