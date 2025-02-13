Namespace Visita.Visitante
    Public Class frmMantenimiento
        Private objBss As Bussines.Visita.Visitante = Nothing
        Private objEnt As Entity.Visita.Visitante = Nothing
        '************************************************/
        Private blnValoresxDefault As Boolean = False        
#Region "Propiedades_Parametricas"
      
        Public Property _RegionID() As Integer
            Get
                Return Me.UscRegionPenalLabel1._RegionId
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._RegionId = value
            End Set
        End Property
        Public Property _RegionNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._RegionNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._RegionNombre = value
            End Set
        End Property
        Public Property _PenalID() As Integer
            Get
                Return Me.UscRegionPenalLabel1._Penalid
            End Get
            Set(ByVal value As Integer)
                Me.UscRegionPenalLabel1._Penalid = value
            End Set
        End Property
        Public Property _PenalNombre() As String
            Get
                Return Me.UscRegionPenalLabel1._PenalNombre
            End Get
            Set(ByVal value As String)
                Me.UscRegionPenalLabel1._PenalNombre = value
            End Set
        End Property
#End Region
#Region "Propiedades_Visita"                                
        Public Property _Codigo() As Integer=-1          
        Private Property VisTipoDocumento() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property VisNumeroDocumento() As String
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
                strValue = Me.VisApellidoPaterno & " " & Me.VisApellidoMaterno & " " & Me.VisNombres

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
        Private Property VisFoto() As Integer=-1          
        Private Property VisFotoName() As String=""
         
        Private Property VisitaSancion() As Boolean
            Get
                Return Me.UscFoto1._PanelAutorizacion
            End Get
            Set(ByVal value As Boolean)
                Me.UscFoto1._PanelAutorizacion = value
            End Set
        End Property
        Private Property VisitanteNacimiento() As Long
            Get
                Return Me.dtpFechaNac.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaNac.ValueLong = value
            End Set
        End Property
        Private Property VisitanteValidadoReniec As Type.Enumeracion.Visita.Visitante.ValidadoServicio = Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar
#End Region
#Region "Combo"
        Private Sub ComboDocumentoTipo()

            '/*tipo documento*/
            With Me.cbbTipoDoc
                .LoadUsc()
            End With

        End Sub
        Private Sub ComboOtros()

            Me.cbbNacionalidad.LoadUsc()
            Me.cbbSexo.LoadUsc()

        End Sub
