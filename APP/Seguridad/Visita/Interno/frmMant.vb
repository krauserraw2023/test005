Namespace Visita.Interno
    Public Class frmMant
        Private objBss As Bussines.Visita.Interno = Nothing
        Private objEnt As Entity.Visita.Interno = Nothing
#Region "Propiedades_Parametricas"
        Private intInternoid As Integer = -1
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
        Public Property _InternoID() As Integer
            Get
                Return intInternoid
            End Get
            Set(ByVal value As Integer)
                intInternoid = value
            End Set
        End Property
#End Region
#Region "Propiedades"
        Private Property CodigoInterno() As String
            Get
                Return Me.txtCodInterno.Text
            End Get
            Set(ByVal value As String)
                Me.txtCodInterno.Text = value
            End Set
        End Property
        Private Property Paterno() As String
            Get
                Return Me.txtApePat.Text
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property Materno() As String
            Get
                Return Me.txtApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property Nombres() As String
            Get
                Return Me.txtNom.Text
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
            End Set
        End Property
        Private ReadOnly Property ApellidosyNombres() As String
            Get
                Dim value As String = ""
                value = Me.Paterno & " " & Me.Materno & " " & Me.Nombres
                Return value
            End Get
        End Property
        Private Property Sexo() As Integer
            Get
                Return Me.cbbSexo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbSexo.SelectedValue = value
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
        Private Property TipoDocumento() As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property NumeroDocumento() As String
            Get
                Return Me.txtNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.txtNumDoc.Text = value
            End Set
        End Property
        Private Property PabellonID() As Integer = -1
        '    Get
        '        Return Me.cbbPabellon._SelectedValue
        '    End Get
        '    Set(ByVal value As Integer)
        '        Me.cbbPabellon._SelectedValue = value
        '    End Set
        'End Property
        Public Property PabellonNombre As String
            Get
                Return Me.txtPabellon.Text
            End Get
            Set(value As String)
                Me.txtPabellon.Text = value
            End Set
        End Property
        Private Property EtapaNombre() As String
            Get
                Return Me.txtEtapa.Text
            End Get
            Set(ByVal value As String)
                Me.txtEtapa.Text = value.ToUpper
            End Set
        End Property
        Private Property NacionalidadID() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property EstadoID() As Integer
            Get
                Dim _int As Integer = -1
                If chk_estado.Checked = True Then
                    _int = 1
                Else
                    _int = 0
                End If
                Return _int
            End Get
            Set(ByVal value As Integer)
                Select Case value
                    Case 1
                        chk_estado.Checked = True
                    Case 0
                        chk_estado.Checked = False
                End Select
            End Set

        End Property
        Private Property Obs() As String
            Get
                Return Me.txtobservacion.Text
            End Get
            Set(ByVal value As String)
                Me.txtobservacion.Text = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private blnCargoTipoDoc As Boolean = False
        Private Sub Combo()

            'cargar combos                        
            Me.cbbNacionalidad.LoadUsc()
            Me.cbbSexo.LoadUsc()
            Me.cbbTipoDoc.LoadUsc()
            blnCargoTipoDoc = True

        End Sub
        'Private Sub ComboPabellon()

        '    With Me.cbbPabellon
        '        ._RegionID = Me._RegionID
        '        ._PenalID = Me._PenalID
        '        ._Ninguno = True
        '        ._LoadUsc()
        '    End With

        'End Sub
