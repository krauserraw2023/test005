Namespace Visita.Movimiento
    Public Class frmVerificacionIngreso
        Private objBssVisitante As Bussines.Visita.Visitante = Nothing
        Private objBssMov As Bussines.Visita.Movimiento = Nothing
#Region "Propiedades"
        Private Property VerDatos As Boolean = False
        Private ReadOnly Property FechaHoy As Long
            Get

                Dim lngFechaHoyLocal As Long = Legolas.Configuration.Aplication.FechayHora.FechaLong
                Dim lngfechaHoyBD As Long = Legolas.LBusiness.Globall.DateTime.FechaServerLong

                Dim value As Long = lngFechaHoyLocal

                If lngFechaHoyLocal <> lngfechaHoyBD Then
                    value = lngfechaHoyBD
                End If

                Return value
            End Get
        End Property
        Private Property FechaHoyString As String
            Get
                Return Me.lblFechaHoy.Text.ToString
            End Get
            Set(value As String)
                Me.lblFechaHoy.Text = value.ToUpper
            End Set
        End Property
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
        Private ReadOnly Property GrillaIDFotoVisitante() As Integer
            Get
                Dim value As Integer = -1
                Try
                    With Me.dgwMenores
                        value = .SelectedRows(0).Cells("col_fot_vis_id").Value
                    End With
                Catch ex As Exception

                End Try
                Return value
            End Get
        End Property

#End Region
#Region "Propiedades_Busqueda"
        Private ReadOnly Property RegionID() As Integer
            Get

                Return Me.UsrRegionPenal1._RegionID
            End Get

        End Property
        Private ReadOnly Property RegionNombre() As String
            Get
                Return Me.UsrRegionPenal1._RegionNombre
            End Get
        End Property
        Private ReadOnly Property PenalID() As Integer
            Get

                Return Me.UsrRegionPenal1._PenalID
            End Get

        End Property
        Private ReadOnly Property PenalNombre() As String
            Get
                Return Me.UsrRegionPenal1._PenalNombre
            End Get
        End Property
        Private Property IDTipoDocumentoBuscar As Integer
            Get
                Return Me.cbbTipoDoc.SelectedValue
            End Get
            Set(value As Integer)
                Me.cbbTipoDoc.SelectedValue = value
            End Set
        End Property
        Private Property BuscarNumeroDocumento As String
            Get
                Return Me.txtBuscarNumDoc.Text.Trim
            End Get
            Set(value As String)
                Me.txtBuscarNumDoc.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Visitante"
        Private Property IDVisitante As Integer = -1
        Private Property VisitanteTipoDoc() As String
            Get
                Return Me.lblTipoDoc.Text
            End Get
            Set(ByVal value As String)
                Me.lblTipoDoc.Text = value
            End Set
        End Property
        Private Property VisitanteNumDoc() As String
            Get
                Return Me.lblNumDoc.Text
            End Get
            Set(ByVal value As String)
                Me.lblNumDoc.Text = value
            End Set
        End Property
        Private Property VisitanteApePaterno() As String
            Get
                Return Me.lblApePat.Text
            End Get
            Set(ByVal value As String)
                Me.lblApePat.Text = value
            End Set
        End Property
        Private Property VisitanteApeMaterno() As String
            Get
                Return Me.lblApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.lblApeMat.Text = value
            End Set
        End Property
        Private Property VisitanteNombres() As String
            Get
                Return Me.lblNom.Text
            End Get
            Set(ByVal value As String)
                Me.lblNom.Text = value
            End Set
        End Property
        Private Property VisitanteNacionalidad() As String
            Get
                Return Me.lblNac.Text
            End Get
            Set(ByVal value As String)
                Me.lblNac.Text = value
            End Set
        End Property
        Private Property VisitanteSexo() As String
            Get
                Return Me.lblSexo.Text
            End Get
            Set(ByVal value As String)
                Me.lblSexo.Text = value
            End Set
        End Property
        Private Property VisitanteEdad() As String
            Get
                Return Me.lblEdad.Text
            End Get
            Set(ByVal value As String)
                Me.lblEdad.Text = value
            End Set
        End Property
        Private Property VisitanteFechaNacimiento() As String
            Get
                Return Me.lblVisFechaNac.Text
            End Get
            Set(ByVal value As String)

                If value.Trim = "" And Me.VerDatos = True Then
                    value = "[N/R]"
                End If

                Me.lblVisFechaNac.Text = value
            End Set
        End Property
        Private Property IDFotoVisitante As Integer = -1
        Private Property VisitanteFoto As String = ""
