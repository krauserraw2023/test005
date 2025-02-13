Namespace Mantenimiento.Registro.Delito
    Public Class frmMant_v2
        Private objBss As Bussines.Mantenimiento.General.Delito = Nothing
        Private objBssGrupoDelitoDet As Bussines.Mantenimiento.General.Reportecuadro2_Detalle = Nothing
#Region "Propiedades"

        Public Property _Codigo As Integer = -1

        Private Property IDDelitoTipo() As Integer
            Get
                Return Me.cbbTipo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbTipo.SelectedValue = value
            End Set
        End Property
        Private Property IDDelitoGenerico() As Integer
            Get
                Return Me.cbbDelGenerico.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDelGenerico.SelectedValue = value
            End Set
        End Property
        Private Property DelitoGenericoCodigo() As String
            Get
                Return Me.txtDelGenCod.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelGenCod.Text = value
            End Set
        End Property

        Private Property IDDelitoCapitulo As Integer
            Get
                Return Me.cbbDelCapitulo.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDelCapitulo.SelectedValue = value
            End Set
        End Property
        Private Property DelitoCapituloCodigo() As String
            Get
                Return Me.txtDelGenCap.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelGenCap.Text = value
            End Set
        End Property

        Private Property IDDelitoSeccion() As Integer
            Get
                Return Me.cbbDelSeccion.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDelSeccion.SelectedValue = value
            End Set
        End Property
        Private Property DelitoSeccionCodigo() As String
            Get
                Return Me.txtDelGenSecc.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelGenSecc.Text = value
            End Set
        End Property

        Private Property IDDelitoEspecificoPadre() As Integer
            Get
                Return Me.cbbDelEspPadre.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbDelEspPadre.SelectedValue = value
            End Set
        End Property
        Private Property DelitoEspecificoPadreCodigo() As String
            Get
                Return Me.txtDelEspPadreCod.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtDelEspPadreCod.Text = value
            End Set
        End Property

        Private Property DelitoEspNombre() As String
            Get
                Return Me.txtNombre.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtNombre.Text = value
            End Set
        End Property

        Private Property DelitoEspCodigo() As String
            Get
                Return Me.txtCodDelEsp.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtCodDelEsp.Text = value
            End Set
        End Property

        Private Property Articulo() As String
            Get
                Return Me.txtArticulo.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtArticulo.Text = value
            End Set
        End Property
        Private Property Observacion() As String
            Get
                Return Me.txtObs.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtObs.Text = value
            End Set
        End Property

        Private Property Estado() As Integer
            Get
                Return Me.cbbEstado.SelectedValue
            End Get
            Set(ByVal value As Integer)
                Me.cbbEstado.SelectedValue = value

            End Set
        End Property
        Private Property MotivoBaja() As String
            Get
                Return Me.txtMotivoBaja.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtMotivoBaja.Text = value
            End Set
        End Property
#End Region
#Region "Propiedades_Grupo_Delito"
        Private Property IDGrupoCuadro As Integer = -1
        Private Property GrupoDelitoGenericoNombre As String
            Get
                Return Me.txtGrupoGenerico.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtGrupoGenerico.Text = value
            End Set
        End Property
        Private Property IDGrupoDelitoEspecifico As Integer = -1
        Private Property GrupoDelitoEspecificoNombre() As String
            Get
                Return Me.txtGrupoEspecifico.Text.Trim
            End Get
            Set(ByVal value As String)
                Me.txtGrupoEspecifico.Text = value
            End Set
        End Property
        Public Property IDGrupoDelitoDetalle As Integer = -1