#End Region
#Region "Listar"
        Public Sub Listar(ByVal Codigo As Integer)

            If Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.Interno
            objEnt = New Entity.Visita.Interno

            objEnt = objBss.Listar2(Codigo)

            With objEnt
                Me.CodigoInterno = .CodigoRP
                Me.Paterno = .ApellidoPaterno
                Me.Materno = .ApellidoMaterno
                Me.Nombres = .Nombres
                Me.Sexo = .SexoID
                Me.FechaNacimiento = .FechaNacimiento
                Me.TipoDocumento = .TipoDocumentoID
                Me.NumeroDocumento = .NumeroDocumento
                Me.PabellonID = .PabellonID
                Me.PabellonNombre = .PabellonNombre
                Me.EtapaNombre = .EtapaNombre
                Me.NacionalidadID = .NacionalidadID
                Me.Obs = .Obs
                Me.EstadoID = .EstadoID
                Me._RegionID = .IDRegion
                Me._RegionNombre = .RegionNombre
                Me._PenalID = .IDPenal
                Me._PenalNombre = .PenalNombre
            End With

            ListarInternoFotoVersion(Me._InternoID)
            ListarUscVisitaMovimiento()

        End Sub
        

        Private Sub ListarUscVisitaMovimiento()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            With Me.UscMovimientosVisitas1
                ._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.Interno
                ._InternoID = Me._InternoID  'internoid
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisiblePanelFiltro = True
                ._VisiblePanelCount = True
                ._VisibleCountVisitante = True
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarUscSancion()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            With Me.UscSancion1
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._VisibleGrabar = Me._FormEscritura
                ._LoadUsc()
            End With

        End Sub
        Private Sub ListarUscAutorizacion()

            If Me._InternoID < 1 Then
                Exit Sub
            End If

            With Me.UscAutorizacion1
                ._InternoID = Me._InternoID
                ._visibleCabecera = False
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "ListarFoto"
        Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, APPControls.Foto.uscFotografia_2v.enmFotoPerfil.Frontal)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub

        'Private Sub ListarInternoFotov(ByVal InternoID As Integer)

        '    If InternoID < 1 Then
        '        Exit Sub
        '    End If

        '    If Me.UscFotografia2._CheckImagen = False Then
        '        Me.UscFotografia2._Limpiar()
        '        Exit Sub
        '    End If

        '    Dim objBssFoto As New Bussines.Registro.InternoFoto
        '    Dim objEnt As New Entity.Registro.InternoFoto
        '    Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente(InternoID)

        '    Dim intImagen As Integer = -1
        '    Dim intNombreImagen As String = ""
        '    Dim strNomImg As String = ""
        '    objBssFoto = New Bussines.Registro.InternoFoto
        '    objEnt = objBssFoto.Listar(intCodigo)

        '    If objEnt.Codigo > 0 Then

        '        With objEnt
        '            intImagen = .PFrenteID
        '            intNombreImagen = .PFrenteName
        '            strNomImg = .PFrenteServerPath
        '        End With

        '        Me.UscFotografia2._ShowFotoInterno(intImagen, intNombreImagen, strNomImg)
        '    Else
        '        Me.UscFotografia2._Limpiar()
        '    End If

        'End Sub
        'Private Sub ListarInternoFotov5(ByVal InternoID As Integer)

        '    If InternoID < 1 Then
        '        Exit Sub
        '    End If

        '    If Me.UscFotografia_2v1._CheckImagen = False Then
        '        Me.UscFotografia_2v1._Limpiar()
        '        Exit Sub
        '    End If

        '    Dim objBssFoto As New Bussines.Registro.InternoFoto
        '    Dim objEnt As New Entity.Registro.InternoFoto
        '    Dim intCodigo As Integer = objBssFoto.ListarIDFotoReciente2(InternoID)
        '    Dim intImagen As Integer = -1

        '    objBssFoto = New Bussines.Registro.InternoFoto
        '    objEnt = objBssFoto.ListarGrilla(intCodigo)

        '    If objEnt.Codigo > 0 Then

        '        With objEnt
        '            intImagen = .PFrenteID
        '        End With

        '        Me.UscFotografia_2v1._ShowFotoInterno(intImagen)
        '    Else
        '        Me.UscFotografia_2v1._Limpiar()
        '    End If

        'End Sub
        'Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

        '    Dim blnVersion5 As Boolean = Bussines.General.Penal.Version5(Me._PenalID)

        '    If blnVersion5 = True Then
        '        ListarInternoFotov5(InternoID)
        '        Me.UscFotografia_2v1.BringToFront()
        '    Else
        '        ListarInternoFotov(InternoID)
        '        Me.UscFotografia2.BringToFront()

        '    End If

        'End Sub