#End Region
#Region "Propiedades_Interno"
        Private Property IDInterno As Integer = -1
        Private Property InternoTipoDocumento() As String
            Get
                Return Me.lblIntTipoDoc.Text
            End Get
            Set(ByVal value As String)

                If value.Trim = "" And Me.VerDatos = True Then
                    value = "[N/R]"
                End If

                Me.lblIntTipoDoc.Text = value
            End Set
        End Property
        Private Property InternoNumeroDoc() As String
            Get
                Return Me.lblIntNumDoc.Text
            End Get
            Set(ByVal value As String)

                If value.Trim = "" And Me.VerDatos = True Then
                    value = "[N/R]"
                End If

                Me.lblIntNumDoc.Text = value
            End Set
        End Property
        Private Property InternoApePaterno() As String
            Get
                Return Me.lblIntApePat.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntApePat.Text = value
            End Set
        End Property
        Private Property InternoApeMaterno() As String
            Get
                Return Me.lblIntApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntApeMat.Text = value
            End Set
        End Property
        Private Property InternoNombres() As String
            Get
                Return Me.lblIntNom.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntNom.Text = value
            End Set
        End Property
        Private Property InternoNacionalidad() As String
            Get
                Return Me.lblIntNacionalidad.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntNacionalidad.Text = value
            End Set
        End Property
        Private Property InternoFechaNacimiento() As String
            Get
                Return Me.lblInternoFecNac.Text
            End Get
            Set(ByVal value As String)

                If value.Trim = "" And Me.VerDatos = True Then
                    value = "[N/R]"
                End If

                Me.lblInternoFecNac.Text = value
            End Set
        End Property
        Private Property InternoEdad() As String
            Get
                Return Me.lblIntEdad.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntEdad.Text = value
            End Set
        End Property
        Private Property InternoSexo() As String
            Get
                Return Me.lblIntSexo.Text
            End Get
            Set(ByVal value As String)
                Me.lblIntSexo.Text = value
            End Set
        End Property
        Private Property InternoPabellon() As String
            Get
                Return Me.lblIntPabellon.Text
            End Get
            Set(ByVal value As String)

                If value.Trim = "" And Me.VerDatos = True Then
                    value = "[N/R]"
                End If

                Me.lblIntPabellon.Text = value
            End Set
        End Property
        Private Property InternoEtapa() As String
            Get
                Return Me.lblInternoEtapa.Text
            End Get
            Set(ByVal value As String)

                If value.Trim = "" And Me.VerDatos = True Then
                    value = "[N/R]"
                End If
                Me.lblInternoEtapa.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Movimiento"
        Private Property IDMovimiento As Integer = -1
        Private Property CantidadMenores As Short = 0
        Private Property IDMovimientoPadre As Integer = 0
        Private Property IDTipoVisita As Short = -1
        Private Property HoraIngreso() As String
            Get
                Return Me.lblHora.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblHora.Text = value
            End Set
        End Property
        Private Property ParentescoNombre As String
            Get
                Return Me.lblParentesco.Text
            End Get
            Set(value As String)
                Me.lblParentesco.Text = value
            End Set
        End Property
        Private Property HoraVerificacion() As String
            Get
                Return Me.lblHoraVerificacion.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.lblHoraVerificacion.Text = value
            End Set
        End Property
#End Region
#Region "Combo"
        Private Sub ComboRegionPenal()

            With Me.UsrRegionPenal1
                ._TipoCombo = APPControls.usrRegionPenal.enmTipoCombo.Licencia
                ._LicenciaID = Legolas.LBusiness.Globall.WinApp.LicenciaApp
                ._PenalTodos = False
                ._LoadUsc()
            End With

        End Sub
        Private Sub ComboDocumentoTipo()

            '/*tipo documento*/
            With Me.cbbTipoDoc
                .ComboTipo = Type.Combo.ComboTipo.TipoDoc
                .LoadUsc()
            End With

        End Sub
