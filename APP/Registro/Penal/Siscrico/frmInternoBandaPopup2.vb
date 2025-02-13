Namespace Registro.Siscrico
    Public Class frmInternoBandaPopup2
#Region "propiedades"
        Public Property _InternoBandId() As Integer = -1
        Public Property _BandaTipoNombre() As String
            Get
                Return txtTipBand.Text
            End Get
            Set(value As String)
                txtTipBand.Text = value
            End Set
        End Property
        Public Property _BandaTipoId() As Integer
            Get
                Return txtTipBand.Tag
            End Get
            Set(value As Integer)
                txtTipBand.Tag = value
            End Set
        End Property
        Public Property _BandaNombre() As String
            Get
                Return txtNomBand.Text
            End Get
            Set(value As String)
                If Trim(value) = "" Then
                    txtNomBand.Text = "[SELECCIONE]"
                Else
                    txtNomBand.Text = value
                End If

            End Set
        End Property
        Public Property _BandaId() As Integer
            Get
                Return txtNomBand.Tag
            End Get
            Set(value As Integer)
                txtNomBand.Tag = value
            End Set
        End Property
        Public Property _EstadoIntegrante() As String
            Get
                Return txtEstIntegrante.Text
            End Get
            Set(value As String)
                txtEstIntegrante.Text = value
            End Set
        End Property
        Private Property _CreaDocumentoJudicialID() As Integer = -1
        Private Property _AnulaDocumentoJudicialID() As Integer = -1
        '  Private intTipoMiembroBandaId As Integer = -1
        Private Property _TipoMiembroBandaId() As Integer
            Get
                Return cbbBandaMiembroTipo.SelectedValue
            End Get
            Set(value As Integer)
                'intTipoMiembroBandaId = value
                cbbBandaMiembroTipo.SelectedValue = value
            End Set
        End Property
        Private Property _ObvsIntBand As String
            Get
                Return txtobservacion.Text
            End Get
            Set(value As String)
                txtobservacion.Text = value
            End Set
        End Property
        Private Property _RegionID() As Integer
            Get
                Return cbbRegion.SelectedValue
            End Get
            Set(value As Integer)
                cbbRegion.SelectedValue = value
            End Set
        End Property
        Private Property _PenalID() As Integer
            Get
                Return cbbPenal.SelectedValue
            End Get
            Set(value As Integer)
                cbbPenal.SelectedValue = value
            End Set
        End Property

        'interno
        Private Property _InternoId() As Integer
            Get
                Return Val(txtCodInterno.Tag)
            End Get
            Set(value As Integer)
                txtCodInterno.Tag = value
            End Set
        End Property
        Private Property _InternoCodigo() As String
            Get
                Return txtCodInterno.Text
            End Get
            Set(value As String)
                txtCodInterno.Text = value
            End Set
        End Property
        Private Property _InternoEstado() As String
            Get
                Return txtEst.Text
            End Get
            Set(value As String)
                txtEst.Text = UCase(value)
            End Set
        End Property
        Private Property _InternoApeNom() As String
            Get
                Return txtApeNomInterno.Text
            End Get
            Set(value As String)
                txtApeNomInterno.Text = UCase(value)
            End Set
        End Property
        Private Property _InternoNombres() As String = ""
        Private Property _InternoApePat() As String = ""
        Private Property _InternoApeMat() As String = ""


        Private Property _InternoDocIdent() As String
            Get
                Return txtDocIdent.Text
            End Get
            Set(value As String)
                txtDocIdent.Text = UCase(value)
            End Set
        End Property
        Public ReadOnly Property _IngresoId() As Integer
            Get
                Try
                    Return Me.cbbNroIngresos.SelectedValue
                Catch ex As Exception
                    Return -1
                End Try
            End Get
        End Property
        Public ReadOnly Property _IngresoNro() As Integer
            Get
                Return Integer.Parse(Me.cbbNroIngresos.Text)
            End Get
        End Property