#End Region
#Region "Grabar"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            '/*Primer apellido*/
            If Me.Paterno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Primer Apellido del Interno")
                Me.txtApePat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*apellido materno*/
            If Me.Materno.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el Segundo Apellido del Interno")
                Me.txtApeMat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*nombres*/
            If Me.Nombres.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los nombres del Interno")
                Me.txtNom.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*fecha nacimiento*/
            If Me.chkOmitirFecha.Checked = False Then

                If Me.FechaNacimiento < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de nacimiento del Interno")
                    Me.dtpFechaNac.Focus()
                    blnValue = False
                    Return blnValue
                End If

                '/*fecha nacimiento>18 */
                If Me.FechaNacimiento > 0 Then
                    Dim dteFechaNac As Date = Me.dtpFechaNac.Value
                    Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, _
                                                         Legolas.Configuration.Aplication.FechayHora.FechaDate)

                    If dteFechaNac >= dteFechaMay18 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de nacimiento, debe superar los 18 años")
                        Me.dtpFechaNac.Focus()
                        blnValue = False
                        Return blnValue
                    End If
                End If
            End If

            '/*sexo*/
            If Me.Sexo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el sexo del interno")
                Me.cbbSexo.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*nacionalidad*/
            If Me.NacionalidadID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la nacionalidad del interno")
                Me.cbbNacionalidad.Focus()
                blnValue = False
                Return blnValue
            End If

            'dni
            If Me.TipoDocumento = 10 Then 'dni
                If Me.NumeroDocumento.Length <> 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese un numero de D.N.I valido")
                    Me.txtNumDoc.Focus()
                    blnValue = False
                    Return blnValue
                End If
            End If

            Return blnValue

        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1

            objBss = New Bussines.Visita.Interno

            Me.Paterno = Legolas.Components.Cadena.LimpiarEspacios(Me.Paterno)
            Me.Materno = Legolas.Components.Cadena.LimpiarEspacios(Me.Materno)
            Me.Nombres = Legolas.Components.Cadena.LimpiarEspacios(Me.Nombres)

            objEnt = New Entity.Visita.Interno

            With objEnt
                .Codigo = Me._InternoID
                .CodigoRP = Me.CodigoInterno
                .TipoDocumentoID = Me.TipoDocumento
                .NumeroDocumento = Me.NumeroDocumento
                .ApellidoPaterno = Me.Paterno
                .ApellidoMaterno = Me.Materno
                .Nombres = Me.Nombres
                .SexoID = Me.Sexo
                .FechaNacimiento = Me.FechaNacimiento
                .NacionalidadID = Me.NacionalidadID
                .PabellonID = Me.PabellonID                
                .EstadoID = Me.EstadoID
                .Obs = Me.Obs
                .IDRegion = Me._RegionID
                .IDPenal = Me._PenalID
            End With

            value = objBss.Grabar2(objEnt)

            If value > 0 Then              
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
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

            If Me._InternoID < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "Antes de ingresar una sancion, grabe los datos del interno")
                Exit Sub
            End If

            Dim frm As New Visita.Interno.frmSancionPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._InternoID = Me._InternoID
                ._InternoApellidosyNombres = Me.ApellidosyNombres
                ._VisibleGrabar = Me._FormEscritura

                If Nuevo = True Then
                    .Codigo = -1
                Else
                    .Codigo = SancionID
                End If

                If .ShowDialog = DialogResult.OK Then
                    Me.UscSancion1._LoadUsc()
                End If

            End With
        End Sub