#End Region
#Region "Validar"
        Private Function ValidarNumeroDocumento() As Boolean

            Dim value As Boolean = True

            'validar por tipo documento
            If Me.IDTipoDocumentoBuscar = Type.Enumeracion.enmTipoDocumento.DNI Then 'dni
                If Me.BuscarNumeroDocumento = "" Or Me.BuscarNumeroDocumento.Length < 8 Then
                    Me.BuscarNumeroDocumento = ""
                    Me.txtBuscarNumDoc.Focus()
                    value = False

                End If

            End If

            Return value

        End Function
#End Region
#Region "Listar"
        Private Sub BuscarVisitante()

            If ValidarNumeroDocumento() = False Then
                Exit Sub
            End If

            Dim lngFechaIngreso As Long = Me.FechaHoy
            Dim blnPasaProceso As Boolean = False

            Dim objEntCol As New Entity.Visita.VisitanteCol
            objBssVisitante = New Bussines.Visita.Visitante

            objEntCol = objBssVisitante.ListarxNumeroDocumento(Me.IDTipoDocumentoBuscar, Me.BuscarNumeroDocumento, Me.RegionID, Me.PenalID)

            If objEntCol.Count > 0 Then

                For Each objEnt As Entity.Visita.Visitante In objEntCol
                    'queda
                    If objEnt.PenalID = Me.PenalID Then
                        Me.IDVisitante = objEnt.Codigo
                        blnPasaProceso = True
                        Exit For
                    End If
                Next
            Else
                Me.txtBuscarNumDoc.Text = ""
                Me.txtBuscarNumDoc.Focus()
                Exit Sub
            End If

            If blnPasaProceso = True Then
                blnPasaProceso = False

                Dim blnVisitaAdulto As Boolean = False

                blnVisitaAdulto = ListarMovimiento(-1, Me.IDVisitante, lngFechaIngreso)

                If blnVisitaAdulto = False Then
                    blnVisitaAdulto = ListarMovimiento(Me.IDMovimientoPadre, -1, 0)

                    If blnVisitaAdulto = True Then
                        blnPasaProceso = True
                    End If
                Else
                    blnPasaProceso = True
                End If

            End If

            If blnPasaProceso = True Then

                ListarVisitante()
                ListarInterno()
                ListarMovimientoMenores()

                Me.pnlHora.Visible = True
                Me.btnOk.Focus()
            Else
                ALimpiar()             
                Me.txtBuscarNumDoc.Focus()
            End If

        End Sub
        Private Function ListarMovimiento(IDMovimiento As Integer, IDVisitante As Integer, FechaIngreso As Long) As Boolean

            Dim value As Boolean = False

            objBssMov = New Bussines.Visita.Movimiento
            Dim objEntColMov As New Entity.Visita.MovimientoCol

            objEntColMov = objBssMov.ListarMovimientoFaltaHoraVerificacion(IDMovimiento, IDVisitante, FechaIngreso, _
                             Me.RegionID, Me.PenalID)

            If objEntColMov.Count > 0 Then

                For Each objEnt As Entity.Visita.Movimiento In objEntColMov
                    'queda
                    If objEnt.PenalID = Me.PenalID Then

                        Me.IDMovimiento = objEnt.Codigo
                        Me.IDMovimientoPadre = objEnt.MovimientoPadre
                        Me.IDInterno = objEnt.InternoID
                        Me.IDVisitante = objEnt.VisitaID
                        Me.HoraIngreso = objEnt.HoraIngreso
                        Me.CantidadMenores = objEnt.MenoresCantidad
                        Me.IDTipoVisita = objEnt.TipoID
                        Me.ParentescoNombre = objEnt.ParentescoNombre.ToUpper

                        Select Case Me.IDTipoVisita
                            Case Type.Enumeracion.Visita.TipoVisita.MenorEdad
                                value = False
                            Case Else
                                value = True
                        End Select

                        Exit For
                    End If
                Next

            End If

            Return value

        End Function
        Private Sub ListarVisitante()

            If Me.IDVisitante < 1 Then
                Exit Sub
            End If

            Dim objEnt As Entity.Visita.Visitante = Nothing
            objBssVisitante = New Bussines.Visita.Visitante

            objEnt = objBssVisitante.Listar(Me.IDVisitante)
            VerDatos = False

            With objEnt
                Me.IDVisitante = .Codigo
                Me.VisitanteTipoDoc = .TipoDocumentoNombre
                Me.VisitanteNumDoc = .NumeroDocumento
                Me.VisitanteApePaterno = .ApellidoPaterno
                Me.VisitanteApeMaterno = .ApellidoMaterno
                Me.VisitanteNombres = .Nombres
                Me.VisitanteNacionalidad = .NacionalidadNombre

                Select Case .SexoNombre.ToUpper.Trim
                    Case "M"
                        Me.VisitanteSexo = "MASCULINO"
                    Case "F"
                        Me.VisitanteSexo = "FEMENINO"
                End Select

                Me.VisitanteFechaNacimiento = .FechaNacimientoString
                Me.VisitanteEdad = .Edad.ToString
                Me.IDFotoVisitante = .FotoID
                Me.VisitanteFoto = .FotoName
            End With

            ImagenFotoVisitante(Me.VisitanteFoto)

        End Sub
        Private Sub ListarInterno()

            If Me.IDInterno < 1 Then
                VisibleDatosInterno(False)
                Exit Sub
            End If

            Dim objEnt As New Entity.Visita.Interno
            Dim objBssInterno As New Bussines.Visita.Interno

            objEnt = objBssInterno.Listar2(Me.IDInterno)
            VerDatos = True
            With objEnt
                Me.InternoTipoDocumento = .TipoDocumentoNombre
                Me.InternoNumeroDoc = .NumeroDocumento
                Me.InternoApePaterno = .ApellidoPaterno
                Me.InternoApeMaterno = .ApellidoMaterno
                Me.InternoNombres = .Nombres.ToUpper
                Me.InternoNacionalidad = .Nacionalidad.ToUpper
                Me.InternoSexo = .SexoNombre.ToUpper
                Me.InternoFechaNacimiento = .FechaNacimientoString
                Me.InternoEdad = .Edad
                Me.InternoPabellon = .PabellonNombre.ToUpper
                Me.InternoEtapa = .EtapaNombre.ToUpper
            End With

            VisibleDatosInterno(True)
            ListarInternoFotoVersion(Me.IDInterno)

        End Sub
        Private Sub ImagenFotoVisitante(ByVal FotoNameExtension As String)

            With Me.UscFotografia1
                ._ShowFotoVisitante(FotoNameExtension)
            End With

        End Sub
         Private Sub ListarInternoFotoVersion(ByVal InternoID As Integer)

            If InternoID < 1 Then
                Exit Sub
            End If

            If Me.UscFotografia_2v1._CheckImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
                Exit Sub
            End If

            Me.UscFotografia_2v1._showFotoInternoPrincipal(InternoID, 2)

            If UscFotografia_2v1._HasImagen = False Then
                Me.UscFotografia_2v1._Limpiar()
            End If

        End Sub
        Private Sub ListarMovimientoMenores()

            Me.pnlMenores.Visible = False

            objBssMov = New Bussines.Visita.Movimiento
            Dim objEntColMov As New Entity.Visita.MovimientoCol

            objEntColMov = objBssMov.ListarMovimientoHijos_v2(Me.IDMovimiento)

            With Me.dgwMenores
                .RowsDefaultCellStyle.SelectionForeColor = Color.Black
                .RowsDefaultCellStyle.SelectionBackColor = Configuracion.Aplication.GrillaSelectionBackColor_Visita
                .AutoGenerateColumns = False
                .DataSource = objEntColMov
            End With

            If Me.dgwMenores.RowCount > 0 And Me.CantidadMenores > 0 Then
                Me.pnlMenores.Visible = True
            End If


        End Sub