#End Region
#Region "Combo"

        Private Sub CargarComboTipoMiembroBanda()
            cbbBandaMiembroTipo.LoadUsc()
            If Me._InternoBandId < 1 Then
                Me._TipoMiembroBandaId = -1
            End If
        End Sub

        Private Sub CargarComboRegion()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1, 2
                    blnTodos = False
                Case 3
                    blnTodos = True
            End Select

            With Me.cbbRegion
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.RegionUsuario
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Private Sub CargarComboPenal()

            Dim blnTodos As Boolean = False

            Select Case Legolas.Configuration.Usuario.NivelUsuario
                Case 1
                    blnTodos = False
                Case 2, 3
                    blnTodos = True
            End Select

            With Me.cbbPenal
                ._Todos = False 'blnTodos
                .ComboTipo = Type.Combo.ComboTipo.PenalUsuario
                .CodigoPadre = Me._RegionID
                .Parametro1 = Legolas.Configuration.Usuario.Codigo
                .Parametro2 = Configuracion.Licencia.Codigo
                .LoadUsc()
            End With

        End Sub
        Public Sub ComboNumIngreso()

            Dim objBssIng As Bussines.Registro.Ingreso = New Bussines.Registro.Ingreso
            Dim objEntCol2 As New Entity.Registro.IngresoCol

            'VERSON 5
            objEntCol2 = objBssIng.ListarNroIngreso(Me._InternoId, Me._PenalID)

            With Me.cbbNroIngresos
                .DataSource = objEntCol2
                .DisplayMember = "IngresoNro"
                .ValueMember = "Codigo"
            End With
        End Sub
