Namespace Visita.InternoPJ
    Public Class frmMant
        Private objBss As Bussines.Visita.InternoPJ = Nothing
        Private objEnt As Entity.Visita.InternoPJ = Nothing
#Region "Propiedades_Parametricas"        
        Public Property _IDPenal() As Integer
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
        Public Property _IDRegion() As Integer
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
        Public Property _IDInternoPJ() As Integer = -1
        Private idDocumentoControl As Integer = -1
#End Region
#Region "Propiedades"
        Private Property PrimerApellido() As String
            Get
                Return Me.txtApePat.Text
            End Get
            Set(ByVal value As String)
                Me.txtApePat.Text = value
            End Set
        End Property
        Private Property SegundoApellido() As String
            Get
                Return Me.txtApeMat.Text
            End Get
            Set(ByVal value As String)
                Me.txtApeMat.Text = value
            End Set
        End Property
        Private Property PreNombres() As String
            Get
                Return Me.txtNom.Text
            End Get
            Set(ByVal value As String)
                Me.txtNom.Text = value
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
        Private Property IDPabellonID() As Integer
            Get
                Return Me.cbbPabellon._SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbPabellon._SelectedValue = value
            End Set
        End Property
        Private Property IDNacionalidad() As Integer
            Get
                Return Me.cbbNacionalidad.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbNacionalidad.SelectedValue = value
            End Set
        End Property
        Private Property FechaIngreso() As Long
            Get
                Return Me.dtpFechaIng.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaIng.ValueLong = value
            End Set
        End Property
        Private Property FechaEgreso() As Long
            Get
                Return Me.dtpFechaEgre.ValueLong
            End Get
            Set(ByVal value As Long)
                Me.dtpFechaEgre.ValueLong = value
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
        Private Sub Combo()

            'cargar combos                        
            Me.cbbNacionalidad.LoadUsc()
            Me.cbbSexo.LoadUsc()
            Me.cbbTipoDoc.LoadUsc()
            Me.cbbTipoDoc.SelectedValue = Type.Enumeracion.enmTipoDocumento.DNI
        End Sub
        Private Sub ComboPabellon()

            With Me.cbbPabellon
                ._RegionID = Me._IDRegion
                ._PenalID = Me._IDPenal
                ._Ninguno = True
                ._LoadUsc()
            End With

        End Sub
#End Region
#Region "Listar"
        Public Sub Listar(ByVal Codigo As Integer)

            If Codigo < 1 Then
                Exit Sub
            End If

            objBss = New Bussines.Visita.InternoPJ
            objEnt = New Entity.Visita.InternoPJ

            objEnt = objBss.Listar(Codigo)

            With objEnt
                Me.PrimerApellido = .PrimerApellido
                Me.SegundoApellido = .SegundoApellido
                Me.PreNombres = .PreNombres
                Me.Sexo = .Sexo
                Me.FechaNacimiento = .FechaNacimiento
                Me.TipoDocumento = .IDTipoDocumento
                Me.NumeroDocumento = .NumeroDocumento
                Me.FechaIngreso = .FechaIngreso
                Me.FechaEgreso = .FechaEgreso
                Me.IDPabellonID = .IDPabellon
                Me.IDNacionalidad = .IDNacionalidad
                Me.Obs = .Observacion
                Me.EstadoID = .Estado
                Me._IDRegion = .IDRegion
                Me._RegionNombre = .RegionNombre
                Me._IDPenal = .IDPenal
                Me._PenalNombre = .PenalNombre
            End With

            ListarUscVisitaMovimiento()

        End Sub

        Private Sub ListarUscVisitaMovimiento()

            If Me._IDInternoPJ < 1 Then
                Exit Sub
            End If

            With Me.UscMovimientosVisitas1
                ._TipoBusqueda = APPControls.Visita.uscMovimientosVisitas.enmTipo.InternoPJ
                ._IDInternoPJ = Me._IDInternoPJ  'internoid
                ._RegionID = Me._IDRegion
                ._PenalID = Me._IDPenal
                ._VisiblePanelFiltro = True
                ._VisiblePanelCount = True
                ._VisibleCountVisitante = True
                ._LoadUsc()
            End With

        End Sub