#Region "Accion"
        Private Sub ALimpiar()

            VerDatos = False
            Me.IDTipoDocumentoBuscar = Type.Enumeracion.enmTipoDocumento.DNI
            Me.BuscarNumeroDocumento = ""

            Me.IDMovimiento = -1
            Me.IDVisitante = -1
            Me.IDInterno = -1
            'visitante
            Me.VisitanteTipoDoc = ""
            Me.VisitanteNumDoc = ""
            Me.VisitanteApePaterno = ""
            Me.VisitanteApeMaterno = ""
            Me.VisitanteNombres = ""
            Me.VisitanteNacionalidad = ""
            Me.VisitanteFechaNacimiento = ""
            Me.VisitanteEdad = ""
            Me.VisitanteSexo = ""
            Me.UscFotografia1._Limpiar()

            'interno
            Me.InternoTipoDocumento = ""
            Me.InternoNumeroDoc = ""
            Me.InternoApePaterno = ""
            Me.InternoApeMaterno = ""
            Me.InternoNombres = ""
            Me.InternoNacionalidad = ""
            Me.InternoFechaNacimiento = ""
            Me.InternoEdad = ""
            Me.InternoSexo = ""
            Me.InternoPabellon = ""
            Me.InternoEtapa = ""
            Me.UscFotografia_2v1._Limpiar()

            'movimiento
            Me.ParentescoNombre = "[Parentesco]"

            VisibleDatosInterno(True)
            Me.pnlMenores.Visible = False
            Me.pnlHora.Visible = False

        End Sub
        Private Function Validar() As Boolean

            Dim value As Boolean = True

            If Me.IDMovimiento < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation( _
                "No se encontro ningun registro de visita")
                Me.txtBuscarNumDoc.Text = ""
                Me.txtBuscarNumDoc.Focus()
                value = False
            End If

            Return value
        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            objBssMov = New Bussines.Visita.Movimiento

            intValue = objBssMov.GrabarFechaHoraVerificacion(Me.IDMovimiento, Me.FechaHoy, Me.HoraVerificacion)

            If intValue > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                ALimpiar()
                Me.txtBuscarNumDoc.Focus()
            End If

        End Sub