#End Region
#Region "Listar"
        Private Sub ListarData()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.Visitante
            objEnt = New Entity.Visita.Visitante

            objEnt = objBss.Listar(Me._Codigo)

            With objEnt
                'Me.VisitanteID = .Codigo
                Me.VisTipoDocumento = .TipoDocumentoID
                Me.VisNumeroDocumento = .NumeroDocumento
                Me.VisApellidoPaterno = .ApellidoPaterno
                Me.VisApellidoMaterno = .ApellidoMaterno
                Me.VisNombres = .Nombres
                Me.Nacionalidad = .NacionalidadID
                Me.Sexo = .SexoID
                Me.VisFoto = .FotoID
                Me.VisFotoName = .FotoName
                Me.VisitanteNacimiento = .FechaNacimiento
                Me.VisFoto = .FotoID
                Me.VisitanteValidadoReniec = .VisitanteValidoReniec
                Me._RegionID = .RegionID
                Me._PenalID = .PenalID
            End With

            ImagenFotoVisitante(Me.VisFotoName)
            ListarHuella()

            ListarUscMovimiento()

            Select Case Me.VisitanteValidadoReniec
                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado, Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                    HabilitarDatos(False)
                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado5111
                    HabilitarDatos(False)
            End Select

            LeyendaValidacionReniec(Me.VisitanteValidadoReniec)

        End Sub
        Private Sub ListarHuella()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            With UscVistaHuella1
                ._IDVisitante = Me._Codigo
                ._IDRegion = Me._RegionID
                ._IDPenal = Me._PenalID
                ._ListarUsc()
            End With    

        End Sub
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String, Optional ByVal Nuevo As Boolean = False)

            With Me.UscFoto1
                '._TipoImagen = APPControls.Foto.uscFotografia.DirectotioTipo.Visitante
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub

        Private Sub ListarUscMovimiento()

            With Me.UscMovimientosVisitas1
                ._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Visitante
                ._VisitanteID = Me._Codigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisiblePanelFiltroAnio = False
                ._VisiblePanelFiltro = True
                ._VisiblePanelCount = True
                ._VisibleCountInterno = True
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarUscSancion()

            'With Me.UscVisitanteSancion1
            '    ._VisitanteID = Me._Codigo
            '    ._RegionID = Me._RegionID
            '    ._PenalID = Me._PenalID
            '    ._VisibleGrabar = Me._FormEscritura
            '    ._LoadUsc()
            'End With

        End Sub
        Private Sub ListarUscRestriccion()

            With Me.UscVisitanteRestriccion1
                ._VisitanteID = Me._Codigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisibleGrabar = Me._FormEscritura
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarUscAutorizacion()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            With Me.UscAutorizacion1
                ._AutorizavionVista = Type.Enumeracion.Visita.AutorizacionVista.Visitante
                ._VisitanteID = Me._Codigo
                ._visibleCabecera = False
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarUscSancion2()

            With Me.UscSancionv21
                ._VisitanteID = Me._Codigo
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisibleGrabar = Me._FormEscritura
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = False

            'numero documento
            If Me.VisNumeroDocumento = "" Then     
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
               "Ingrese el numero de documento del visitante")
                Me.txtNumDoc.Focus()
                Return blnValue
            End If

            Select Case Me.VisTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI

                    If Me.VisNumeroDocumento.Length <> 8 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese el numero de documento valido del visitante")
                        Me.txtNumDoc.Focus()
                        Return blnValue
                    End If

                Case Type.Enumeracion.enmTipoDocumento.PAS, Type.Enumeracion.enmTipoDocumento.CE

                    If Me.VisNumeroDocumento.Length < 5 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                        "Ingrese el numero de documento del visitante")
                        Me.txtNumDoc.Focus()
                        Return blnValue
                    End If

            End Select

            'apellido paterno
            If Me.VisApellidoPaterno = "" Or Me.VisApellidoPaterno.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
               "Ingrese el apellido paterno del visitante")
                Me.txtApePat.Focus()
                Return blnValue
            End If

            'nombres
            If Me.VisNombres = "" Or Me.VisNombres.Length < 2 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
               "Ingrese los nombres del visitante")
                Me.txtNom.Focus()
                Return blnValue
            End If

            If Me.chkOmitirFecha.Checked = False Then
                'Fecha nacimiento
                If Me.VisitanteNacimiento <= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                   "Ingrese la fecha de Nacimiento")
                    Me.dtpFechaNac.Focus()
                    Return blnValue
                End If
            End If

            blnValue = True

            Return blnValue

        End Function
        Private Function AGrabar(ByVal MostrarMensaje As Boolean) As Boolean

            Dim value As Boolean = False

            If Validar() = False Then
                Return value
            End If

            Me.VisApellidoPaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.VisApellidoPaterno)
            Me.VisApellidoMaterno = Legolas.Components.Cadena.LimpiarEspacios(Me.VisApellidoMaterno)
            Me.VisNombres = Legolas.Components.Cadena.LimpiarEspacios(Me.VisNombres)

            objEnt = New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me._Codigo
                .ApellidoPaterno = Me.VisApellidoPaterno
                .ApellidoMaterno = Me.VisApellidoMaterno
                .Nombres = Me.VisNombres
                .SexoID = Me.Sexo
                .TipoDocumentoID = Me.VisTipoDocumento
                .NumeroDocumento = Me.VisNumeroDocumento
                .FechaNacimiento = Me.VisitanteNacimiento
                .NacionalidadID = Me.Nacionalidad
                '.FotoID = Me.VisFoto
                '.FotoName = Me.VisFotoName
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            objBss = New Bussines.Visita.Visitante
            Me._Codigo = objBss.Grabar(objEnt)

            If Me._Codigo > 0 Then
                value = True

                If MostrarMensaje = True Then
                    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                End If

            End If

            Return value

        End Function
        Private Function AGrabarFoto() As Boolean

            Dim Value As Boolean = False

            Dim objEnt As New Entity.Visita.Visitante
            With objEnt
                .Codigo = Me._Codigo
                .FotoID = Me.VisFoto
                .FotoName = Me.VisFotoName
                .IDUsuarioCapturaFoto = Legolas.Configuration.Usuario.Codigo
                .RegionID = Me._RegionID
                .PenalID = Me._PenalID
            End With

            Dim intIDVisitante As Integer = -1
            objBss = New Bussines.Visita.Visitante
            intIDVisitante = objBss.GrabarFoto(objEnt)

            'si el resultado es correcto
            If intIDVisitante > 0 Then
                Value = True                
            End If

            Return Value

        End Function
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
        Private Property RegimenVisitaID As Short = -1
        Private Property RegimenTipoNombre As String = ""
        Private Property SolicitarAutoRegOrdinario As Boolean = False
        Private Property SolicitarInfoPabellon As Boolean = False
        Private Property SolicitaModuloPOPE As Boolean = False
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
                    Me.RegimenVisitaID = .RegimenTipoID
                    Me.RegimenTipoNombre = .RegimenTipoNombre
                    Me.SolicitarInfoPabellon = .SolicitaInfoPabellon
                    Me.SolicitarAutoRegOrdinario = .SolicitaAutoRegOrdinario
                    Me.SolicitaModuloPOPE = .SolicitaModuloPOPE
                End With
            Else
                Me.RegimenVisitaID = -1
                Me.RegimenTipoNombre = "Regimen Ordinario"
                Me.SolicitarInfoPabellon = False
                Me.SolicitarAutoRegOrdinario = False
            End If

        End Sub