#End Region

#Region "Grabar"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = True

            '/*Primer apellido*/
            If Me.PrimerApellido.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el primer apellido")
                Me.txtApePat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*segundo apellido*/
            If Me.SegundoApellido.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese el segundo apellido")
                Me.txtApeMat.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*nombres*/
            If Me.PreNombres.Trim.Length < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese los prenombres")
                Me.txtNom.Focus()
                blnValue = False
                Return blnValue
            End If

            '/*fecha nacimiento*/
            If Me.chkOmitirFecha.Checked = False Then
                If Me.FechaNacimiento < 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("Ingrese fecha de nacimiento")
                    Me.dtpFechaNac.Focus()
                    blnValue = False
                    Return blnValue
                End If
                '/*fecha nacimiento>18 */
                'If Me.FechaNacimiento > 0 Then
                '    Dim dteFechaNac As Date = Me.dtpFechaNac.Value
                '    Dim dteFechaMay18 As Date = DateAdd(DateInterval.Year, -18, _
                '                                         Legolas.Configuration.Aplication.FechayHora.FechaDate)
                '    If dteFechaNac <= dteFechaMay18 Then
                '        Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de nacimiento, debe ser menor a los 18 años")
                '        Me.dtpFechaNac.Focus()
                '        blnValue = False
                '        Return blnValue
                '    End If
                'End If
            Else
                Me.FechaNacimiento = 0
            End If

            '/*sexo*/
            If Me.Sexo < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el sexo")
                Me.cbbSexo.Focus()
                blnValue = False
                Return blnValue
            End If
            If Me.TipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI Then
                If (Me.NumeroDocumento).Length < 8 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation("El Nº de DNI es incorrecto")
                    Me.txtNumDoc.Focus()
                    blnValue = False
                    Return blnValue
                End If
            End If

            '/*nacionalidad*/
            If Me.IDNacionalidad < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la nacionalidad")
                Me.cbbNacionalidad.Focus()
                blnValue = False
                Return blnValue
            End If
            'If Me.FechaIngreso > Me.FechaEgreso Then
            '    Legolas.Configuration.Aplication.MessageBox.Exclamation("La fecha de ingreso no puede ser mayor que la fecha de egreso")
            '    Me.dtpFechaIng.Focus()
            '    blnValue = False
            '    Return blnValue
            'End If
            Return blnValue

        End Function
        Private Sub AGrabar()

            If Validar() = False Then
                Exit Sub
            End If

            Dim value As Integer = -1

            objBss = New Bussines.Visita.InternoPJ

            Me.PrimerApellido = Legolas.Components.Cadena.LimpiarEspacios(Me.PrimerApellido)
            Me.SegundoApellido = Legolas.Components.Cadena.LimpiarEspacios(Me.SegundoApellido)
            Me.PreNombres = Legolas.Components.Cadena.LimpiarEspacios(Me.PreNombres)
            Dim internoID As Integer = -1
            objEnt = New Entity.Visita.InternoPJ

            With objEnt
                .Codigo = Me._IDInternoPJ
                .IDTipoDocumento = Me.TipoDocumento
                .NumeroDocumento = Me.NumeroDocumento
                .PrimerApellido = Me.PrimerApellido
                .SegundoApellido = Me.SegundoApellido
                .PreNombres = Me.PreNombres
                .Sexo = Me.Sexo
                .FechaNacimiento = Me.FechaNacimiento
                If .FechaNacimiento = 0 Then
                    Me.chkOmitirFecha.Checked = True
                End If
                .IDNacionalidad = Me.IDNacionalidad
                .IDPabellon = Me.IDPabellonID
                .Estado = Me.EstadoID
                .Observacion = Me.Obs
                .FechaIngreso = Me.FechaIngreso
                .FechaEgreso = Me.FechaEgreso
                .IDRegion = Me._IDRegion
                .IDPenal = Me._IDPenal
            End With

            value = objBss.Grabar(objEnt)

            If value > 0 Then
                Me._IDInternoPJ = value
                ListarUscVisitaMovimiento()
            End If
            internoID = value

            If internoID > 0 Then
                Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If

        End Sub