#End Region
#Region "Accion"
        Private Sub Grabar()

            'validar pendiente
            If Validar() = False Then
                Exit Sub
            End If

            Dim objBss As New Bussines.Registro.InternoOrgCriminal
            Dim objEnt As New Entity.Registro.InternoOrgCriminal
            If Me._InternoBandId > 0 Then
                objEnt = objBss.Listar(Me._InternoBandId)
            End If
            objEnt.Codigo = Me._InternoBandId
            objEnt.InternoID = Me._InternoId
            objEnt.BandaTipoID = Me._BandaTipoId
            objEnt.BandaID = Me._BandaId
            objEnt.BandaNombre = txtNomBand.Text
            objEnt.BandaMiembroTipoID = Me._TipoMiembroBandaId
            objEnt.Observacion = Me._ObvsIntBand
            objEnt.ApePatInterno = Me._InternoApePat
            objEnt.ApeMatInterno = Me._InternoApeMat
            objEnt.NombresInterno = Me._InternoNombres
            objEnt.IngresoID = Me._IngresoId
            objEnt.PenalID = Me._PenalID
            objEnt.RegioID = Me._RegionID
            If objBss.ValidarInterno(objEnt) = False Then
                MessageBox.Show("El interno ya pertenece a esta banda", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, _
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Me._InternoBandId < 1 Then 'nuevo

                With uscDocJudCrea
                    uscDocJudCrea._InternoID = Me._InternoId
                    uscDocJudCrea._IngresoID = Me._IngresoId
                    'uscDocJudCrea._IngresoID=
                    Me._CreaDocumentoJudicialID = ._GuardarDocJud
                End With

                If Me._CreaDocumentoJudicialID > 0 Then
                    objEnt.Estado = 1 '--ACTIVO
                    objEnt.DocJudicialID_Crea = Me._CreaDocumentoJudicialID
                    If objBss.Grabar2(objEnt) > 0 Then
                        Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                        Me.Close()
                    End If
                Else
                    Exit Sub
                End If

            Else 'editar

                uscDocJudCrea._DocumentoJudicialID = objEnt.DocJudicialID_Crea
                uscDocJudCrea._InternoID = Me._InternoId
                uscDocJudCrea._IngresoID = Me._IngresoId
                If uscDocJudCrea._GuardarDocJud() = -1 Then
                    Exit Sub
                End If

                If objEnt.DocJudicialID_Anula() > 0 Then
                    uscDocJudAnula._InternoID = Me._InternoId
                    uscDocJudAnula._IngresoID = Me._IngresoId
                    uscDocJudAnula._DocumentoJudicialID = objEnt.DocJudicialID_Anula
                    Me._AnulaDocumentoJudicialID = uscDocJudAnula._GuardarDocJud
                End If

                If objBss.Grabar2(objEnt) >= 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationOperacion()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("Error al actualizar", _
                     Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

        End Sub
#End Region
#Region "Otros"
        Private Function Validar() As Boolean
            If Me._RegionID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione región")
                ' Me.cbbRegionXXXXXXXXX.Focus()
                Return False
            End If

            If Me._PenalID = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione Penal")
                ' Me.cbbPenalXXXXXXXXX.Focus()
                Return False
            End If

            If Trim(txtCodInterno.Text) = "[SELECCIONE]" Or Trim(txtCodInterno.Text) = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Debe cargar los datos del interno")
                ' Me.cbbPenalXXXXXXXXX.Focus()
                Return False
            End If

            If Me._TipoMiembroBandaId = -1 Or Trim(cbbBandaMiembroTipo.Text) = "" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione el tipo de integrante de banda")
                Me.cbbBandaMiembroTipo.Focus()
                Return False
            End If
            If Me._BandaNombre = "" Or Me._BandaNombre = "[SELECCIONE]" Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione la organización criminal")
                btnLoadGrupCrim.Select()
                Return False
            End If
            If Me._IngresoId = -1 Then
                Legolas.Configuration.Aplication.MessageBox.Exclamation("Seleccione un número de ingreso del interno válido")
                cbbNroIngresos.Select()
                Return False
            End If
            Return True
        End Function
        Private Sub ValoresxDefault()

            CargarComboTipoMiembroBanda()
            CargarComboRegion()
            CargarComboPenal()

            If Me._InternoBandId <> -1 Then
                btnCargarInterno.Visible = False
                cbbRegion.Enabled = False
                cbbPenal.Enabled = False
            Else
                tpDocNulidad.Parent = Nothing 'ocultar ficha si es nuevo
            End If

            Me.uscDocJudCrea._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
            Me.uscDocJudCrea._RegionID = Me._RegionID
            Me.uscDocJudCrea._Penal = Me._PenalID
            'Me.uscDocJudCrea._InternoID = Me._InternoId
            Me.uscDocJudCrea._LoadValorxDefault()

            Me.uscDocJudAnula._TipoDocumentoJudicial = Type.Enumeracion.TipoDocJudicial.enumTipoDocumentoJudicial.Siscrico
            Me.uscDocJudAnula._RegionID = Me._RegionID
            Me.uscDocJudAnula._Penal = Me._PenalID
            'Me.uscDocJudAnula._InternoID = Me._InternoId
            Me.uscDocJudAnula._LoadValorxDefault()

            Listar()
            If Trim(txtNomBand.Text) = "[SELECCIONE]" Then
                btnLoadGrupCrim.Visible = True
            Else
                btnLoadGrupCrim.Visible = False
            End If
        End Sub
        Private Sub CargarDatosInterno()
            Dim frm As New Registro.Busqueda.frmInternoPopup
            With frm
                ._RegionID = Me._RegionID
                ._PenalID = Me._PenalID
                ._VisibleRegionPenal = False                
                If .ShowDialog() = DialogResult.OK Then

                    Dim intIDInterno As Integer = -1
                    Dim objBssInterno As New Bussines.Registro.Interno
                    Dim objInt As New Entity.Registro.Interno

                    intIDInterno = ._GrillaInternoID

                    objInt = objBssInterno.Listar_v5(intIDInterno)
                    Me._InternoId = intIDInterno

                    Me._InternoApeNom = objInt.ApellidoPaterno & " " & objInt.ApellidoMaterno & ", " & objInt.Nombres
                    Me._InternoNombres = objInt.ApellidoMaterno
                    Me._InternoApePat = objInt.ApellidoPaterno
                    Me._InternoApeMat = objInt.Nombres
                    Me._InternoDocIdent = objInt.TipoDocumentoyNumeroDocumento
                    Me._InternoEstado = objInt.EstadoNombre
                    Me._InternoCodigo = objInt.CodigoRP
                    ComboNumIngreso()
                End If
            End With
        End Sub
        Private Sub Listar()
            If Me._InternoBandId < 1 Then
                Exit Sub
            End If
            Dim objEntColAlias As New Entity.Registro.InternoOrgCriminal
            Dim objBssColFam As New Bussines.Registro.InternoOrgCriminal
            objEntColAlias = objBssColFam.Listar(Me._InternoBandId)
            With objBssColFam
                'carga datos de interno
                Dim objBssInterno As New Bussines.Registro.Interno
                Dim objInt As New Entity.Registro.Interno
                objInt = objBssInterno.Listar_v5(objEntColAlias.InternoID)
                Me._InternoId = objEntColAlias.InternoID
                Me._InternoApeNom = objInt.ApellidoPaterno & " " & objInt.ApellidoMaterno & ", " & objInt.Nombres
                Me._InternoApeMat = objInt.ApellidoMaterno
                Me._InternoApePat = objInt.ApellidoPaterno
                Me._InternoNombres = objInt.Nombres
                Me._InternoDocIdent = objInt.TipoDocumentoyNumeroDocumento
                Me._InternoEstado = objInt.EstadoNombre
                Me._InternoCodigo = objInt.CodigoRP

                '-----------
                uscDocJudCrea._DocumentoJudicialID = objEntColAlias.DocJudicialID_Crea
                uscDocJudAnula._DocumentoJudicialID = objEntColAlias.DocJudicialID_Anula


                Me._CreaDocumentoJudicialID = objEntColAlias.DocJudicialID_Crea
                uscDocJudCrea._ListarDocJudicial()

                If objEntColAlias.DocJudicialID_Anula > 0 Then
                    tpDocNulidad.Parent = TabControl1
                    Me._AnulaDocumentoJudicialID = objEntColAlias.DocJudicialID_Anula
                    uscDocJudAnula._DocumentoJudicialID = objEntColAlias.DocJudicialID_Anula
                    uscDocJudAnula._ListarDocJudicial()
                Else
                    tpDocNulidad.Parent = Nothing
                End If
                Me._TipoMiembroBandaId = objEntColAlias.BandaMiembroTipoID
                Me._ObvsIntBand = objEntColAlias.Observacion

                Me._RegionID = objEntColAlias.RegioID
                Me._PenalID = objEntColAlias.PenalID
                ComboNumIngreso()
            End With
        End Sub
        Private Sub UsuarioPermisos()
            Me.btnGrabar.Visible = Me._FormEscritura
        End Sub
#End Region
        Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
            Me.Close()
        End Sub

        Private Sub frmInternoBandaPopup2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            ValoresxDefault()
            UsuarioPermisos()
        End Sub

        Private Sub btnCargarInterno_Click(sender As System.Object, e As System.EventArgs) Handles btnCargarInterno.Click
            If Me._RegionID < 1 Then
                MessageBox.Show("Seleccione la región", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbRegion.Focus()
                Exit Sub
            End If
            If Me._PenalID < 1 Then
                MessageBox.Show("Seleccione el penal", _
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbPenal.Focus()
                Exit Sub
            End If
            CargarDatosInterno()
        End Sub

        Private Sub btnGrabar_Click(sender As System.Object, e As System.EventArgs) Handles btnGrabar.Click
            Grabar()
        End Sub

        Private Sub btnLoadGrupCrim_Click(sender As System.Object, e As System.EventArgs) Handles btnLoadGrupCrim.Click

            Dim f As New Registro.Siscrico.frmBusquedaBanda
            With f
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me._BandaId = ._BandaIdSel
                    Me._BandaNombre = ._BandaNomSel()
                    Me._BandaTipoNombre = ._BandaTipNomSel
                End If
            End With
        End Sub

        Private Sub cbbRegion__SelectedIndexChanged() Handles cbbRegion._SelectedIndexChanged
            CargarComboPenal()
        End Sub


    End Class
End Namespace