#End Region
#Region "Combo"
        Private blnComboTipo As Boolean = False
        Private blnComboGenerico As Boolean = False
        Private blnComboCapitulo As Boolean = False
        Private blnComboSeccion As Boolean = False
        Private blnComboEspe As Boolean = False
        Private blnComboEstado As Boolean = False
        Private Sub Combo()

            objBss = New Bussines.Mantenimiento.General.Delito
            'delito generico
            With Me.cbbTipo
                .DataSource = objBss.Combo_DelitoTipo()
                .DisplayMember = "DelitoTipoNombre"
                .ValueMember = "DelitoTipoID"
            End With
            blnComboTipo = True

            'estado
            With Me.cbbEstado
                .DataSource = objBss.Combo_DelitoEspEstado()
                .DisplayMember = "Nombre"
                .ValueMember = "Codigo"
            End With
            Me.Estado = 1 'activo
            blnComboEstado = True
        End Sub

        Private Sub ComboGenerico()
            'delito generico
            With Me.cbbDelGenerico
                .DataSource = objBss.Combo_DelitoGenerico(Me.IDDelitoTipo)
                .DisplayMember = "getRDelitoGenericoNombreNumero"
                .ValueMember = "DelitoGenericoID"
            End With
            blnComboGenerico = True
        End Sub

        Private Sub ComboCapitulo()

            With Me.cbbDelCapitulo
                .DataSource = objBss.Combo_DelitoCapitulo(Me.IDDelitoGenerico)
                .DisplayMember = "Capitulo"
                .ValueMember = "IDDelitoCapitulo"
            End With
            blnComboCapitulo = True
        End Sub

        Private Sub ComboSeccion()

            With Me.cbbDelSeccion
                .DataSource = objBss.Combo_DelitoSeccion(Me.IDDelitoCapitulo)
                .DisplayMember = "Seccion"
                .ValueMember = "IDDelitoSeccion"
            End With
            blnComboSeccion = True

        End Sub

        Private Sub ComboEspecificoPadre()
            With Me.cbbDelEspPadre
                .DataSource = objBss.Combo_DelitoEspecifico(Me.IDDelitoGenerico)
                .DisplayMember = "DelitoEspecificoNombre"
                .ValueMember = "DelitoEspecificoID"
            End With
            blnComboEspe = True
        End Sub

#End Region
#Region "Listar"
        Private Sub Listar()

            If Me._Codigo < 1 Then
                Exit Sub
            End If

            Dim intIDDelEspePadre As Integer = -1
            Dim objEnt As New Entity.Mantenimiento.General.Delito
            objBss = New Bussines.Mantenimiento.General.Delito

            objEnt = objBss.Listar_DelitoEspecifico_v2(Me._Codigo)

            With objEnt
                Me._Codigo = .DelitoEspecificoID
                Me.DelitoEspNombre = .DelitoEspecificoNombre
                Me.DelitoEspCodigo = .DelitoEspecificoCodigo
                Me.Articulo = .DelitoArticulo
                Me.Observacion = .DelitoEspObs
                Me.Estado = .DelitoEspecificoEstado
                Me.MotivoBaja = .DelitoEspMotivoBaja

                Me.IDDelitoTipo = .DelitoTipoID

                Me.IDDelitoGenerico = .DelitoGenericoID
                Me.DelitoGenericoCodigo = .DelitoGenericoCodigo

                Me.IDDelitoCapitulo = .IDDelitoCapitulo
                Me.DelitoCapituloCodigo = .DelitoCapituloCodigo

                Me.IDDelitoSeccion = .IDDelitoSeccion
                Me.DelitoSeccionCodigo = .DelitoSeccionCodigo

                'codigo padre
                intIDDelEspePadre = .IDDelitoEspecificoPadre

                If intIDDelEspePadre > 0 Then
                    Me.chkEspecificoPadre.Checked = True
                    HabilitarDelEspePadre()
                    Me.IDDelitoEspecificoPadre = intIDDelEspePadre
                    Me.DelitoEspecificoPadreCodigo = .DelitoEspecificoPadreCodigo
                End If

                'grupo delito -cuadro 002
                Me.IDGrupoCuadro = .DelitoCuadroGrupoId
                Me.GrupoDelitoGenericoNombre = .DelitoGrupoGenericoNombre
                Me.GrupoDelitoEspecificoNombre = .DelitoGrupoEspecificoNombre
                Me.IDGrupoDelitoDetalle = .IDDelitoGrupoDelitoDet
                Me.IDGrupoDelitoEspecifico = .DelitoGrupoEspecificoId
            End With

        End Sub