#End Region

#Region "Otros"

        Private Sub ValoresxDefault()

            'Usuario_Permisos()
            Me.WindowState = FormWindowState.Maximized

            Combo()
            ComboPabellon()

        End Sub
        Private Sub Usuario_Permisos()

            Me.pnlEliminar.Visible = Me._FormEliminar
            Me.pnlGrabar.Visible = Me._FormEscritura

        End Sub

        Private Sub AEliminarInterno()

            If Me._IDInternoPJ < 1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Antes de eliminar el registro, grabe los datos basicos del interno")
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionEliminar() = Windows.Forms.DialogResult.Yes Then

                Dim objBss As New Bussines.Visita.InternoPJ
                Dim Value As Integer = -1

                Value = objBss.Eliminar(_IDInternoPJ, _IDRegion, _IDPenal)

                If Value > 0 Then
                    Me.Close()
                End If

            End If

        End Sub
#End Region

        Private Sub btnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrabar.Click

            AGrabar()
            Visita.InternoPJ.frmBuscar.Refresh()

        End Sub

        Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
            Dim frm As New Visita.InternoPJ.frmBuscar
            frm.Buscar()
            frm.Refresh()
            Me.Close()
        End Sub

        Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged

            Select Case Me.TabControl1.SelectedTab.Name
                Case Me.tp_visita.Name
                    ListarUscVisitaMovimiento()
            End Select

        End Sub


        Private Sub chkOmitirFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOmitirFecha.Click

            Me.dtpFechaNac.Enabled = Not Me.chkOmitirFecha.Checked

        End Sub

        Private Sub frmMant_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
            'Visita.InternoPJ.frmBuscar.Close()
            ' Visita.InternoPJ.frmBuscar.Show()
        End Sub

        Private Sub frmMant_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            ValoresxDefault()

        End Sub

        Private Sub frmMant_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
            txtApePat.Focus()
            If Me._IDInternoPJ > 0 Then
                Listar(Me._IDInternoPJ)
            Else
                'nuevo
                Me.IDNacionalidad = 141 'peru
            End If

        End Sub

        Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
            AEliminarInterno()
        End Sub

        Private Sub txtNumDoc_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtNumDoc.KeyPress
            Select Case Me.TipoDocumento
                Case Type.Enumeracion.enmTipoDocumento.DNI
                    txtNumDoc.MaxLength = 8
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Type.Enumeracion.enmTipoDocumento.LM
                    txtNumDoc.MaxLength = 20
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Numeros
                Case Else
                    txtNumDoc.MaxLength = 20
                    txtNumDoc.TipoTextbox = Legolas.APPUIComponents.MyTextBox.enmTipoTextBox.Alfanumerico
            End Select
        End Sub

        Private Sub txtNumDoc_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNumDoc.TextChanged
            If Me.TipoDocumento = Type.Enumeracion.enmTipoDocumento.DNI Or Me.TipoDocumento = Type.Enumeracion.enmTipoDocumento.LM Then
                Select Case Me.NumeroDocumento
                    Case "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "V", "W", "X", "Y", "Z"
                        Me.NumeroDocumento = ""
                End Select
            End If
        End Sub

        Private Sub cbbTipoDoc__SelectedIndexChanged() Handles cbbTipoDoc._SelectedIndexChanged
            If Me.TipoDocumento <> idDocumentoControl Then
                idDocumentoControl = Me.TipoDocumento
                Me.txtNumDoc.Text = ""
                Me.txtNumDoc.Focus()
            End If
        End Sub

     
        Private Sub chkOmitirFecha_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkOmitirFecha.CheckedChanged

        End Sub

        Private Sub chkOmitirFecha_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles chkOmitirFecha.KeyPress
            If e.KeyChar = ChrW(Keys.Enter) Then
                e.Handled = True
                SendKeys.Send("{TAB}")
            End If
        End Sub
    End Class

End Namespace