#End Region
#Region "Form"
        Private Sub FRM_SancionMant(ByVal Nuevo As Boolean, ByVal SancionID As Integer)

            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Haga click en el boton grabar, antes de agregar la sancion del Visitante")
                Exit Sub
            End If

            Dim intIDSancion As Integer = -1
            Dim blnProcesar As Boolean = False

            Dim frm As New Visita.Visitante.frmSancionPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisitanteID = Me._Codigo
                ._VisitanteApeNom = Me.VisApelidosyNombres
                ._VisibleGrabar = Me._FormEscritura

                If Nuevo = True Then
                    .Codigo = -1
                Else
                    .Codigo = SancionID
                End If

                If .ShowDialog = DialogResult.OK Then
                    intIDSancion = ._IDSancionReturn
                    'Me.UscVisitanteSancion1._LoadUsc()
                    'Me.UscSancionv21._LoadUsc()
                    blnProcesar = True
                End If

                'si la sancion fue registrado con exito, enviar la sancion a la sede central
                If blnProcesar = True Then
                    FRM_EnviarSancion(intIDSancion)
                End If

                If blnProcesar = True Then
                    'Me.UscVisitanteSancion1._LoadUsc()
                    Me.UscSancionv21._LoadUsc()                    
                End If

            End With
        End Sub

        Private Sub FRM_EnviarSancion(intIDSancion As Integer)

            Dim blnHabilitar As Boolean = False
            Dim objBssConfVis As New Bussines.Visita.Config

            blnHabilitar = objBssConfVis.HabilitarSancionSede(Me._RegionID, Me._PenalID)

            'si la sancion fue registrado con exito, enviar la sancion a la sede central
            If blnHabilitar = True Then

                If intIDSancion > 0 Then

                    Dim frm As New Visita.Visitante.frmTransferirSancionPopup
                    With frm
                        ._IDSancion = intIDSancion
                        .ShowDialog()
                    End With
                End If

            End If

        End Sub

        Private Sub FRM_VerSancionyAnul(ByVal Nuevo As Boolean, ByVal SancionID As Integer)

            Dim frm As New Visita.Visitante.frmSancionAnuladoPopup
            With frm
                .Codigo = SancionID
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisitanteID = Me._Codigo
                ._VisitanteApeNom = Me.VisApelidosyNombres
                ._VisibleGrabar = Me._FormEscritura

                If .ShowDialog = DialogResult.OK Then
                    'Me.UscVisitanteSancion1._LoadUsc()
                    Me.UscSancionv21._LoadUsc()
                End If

            End With
        End Sub

        Private Sub FRM_RestriccionMant(ByVal Nuevo As Boolean, ByVal RestriccionID As Integer)

            If Me._Codigo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                    "Haga click en el boton grabar, antes de agregar la restriccion del Visitante")
                Exit Sub
            End If

            Dim frm As New Visita.Visitante.frmRestriccionPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisitanteID = Me._Codigo
                ._VisitanteApeNom = Me.VisApelidosyNombres
                ._VisibleGrabar = Me._FormEscritura

                If Nuevo = True Then
                    .Codigo = -1
                Else
                    .Codigo = RestriccionID
                End If

                If .ShowDialog = DialogResult.OK Then
                    'Me.UscVisitanteSancion1._LoadUsc()
                    Me.UscVisitanteRestriccion1._LoadUsc()
                End If

            End With

        End Sub

        Private Sub FRM_AgregarAnulacion(SancionVisID As Integer)

            Dim intIDSancion As Integer = -1
            Dim blnProcesar As Boolean = False

            Dim frm As New Visita.Visitante.frmAnulacionPopup
            With frm
                ._VisibleGrabar = Me._FormEscritura
                .SancionVisitanteID = SancionVisID

                If .ShowDialog = DialogResult.OK Then

                    intIDSancion = ._IDSancionReturn
                    'Me.UscVisitanteSancion1._LoadUsc()
                    'Me.UscSancionv21._LoadUsc()
                    blnProcesar = True
                End If

            End With

            If blnProcesar = True Then
                FRM_EnviarSancion(SancionVisID)
            End If

            If blnProcesar = True Then
                'Me.UscVisitanteSancion1._LoadUsc()
                Me.UscSancionv21._LoadUsc()
            End If                    

        End Sub

        Private Sub FormFoto()

            If Me._Codigo < 1 Then
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

            strRegion = Me._RegionID.ToString("00")
            strPenal = Me._PenalID.ToString("0000")
            strNumDoc = Legolas.Components.Cadena.Format(Me.VisNumeroDocumento, "000000000000")
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

                '/*grabar foto*/                
                AGrabarFoto()

                ImagenFotoVisitante(Me.VisFotoName, True)

            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub LeyendaValidacionReniec(intVisitanteValdiacionReniec As Type.Enumeracion.Visita.Visitante.ValidadoServicio)

            Dim objColor As Color
            Select Case intVisitanteValdiacionReniec
                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.SinValidar
                    objColor = Color.White

                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado, Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado
                    objColor = Color.LightGreen

                Case Type.Enumeracion.Visita.Visitante.ValidadoServicio.Diferencias

                    objColor = Color.Gold

                Case Else
                    objColor = Color.IndianRed
            End Select

            Me.pnlFotografia.BackColor = objColor

        End Sub
        Private Sub HabilitarDatos(vf As Boolean)

            Me.cbbTipoDoc.Enabled = vf
            Me.txtNumDoc.Enabled = vf
            Me.txtApePat.Enabled = vf
            Me.txtApeMat.Enabled = vf
            Me.txtNom.Enabled = vf
            Me.cbbSexo.Enabled = vf
            Me.cbbNacionalidad.Enabled = vf
            Me.dtpFechaNac.Enabled = vf
            Me.chkOmitirFecha.Enabled = vf

        End Sub
        Private Sub ValidarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.VisTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.LE
                    Me.txtNumDoc.MaxLength = 8
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtNumDoc.MaxLength = 8
                Case Else
                    Me.txtNumDoc.MaxLength = 20
            End Select

            Select Case Me.VisTipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Else
                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            End Select

            Me.txtNumDoc.Text = ""
            Me.txtNumDoc.Focus()

        End Sub
        Private Sub HabilitarControles()

            RegimenTipo_Permisos()

            'Dim blnEliminarTab As Boolean = False

            'Select Case Me.RegimenVisitaID
            '    Case 2, 3
            '        blnEliminarTab = False
            '    Case Else
            '        blnEliminarTab = True
            'End Select

            'If blnEliminarTab = True Then
            '    If Me.SolicitarAutoRegOrdinario = False Then
            '        blnEliminarTab = True
            '    Else
            '        blnEliminarTab = False
            '    End If
            'End If

            'If blnEliminarTab = True Then
            '    Me.TabControl1.TabPages.Remove(Me.tp_Autorizacion)
            'End If

        End Sub
        Private Sub HabilitarFechaNacimiento()

            If Me.chkOmitirFecha.Checked = True Then
                Me.dtpFechaNac.ValueLong = 0
            End If

            Me.dtpFechaNac.Enabled = Not Me.chkOmitirFecha.Checked

        End Sub
        Private Sub ValoresxDefault()

            blnValoresxDefault = False
            Me.TabControl1.TabIndex = 0
            ComboDocumentoTipo()
            ComboOtros()

            Me.VisTipoDocumento = 10 'dni
            Me.Nacionalidad = 141 'peru   

            blnValoresxDefault = True

        End Sub
        Private Sub PermisosUsuario()

            Me.pnlGrabar.Visible = Me._FormEscritura
            'Me.btnCapurar.Visible = Me._FormEscritura

        End Sub