#End Region
#Region "Accion"
        Private Function Validar() As Boolean

            Dim blnValue As Boolean = False

            If Me.IDDelitoTipo < 1 Then
                MessageBox.Show("Seleccione el tipo de delito",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbTipo.Focus()
                Return blnValue
            End If

            If Me.IDDelitoGenerico < 1 Then
                MessageBox.Show("Seleccione delito Generico",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbDelGenerico.Focus()
                Return blnValue
            End If

            If Me.IDDelitoCapitulo < 1 Then
                MessageBox.Show("Seleccione delito Capitulo",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbDelCapitulo.Focus()
                Return blnValue
            End If

            If Me.IDDelitoSeccion < 1 Then
                MessageBox.Show("Seleccione delito seccion",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbDelSeccion.Focus()
                Return blnValue
            End If

            If Me.DelitoEspNombre.Trim.Length < 1 Then
                MessageBox.Show("Ingrese el nombre del delito",
                 Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.txtNombre.Focus()
                Return blnValue
            End If

            If Me.Estado < 0 Then
                MessageBox.Show("Seleccion el estado del delito",
                Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Me.cbbEstado.Focus()
                Return blnValue
            End If

            If Me.Estado = 0 Then 'anulado
                If Me.MotivoBaja.Trim.Length < 5 Then
                    MessageBox.Show("Ingrese el motivo de baja del delito",
                    Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Me.txtMotivoBaja.Focus()
                    Return blnValue
                End If
            End If

            If Me._Codigo > 0 Then
                objBss = New Bussines.Mantenimiento.General.Delito
                Dim obj As New Entity.Mantenimiento.General.ReporteCuadro2_Detalle
                Dim strMensajeOut As String = "El Delito : " & DelitoEspNombre + Chr(13) +
                                                             "_______________________________________" + Chr(13) +
                                                             "ya ha sido registrado en un expediente" + Chr(13) +
                                                                   "Operación Cancelada..."

                If objBss.ValidarDelitoEspeUso(Me._Codigo, Me.DelitoEspNombre, Me.Articulo) = True Then
                    MessageBox.Show(strMensajeOut, Legolas.Configuration.Aplication.MessageBox.MensajeTitulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Return blnValue
                End If
            End If

            If Me.IDGrupoCuadro < 1 Then
                If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar("No ha seleccionado un Grupo Delito, de todas maneras desea grabar el delito") <> Windows.Forms.DialogResult.Yes Then
                    Return blnValue
                End If
            End If

            blnValue = True

            Return blnValue
        End Function
        Private Sub AOK()

            If Validar() = False Then
                Exit Sub
            End If

            If Legolas.Configuration.Aplication.MessageBox.QuestionGrabar <> Windows.Forms.DialogResult.Yes Then
                Exit Sub
            End If

            Dim intValue As Integer = -1
            Dim ObjEnt As New Entity.Mantenimiento.General.Delito
            With ObjEnt
                .DelitoEspecificoID = Me._Codigo
                .DelitoEspecificoNombre = Me.DelitoEspNombre
                .DelitoEspecificoCodigo = Me.DelitoEspCodigo
                .DelitoArticulo = Me.Articulo
                .DelitoEspObs = Me.Observacion
                .DelitoEspecificoEstado = Me.Estado
                .DelitoEspMotivoBaja = Me.MotivoBaja
                .DelitoTipoID = Me.IDDelitoTipo
                .DelitoGenericoID = Me.IDDelitoGenerico
                .DelitoGenericoCodigo = Me.DelitoGenericoCodigo
                .IDDelitoCapitulo = Me.IDDelitoCapitulo
                .DelitoCapituloCodigo = Me.DelitoCapituloCodigo
                .IDDelitoSeccion = Me.IDDelitoSeccion
                .DelitoSeccionCodigo = Me.DelitoSeccionCodigo
                .IDDelitoEspecificoPadre = Me.IDDelitoEspecificoPadre
                .DelitoEspecificoPadreCodigo = Me.DelitoEspecificoPadreCodigo
            End With

            Dim strMensajeOut As String = ""
            objBss = New Bussines.Mantenimiento.General.Delito
            intValue = objBss.Grabar(ObjEnt, strMensajeOut)

            If intValue > 0 Then

                Dim intIDCuadroDelitoDet As Integer = -1
                objBssGrupoDelitoDet = New Bussines.Mantenimiento.General.Reportecuadro2_Detalle
                intIDCuadroDelitoDet = objBssGrupoDelitoDet.Grabar(Me.IDGrupoDelitoDetalle, Me.IDGrupoCuadro, intValue, Me.DelitoEspNombre, 2, strMensajeOut) 'cuadro version 2

                If intIDCuadroDelitoDet > 0 Then
                    Legolas.Configuration.Aplication.MessageBox.InformationGrabar()
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    If strMensajeOut.Trim.Length > 1 Then
                        Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                    Else
                        Legolas.Configuration.Aplication.MessageBox.MensajeError("La operacion no se ha realizado correctamente. Intente nuevamente")
                    End If
                End If

            Else
                If strMensajeOut.Trim.Length > 1 Then
                    Legolas.Configuration.Aplication.MessageBox.Exclamation(strMensajeOut)
                Else
                    Legolas.Configuration.Aplication.MessageBox.MensajeError("La operacion no se ha realizado correctamente. Intente nuevamente")
                End If
            End If
        End Sub

#End Region
#Region "Form"
        Private Sub frmBuscarGrupoDelito()
            Dim frm As New Mantenimiento.Reporte.frmBuscarPopup
            If frm.ShowDialog = DialogResult.OK Then
                Me.IDGrupoCuadro = frm._getIDCuadro
                Me.GrupoDelitoGenericoNombre = frm._getGrupoGenerico
                Me.GrupoDelitoEspecificoNombre = frm._getGrupoEspecifico
            End If
        End Sub
#End Region
#Region "Otros"
        Private Sub PermisosLicencia()

            Select Case Configuracion.Licencia.Codigo
                Case 1 'sede central

                    Me.btnOK.Enabled = Me._FormEscritura
                    Me.btnAgregar.Enabled = Me._FormEscritura

                Case Else
                    Me.btnOK.Enabled = False
                    Me.btnAgregar.Enabled = False
            End Select

        End Sub
        Private Sub ValoresxDefault()
            PermisosLicencia()
            ComboGenerico()
            ComboCapitulo()
            ComboSeccion()

        End Sub
        Private Sub HabilitarDelEspePadre()

            If Me.chkEspecificoPadre.Checked = True Then
                Me.cbbDelEspPadre.Enabled = True
                ComboEspecificoPadre()
            Else
                Me.cbbDelEspPadre.Enabled = False
                Me.IDDelitoEspecificoPadre = -1
                Me.DelitoEspecificoPadreCodigo = ""
            End If

        End Sub
        Private Sub HabilitarEstado()

            If Me.Estado = 0 Then 'anulado
                Me.txtMotivoBaja.Enabled = True
                Me.txtMotivoBaja.Focus()
            Else
                Me.MotivoBaja = ""
                Me.txtMotivoBaja.Enabled = False
            End If

        End Sub
#End Region
        Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
            AOK()
        End Sub

        Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()

        End Sub

        Private Sub frmMantPopup_Load(sender As Object, e As System.EventArgs) Handles Me.Load

            Combo()

        End Sub

        Private Sub frmSalaPopup_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

            ValoresxDefault()
            Listar()

        End Sub

        Private Sub cbbTipo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbTipo.SelectedIndexChanged

            If blnComboTipo = True Then
                ComboGenerico()
            End If

        End Sub

        Private Sub cbbDelGenerico_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbDelGenerico.SelectedIndexChanged

            If blnComboGenerico = True Then

                objBss = New Bussines.Mantenimiento.General.Delito

                If Me.IDDelitoGenerico > 0 Then
                    Me.DelitoGenericoCodigo = objBss.Listar_DelitoGenerico_Codigo(Me.IDDelitoGenerico)
                End If

                ComboCapitulo()

                If Me.chkEspecificoPadre.Checked = True Then
                    ComboEspecificoPadre()
                End If

            End If

        End Sub

        Private Sub cbbDelCapitulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbDelCapitulo.SelectedIndexChanged

            If blnComboCapitulo = True Then
                objBss = New Bussines.Mantenimiento.General.Delito

                If Me.IDDelitoCapitulo > 0 Then
                    Me.DelitoCapituloCodigo = objBss.Listar_DelitoCapitulo_Codigo(Me.IDDelitoCapitulo)
                End If

                ComboSeccion()
            End If

        End Sub

        Private Sub cbbDelSeccion_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbDelSeccion.SelectedIndexChanged

            If blnComboSeccion = True Then
                objBss = New Bussines.Mantenimiento.General.Delito

                If Me.IDDelitoSeccion > 0 Then
                    Me.DelitoSeccionCodigo = objBss.Listar_DelitoSeccion_Codigo(Me.IDDelitoSeccion)
                End If

            End If

        End Sub

        Private Sub cbbDelEspPadre_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbDelEspPadre.SelectedIndexChanged

            If blnComboEspe = True Then
                objBss = New Bussines.Mantenimiento.General.Delito

                If Me.IDDelitoEspecificoPadre > 0 Then
                    Me.DelitoEspecificoPadreCodigo = objBss.Listar_DelitoEspecifico_Codigo(Me.IDDelitoEspecificoPadre)
                End If

            End If

        End Sub
        Private Sub chkEspecificoPadre_Click(sender As Object, e As System.EventArgs) Handles chkEspecificoPadre.Click

            HabilitarDelEspePadre()

        End Sub

        Private Sub chkEspecificoPadre_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkEspecificoPadre.CheckedChanged

        End Sub

        Private Sub cbbEstado_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbbEstado.SelectedIndexChanged

            If blnComboEstado = True Then
                HabilitarEstado()
            End If

        End Sub

        Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
            frmBuscarGrupoDelito()
        End Sub
    End Class

End Namespace