#End Region
#Region "Otros"
        Private Sub VisibleDatosInterno(vf)

            Me.pnlDatosInterno.Visible = vf
            Me.pnlTituloVisitaAdmin.Visible = Not vf

            If vf = True Then
                Me.grbDatosInterno.Text = "Datos del Interno"
            Else
                Me.grbDatosInterno.Text = ""
            End If

        End Sub
        Private Sub ValoresxDefault()

            Me.FechaHoyString = Legolas.Components.FechaHora.FechaText(Me.FechaHoy, Legolas.Components.FechaHora.enmFechaLong.enmAll)
            Me.IDTipoDocumentoBuscar = Type.Enumeracion.enmTipoDocumento.DNI

        End Sub
        Private Sub ImagenFotoVisitanteMenor(ByVal FotoName As String)

            With Me.UscFotografia3
                .SizeMode = PictureBoxSizeMode.Zoom
                ._ShowFotoVisitante(FotoName)
            End With

        End Sub

#End Region
#End Region

#Region "Form"
        Private Sub Form_FotoMenor()

            Me.UscFotografia3._Show_FotoAutoSize()

        End Sub
#End Region
        Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click

            AGrabar()

        End Sub

        Private Sub frmVerificacionIngreso2v_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Me.Timer1.Enabled = True
            Me.HoraVerificacion = Legolas.LBusiness.Globall.DateTime.HoraServer

            Me.WindowState = FormWindowState.Maximized
            ComboRegionPenal()
            ComboDocumentoTipo()

        End Sub

        Private Sub frmVerificacionIngreso2v_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()
            Me.txtBuscarNumDoc.Focus()


        End Sub

        Private Sub txtBuscarNumDoc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtBuscarNumDoc.KeyPress

            If e.KeyChar = ChrW(Keys.Enter) Then
                BuscarVisitante()
                Me.btnCancel.Focus()
            End If

        End Sub


        Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click

            BuscarVisitante()

        End Sub

        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click

            Me.Close()

        End Sub

        Private Sub dgwMenores_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellClick

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

        Private Sub dgwMenores_CellEnter(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgwMenores.CellEnter

            If Me.dgwMenores.RowCount > 0 And Me.GrillaIDFotoVisitante > 0 Then
                ImagenFotoVisitanteMenor(Me.GrillaFotoVisitante)
            End If

        End Sub

        Private Sub btnNuevoMov_Click(sender As System.Object, e As System.EventArgs) Handles btnNuevoMov.Click

            ALimpiar()
            Me.txtBuscarNumDoc.Focus()

        End Sub

        Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

            Me.lblHoraVerificacion.Text = CDate(Me.lblHoraVerificacion.Text).AddSeconds(1).ToString("HH:mm:ss")

        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged

            Me.txtBuscarNumDoc.Focus()

        End Sub

        Private Sub btnOk_GotFocus(sender As Object, e As System.EventArgs) Handles btnOk.GotFocus

            If Me.IDMovimiento < 1 Then
                Me.txtBuscarNumDoc.Focus()
            End If

        End Sub
    End Class

End Namespace