#End Region

        Private Sub frmVisitante_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            HabilitarControles()
            ValoresxDefault()
            PermisosUsuario()

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name

                Case Me.tp_visita.Name
                    ListarUscMovimiento()
                    'Case Me.tp_sancion.Name
                    '    ListarUscSancion()
                Case Me.tp_restriccion.Name
                    ListarUscRestriccion()
                Case Me.tp_Autorizacion.Name
                    ListarUscAutorizacion()
                Case Me.tp_sancion2.Name
                    ListarUscSancion2()
            End Select

        End Sub


        Private Sub frmVisitante_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ListarData()

            If Me.VisitanteValidadoReniec = Type.Enumeracion.Visita.Visitante.ValidadoServicio.ReniecValidado Or
                Me.VisitanteValidadoReniec = Type.Enumeracion.Visita.Visitante.ValidadoServicio.MigracionesValidado Then

                Dim blnVerCambioSexo As Boolean = False

                'permisos para cambiar el sexo del visitante
                Select Case Legolas.Configuration.Usuario.NivelUsuario
                    Case Type.Enumeracion.Licencia.enmTipoLicencia.Sede

                        If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                            blnVerCambioSexo = True
                        End If

                    Case Type.Enumeracion.Licencia.enmTipoLicencia.PenalProvincia,
                          Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaProvincia,
                          Type.Enumeracion.Licencia.enmTipoLicencia.PenalLimaMetropolitana

                        If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.JefeSeguridad Then
                            blnVerCambioSexo = True
                        End If
                End Select

                Me.pnlCambioSexo.Visible = blnVerCambioSexo

            End If

        End Sub

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

            AGrabar(True)

        End Sub

        Private Sub btnCapurar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapurar.Click

            If AGrabar(False) = True Then
                FormFoto()
            End If

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub UscVisitanteSancion1__CellDoubleClick_Grilla(ByVal SancionID As Integer)
            FRM_SancionMant(False, SancionID)
        End Sub


        Private Sub UscVisitanteSancion1__ClickAgregar()

            FRM_SancionMant(True, -1)

        End Sub

        Private Sub UscVisitanteRestriccion1__CellDoubleClick_Grilla(ByVal RestriccionID As Integer) Handles UscVisitanteRestriccion1._CellDoubleClick_Grilla

            FRM_RestriccionMant(False, RestriccionID)

        End Sub

        Private Sub UscVisitanteRestriccion1__ClickAgregar() Handles UscVisitanteRestriccion1._ClickAgregar

            FRM_RestriccionMant(True, -1)

        End Sub

        Private Sub chkOmitirFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOmitirFecha.CheckedChanged

        End Sub

        Private Sub chkOmitirFecha_Click(sender As Object, e As System.EventArgs) Handles chkOmitirFecha.Click

            HabilitarFechaNacimiento()

        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged

            If Me.VisTipoDocumento > 0 And blnValoresxDefault = True Then
                ValidarNumeroDocumento()
            End If

        End Sub

        Private Sub cbbTipoDoc_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipoDoc.Load

        End Sub

        Private Sub UscVisitanteSancion1_Load(sender As System.Object, e As System.EventArgs)

        End Sub

        Private Sub UscSancionv21__ClickAgregar() Handles UscSancionv21._ClickAgregar

            FRM_SancionMant(True, -1)

        End Sub

        Private Sub UscSancionv21__CellDoubleClick_Grilla(SancionID As System.Int32, EstadoID As Integer) Handles UscSancionv21._CellDoubleClick_Grilla

            If EstadoID = 0 Then
                FRM_VerSancionyAnul(False, SancionID)
            Else
                FRM_SancionMant(False, SancionID)
            End If

        End Sub

        Private Sub UscSancionv21__ActualizarAnulacion(SancionVisID As System.Int32) Handles UscSancionv21._ClickAnulacion

            FRM_AgregarAnulacion(SancionVisID)

        End Sub

        Private Sub btnCambiarSexo_Click(sender As Object, e As EventArgs) Handles btnCambiarSexo.Click

            'cambiar el sexo, solo estara disponible para usuarios de tipo sede central y oficina de sistemas
            Dim intSexo As Short = -1

            If Me.Sexo = 1 Then 'masculino
                intSexo = 2 'pasa a femenino
            Else
                intSexo = 1 'pasa a masculino
            End If

            If Me._Codigo > 0 Then

                If MessageBox.Show("Desea cambiar el sexo del visitante", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                    Exit Sub
                End If

                Dim sqlCN As SqlClient.SqlConnection = New SqlClient.SqlConnection(Legolas.Configuration.Data.ConexionIni)
                Dim strMensaje As String = ""
                Dim strQuery As String = "update VIS_Visitante set _flg_trf=1,sex_id=" & intSexo & ",_fec_mod=" & Now.ToFileTime & ", _usu_mod=" &
                    Legolas.Configuration.Usuario.Codigo & " where vis_id=" & Me._Codigo

                Legolas.Components.SQL.ExecuteBatchNonQuery(sqlCN, strQuery, strMensaje, True)

                MessageBox.Show("Operacion realizada satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                ListarData()

            Else
                MessageBox.Show("Antes de realizar el cambio de sexo del visitante, el registro del visitante debe estar previamente registrado.")
            End If

        End Sub

        Private Sub UscSancionv21__ClickAnulacion_Desarrollo(SancionVisID As Integer) Handles UscSancionv21._ClickAnulacion_Desarrollo

            Select Case Legolas.Configuration.Usuario.OficinaID
                Case 1 'desarrollo de sistemas
                    FRM_EnviarSancion(SancionVisID)
            End Select

        End Sub
    End Class
End Namespace