#End Region
#Region "Otros"
        Private Sub HabilitarControles()

            RegimenTipo_Permisos()

            Dim blnMostrarEtapa As Boolean = False
            'Dim blnMostrarPabellon As Boolean = False
            Dim blnEliminarTab As Boolean = False

            Select Case Me.RegimenVisitaID
                Case 2, 3
                    blnMostrarEtapa = True
                    blnEliminarTab = False
                Case Else
                    blnEliminarTab = True
            End Select

            'blnMostrarPabellon = Me.SolicitarInfoPabellon

            If blnEliminarTab = True Then
                If Me.SolicitarAutoRegOrdinario = False Then
                    blnEliminarTab = True
                Else
                    blnEliminarTab = False
                End If
            End If

            If blnEliminarTab = True Then
                Me.TabControl1.TabPages.Remove(Me.tpAutorizacion)
            End If

            Me.lblEtapa.Visible = blnMostrarEtapa
            Me.txtEtapa.Visible = blnMostrarEtapa

            'Me.lblPabellon.Visible = blnMostrarPabellon
            'Me.cbbPabellon.Visible = blnMostrarPabellon

        End Sub
        Private Sub ValoresxDefault()

            Usuario_Permisos()
            Me.WindowState = FormWindowState.Maximized

            Combo()
            'ComboPabellon()

            If Me._InternoID > 0 Then
                Listar(Me._InternoID)
            Else
                'nuevo
                Me.NacionalidadID = 141 'peru
            End If

        End Sub
        Private Sub Usuario_Permisos()

            Select Case Legolas.LBusiness.Globall.WinApp.LicenciaApp
                Case 1 'sede central

                    If Me._FormEscritura = True Then
                        If Legolas.Configuration.Usuario.OficinaID = Type.Enumeracion.Usuario.EnumDependencia.SistemasInformacion Then
                            Me._FormEscritura = Me._FormEscritura
                        Else
                            Me._FormEscritura = False
                        End If
                    End If

            End Select

        End Sub
        Private Sub HabilitarNumeroDocumento()

            'cantidad de caracteres
            Select Case Me.TipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.LE
                    Me.txtNumDoc.MaxLength = 8
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    Me.txtNumDoc.MaxLength = 8
                Case Else
                    Me.txtNumDoc.MaxLength = 20
            End Select

            Select Case Me.TipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.CE, _
                    Type.Enumeracion.enmTipoDocumento.PAS, _
                    Type.Enumeracion.enmTipoDocumento.PN, _
                    Type.Enumeracion.enmTipoDocumento.CC

                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Normal

                Case Else

                    Me.txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros

            End Select

        End Sub
#End Region
        Private Sub frmInternoLite_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

            HabilitarControles()
            ValoresxDefault()

        End Sub

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

            AGrabar()

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click

            Me.Close()

        End Sub

        Private Sub UscSancion1__CellDoubleClick_Grilla(ByVal SancionID As Integer) Handles UscSancion1._CellDoubleClick_Grilla

            FRM_SancionMant(False, SancionID)

        End Sub

        Private Sub UscSancion1__Click_Agregar() Handles UscSancion1._Click_Agregar

            FRM_SancionMant(True, -1)

        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name
                Case Me.tp_visita.Name
                    ListarUscVisitaMovimiento()
                Case Me.tp_Sancion.Name
                    ListarUscSancion()
                Case Me.tpAutorizacion.Name
                    ListarUscAutorizacion()
            End Select
        End Sub


        Private Sub chkOmitirFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOmitirFecha.Click

            Me.dtpFechaNac.Enabled = Not Me.chkOmitirFecha.Checked

        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged

            If blnCargoTipoDoc = True Then

                Me.NumeroDocumento = ""
                Me.txtNumDoc.Focus()

                If Me.TipoDocumento > 0 Then
                    HabilitarNumeroDocumento()
                End If

            End If

        End Sub

        Private Sub cbbTipoDoc_Load(sender As System.Object, e As System.EventArgs) Handles cbbTipoDoc.Load

        End Sub
    End Class

End Namespace
